using Business.Concrete;
using DataAccess.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;
using Entities.Concrete.DTOs.Entities.Concrete.DTOs;

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
                var updates = updateTableManager.GetAllWithNames(); 
                dgwUpdateTable.DataSource = updates;
                SetColumnHeaders();

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
                RefreshDataGridView();
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

            UpdateTableDto selectedUpdateDTO = (UpdateTableDto)dgwUpdateTable.CurrentRow.DataBoundItem;
            var originalUpdate = updateTableManager.GetByUpdateId(selectedUpdateDTO.UpdateID).FirstOrDefault();

            if (originalUpdate == null)
            {
                MessageBox.Show("Seçilen güncelleme bulunamadı.");
                return;
            }

            FormUpdateTableDetails form = new FormUpdateTableDetails(originalUpdate);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGridView();
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

            UpdateTableDto selectedUpdateDto = (UpdateTableDto)dgwUpdateTable.CurrentRow.DataBoundItem;

            var originalUpdate = updateTableManager.GetByUpdateId(selectedUpdateDto.UpdateID).FirstOrDefault();

            if (originalUpdate == null)
            {
                MessageBox.Show("Seçilen güncelleme bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"{originalUpdate.UpdateID} numaralı güncellemeyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                updateTableManager.Delete(originalUpdate);
                MessageBox.Show("Güncelleme başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
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
        private void RefreshDataGridView()
        {
            var updates = updateTableManager.GetAllWithNames();
            dgwUpdateTable.DataSource = null;
            dgwUpdateTable.DataSource = updates;
            SetColumnHeaders();
        }
        private void SetColumnHeaders()
        {
            dgwUpdateTable.Columns["UpdateID"].HeaderText = "Güncelleme ID";
            dgwUpdateTable.Columns["CustomerName"].HeaderText = "Müşteri Adı";
            dgwUpdateTable.Columns["VersionName"].HeaderText = "Versiyon Adı";
            dgwUpdateTable.Columns["UpdateDate"].HeaderText = "Güncelleme Tarihi";
            dgwUpdateTable.Columns["Description"].HeaderText = "Açıklama";
        }

    }
}
