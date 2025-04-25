using Business.Concrete;
using DataAccess.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;
using System.Security.Claims;
using Entities.Concrete.DTOs;

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
                var programLicenses = programLicenseManager.GetAllWithNames();
                dgwProgramLicense.DataSource = programLicenses;

                dgwProgramLicense.Columns["ProgramLicenseID"].HeaderText = "Program-Lisans ID";
                dgwProgramLicense.Columns["ProgramName"].HeaderText = "Program Adı";
                dgwProgramLicense.Columns["CustomerName"].HeaderText = "Müşteri Adı";
                dgwProgramLicense.Columns["LicenseType"].HeaderText = "Tip";
                dgwProgramLicense.Columns["LicenseStartDate"].HeaderText = "Başlangıç Tarihi";
                dgwProgramLicense.Columns["LicenseEndDate"].HeaderText = "Bitiş Tarihi";
                dgwProgramLicense.Columns["LicenseDescription"].HeaderText = "Açıklama";

                dgwProgramLicense.CellFormatting += DgwProgramLicense_CellFormatting;

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


        private void DgwProgramLicense_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwProgramLicense.Columns[e.ColumnIndex].Name == "LicenseType" && e.Value != null)
            {
                e.Value = e.Value.ToString() == "1" ? "Demo" :
                          e.Value.ToString() == "2" ? "6 Aylık" : "Bilinmeyen";
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

            FormProgramLicenseDetails form = new FormProgramLicenseDetails();
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

            if (dgwProgramLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir program lisansı seçin.");
                return;
            }

            ProgramLicenseDto selectedLicenseDTO = (ProgramLicenseDto)dgwProgramLicense.CurrentRow.DataBoundItem;

            var originalProgramLicense = programLicenseManager.GetByProgramLicenseId(selectedLicenseDTO.ProgramLicenseID).FirstOrDefault();

            if (originalProgramLicense == null)
            {
                MessageBox.Show("Seçilen program lisansı bulunamadı.");
                return;
            }
            FormProgramLicenseDetails form = new FormProgramLicenseDetails(originalProgramLicense);
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

            if (dgwProgramLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir program lisansı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProgramLicenseDto selectedProgramLicenseDto = (ProgramLicenseDto)dgwProgramLicense.CurrentRow.DataBoundItem;

            var originalProgramLicense = programLicenseManager.GetByProgramLicenseId(selectedProgramLicenseDto.ProgramLicenseID).FirstOrDefault();

            if (originalProgramLicense == null)
            {
                MessageBox.Show("Seçilen program lisansı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedProgramLicenseDto.ProgramName} adlı program lisansını ve müşteri bilgilerini silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                programLicenseManager.Delete(originalProgramLicense);
                MessageBox.Show("Program lisansı ve ilişkili bilgiler başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                string role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value; 
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
            var programLicenses = programLicenseManager.GetAllWithNames();
            dgwProgramLicense.DataSource = null;
            dgwProgramLicense.DataSource = programLicenses; 
        }

    }
}
