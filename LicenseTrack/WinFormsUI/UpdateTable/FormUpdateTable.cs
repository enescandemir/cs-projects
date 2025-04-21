using Business.Concrete;
using DataAccess.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session; 

namespace WinFormsUI.UpdateTable
{
    public partial class FormUpdateTable : MaterialForm
    {
        UpdateTableManager updateTableManager = new UpdateTableManager(new EfUpdateTableDal());

        public FormUpdateTable()
        {
            InitializeComponent();
            this.Load += FormUpdateTable_Load;
        }

        private void FormUpdateTable_Load(object sender, EventArgs e)
        {
            try
            {
                var updates = updateTableManager.GetAll();
                dgwUpdateTable.DataSource = updates;

                if (updates.Count == 0)
                {
                    MessageBox.Show("Veritabanında güncelleme kaydı bulunamadı.");
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

            FormUpdateTableDetails form = new FormUpdateTableDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwUpdateTable.DataSource = updateTableManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwUpdateTable.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir kayıt seçin.");
                return;
            }

            Entities.Concrete.UpdateTable selectedUpdate = (Entities.Concrete.UpdateTable)dgwUpdateTable.CurrentRow.DataBoundItem;
            FormUpdateTableDetails form = new FormUpdateTableDetails(selectedUpdate);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwUpdateTable.DataSource = updateTableManager.GetAll();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwUpdateTable.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entities.Concrete.UpdateTable selectedUpdate = (Entities.Concrete.UpdateTable)dgwUpdateTable.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedUpdate.UpdateID} numaralı güncellemeyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                updateTableManager.Delete(selectedUpdate);
                MessageBox.Show("Güncelleme başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwUpdateTable.DataSource = updateTableManager.GetAll();
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
