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
        UpdateTableManager updateTableManager = new UpdateTableManager(new EfUpdateTableDal());

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

                dgwVersion.Columns["VersionID"].HeaderText = "Versiyon ID";
                dgwVersion.Columns["Type"].HeaderText = "Versiyon Tipi";
                dgwVersion.Columns["Name"].HeaderText = "Adı";
                dgwVersion.Columns["Number"].HeaderText = "Numarası";
                dgwVersion.Columns["Description"].HeaderText = "Açıklama";
                dgwVersion.Columns["DependentID"].HeaderText = "Bağlı Olduğu Versiyon ID";

                if (versions.Count == 0)
                {
                    MessageBox.Show("Veritabanında versiyon bilgisi bulunamadı.");
                }

                dgwVersion.CellFormatting += DgwVersion_CellFormatting;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void DgwVersion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwVersion.Columns[e.ColumnIndex].Name == "Type" && e.Value != null)
            {
                e.Value = e.Value.ToString() == "1" ? "Veritabanı" :
                          e.Value.ToString() == "2" ? "Program" : "Bilinmeyen";
                e.FormattingApplied = true;
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
                $"{selectedVersion.VersionID} numaralı versiyonu ve bağlı tüm kayıtları silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteVersionWithDependencies(selectedVersion.VersionID);
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
        private void DeleteVersionWithDependencies(int versionId)
        {
            var dependentVersions = versionManager.GetAll().Where(v => v.DependentID == versionId).ToList();
            foreach (var dependentVersion in dependentVersions)
            {
                DeleteVersionWithDependencies(dependentVersion.VersionID);
            }

            var dependentUpdates = updateTableManager.GetAll().Where(u => u.VersionID == versionId).ToList();

            foreach (var update in dependentUpdates)
            {
                updateTableManager.Delete(update);
            }

            var version = versionManager.GetByVersionId(versionId).FirstOrDefault();
            if (version != null)
            {
                versionManager.Delete(version);
                MessageBox.Show($"Versiyon ID {versionId} ve bağlı tüm kayıtlar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
