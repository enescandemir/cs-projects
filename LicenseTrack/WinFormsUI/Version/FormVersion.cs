using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;
namespace WinFormsUI.Version
{
    public partial class FormVersion : MaterialForm
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
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormVersionDetails form = new FormVersionDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwVersion.DataSource = versionManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                string role = claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role)?.Value; 
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
