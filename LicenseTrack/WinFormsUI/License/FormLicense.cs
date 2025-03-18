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
using LicenseManager = Business.Concrete.LicenseManager;

namespace WinFormsUI.License
{
    public partial class FormLicense : Form
    {
        LicenseManager licenseManager = new LicenseManager(new EfLicenseDal());
        public FormLicense()
        {
            InitializeComponent();
            this.Load += FormLicense_Load;
        }
        private void FormLicense_Load(object sender, EventArgs e)
        {
            try
            {
                var licenses = licenseManager.GetAll();
                dgwLicense.DataSource = licenses;

                if (licenses.Count == 0)
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
            FormLicenseDetails form = new FormLicenseDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwLicense.DataSource = licenseManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dgwLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir lisans seçin.");
                return;
            }

            Entities.Concrete.License selectedLicense = (Entities.Concrete.License)dgwLicense.CurrentRow.DataBoundItem;

            FormLicenseDetails form = new FormLicenseDetails(selectedLicense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwLicense.DataSource = licenseManager.GetAll();
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgwLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir lisans seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Entities.Concrete.License selectedLicense = (Entities.Concrete.License)dgwLicense.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedLicense.LicenseID} numaralı lisansı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                licenseManager.Delete(selectedLicense);
                MessageBox.Show("Lisans başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwLicense.DataSource = licenseManager.GetAll();
            }

        }
    }
}
