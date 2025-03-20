using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.ProgramFrm;

namespace WinFormsUI.ProgramLicense
{
    public partial class FormProgramLicense : Form
    {
        ProgramLicenseManager programLicenseManager = new ProgramLicenseManager(new EfProgramLicenseDal());
        public FormProgramLicense()
        {
            InitializeComponent();
            this.Load += FormProgramLicense_Load;
        }
        private void FormProgramLicense_Load(object sender, EventArgs e)
        {
            try
            {
                var programLicenses = programLicenseManager.GetAll();
                dgwProgramLicense.DataSource = programLicenses;

                if (programLicenses.Count == 0)
                {
                    MessageBox.Show("Veritabanında lisans bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormProgramLicenseDetails form = new FormProgramLicenseDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwProgramLicense.DataSource = programLicenseManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgwProgramLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir program seçin.");
                return;
            }
            Entities.Concrete.ProgramLicense selectedProgramLicense = (Entities.Concrete.ProgramLicense)dgwProgramLicense.CurrentRow.DataBoundItem;

            FormProgramLicenseDetails form = new FormProgramLicenseDetails(selectedProgramLicense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwProgramLicense.DataSource = programLicenseManager.GetAll();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgwProgramLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir program seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entities.Concrete.ProgramLicense selectedProgramLicense = (Entities.Concrete.ProgramLicense)dgwProgramLicense.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedProgramLicense.ProgramID} numaralı programı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                programLicenseManager.Delete(selectedProgramLicense);
                MessageBox.Show("Program başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwProgramLicense.DataSource = programLicenseManager.GetAll();
            }
        }
    }
}
