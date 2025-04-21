using Business.Concrete;
using DataAccess.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Security.Claims;
using System.Windows.Forms;
using Core.Utilities.Session; 
using LicenseManager = Business.Concrete.LicenseManager;

namespace WinFormsUI.License
{
    public partial class FormLicense : MaterialForm
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
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormLicenseDetails form = new FormLicenseDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwLicense.DataSource = licenseManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private bool IsAdmin()
        {
            if (string.IsNullOrEmpty(Session.JwtToken))
            {
                MessageBox.Show("Yetki doğrulama için bir token bulunamadı. Lütfen giriş yapın.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(Session.JwtToken);
                var claims = jwtToken.Claims;

                string role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value; 
                return role == "Admin"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Token doğrulama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
