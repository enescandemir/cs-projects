using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.License;

namespace WinFormsUI.Version
{
    public partial class FormVersion : Form
    {
        VersionManager versionManager = new VersionManager(new EfVersionDal());
        public FormVersion()
        {
            InitializeComponent();
            this.Load += FormVersion_Load;
        }
        private void FormVersion_Load(object sender, EventArgs e)
        {
            try
            {
                var versions = versionManager.GetAll();
                dgwVersion.DataSource = versions;

                if (versions.Count == 0)
                {
                    MessageBox.Show("Veritabanında versiyon bilgisi bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormVersionDetails form = new FormVersionDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwVersion.DataSource = versionManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgwVersion.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir versiyon seçin.");
                return;
            }

            Entities.Concrete.Version selectedVersion = (Entities.Concrete.Version)dgwVersion.CurrentRow.DataBoundItem;

            FormVersionDetails form = new FormVersionDetails(selectedVersion);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwVersion.DataSource = versionManager.GetAll();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgwVersion.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir versiyon seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Entities.Concrete.Version selectedVersion = (Entities.Concrete.Version)dgwVersion.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedVersion.VersionID} numaralı versiyonu silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                versionManager.Delete(selectedVersion);
                MessageBox.Show("Versiyon başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwVersion.DataSource = versionManager.GetAll();
            }
        }
    }
}