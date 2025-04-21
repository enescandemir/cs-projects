using Business.Concrete;
using DataAccess.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;
using System.Security.Claims; 

namespace WinFormsUI.ProgramLicense
{
    public partial class FormProgramLicense : MaterialForm
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
                    MessageBox.Show("Veritabanında program lisansı bulunamadı.");
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

            FormProgramLicenseDetails form = new FormProgramLicenseDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwProgramLicense.DataSource = programLicenseManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwProgramLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir program lisansı seçin.");
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
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwProgramLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir program lisansı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entities.Concrete.ProgramLicense selectedProgramLicense = (Entities.Concrete.ProgramLicense)dgwProgramLicense.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedProgramLicense.ProgramID} numaralı program lisansını silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                programLicenseManager.Delete(selectedProgramLicense);
                MessageBox.Show("Program lisansı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwProgramLicense.DataSource = programLicenseManager.GetAll();
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
