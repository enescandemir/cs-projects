using Business.Concrete;
using DataAccess.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Security.Claims;
using System.Windows.Forms;
using Core.Utilities.Session; 
using LicenseManager = Business.Concrete.LicenseManager;
using Entities.Concrete.DTOs;

namespace WinFormsUI.License
{
    public partial class FormLicense : MaterialForm
    {
        LicenseManager licenseManager = new LicenseManager(new EfLicenseDal());
        ProgramLicenseManager programLicenseManager = new ProgramLicenseManager(new EfProgramLicenseDal());
        public FormLicense()
        {
            InitializeComponent();
            this.Load += FormLicense_Load;
        }

        private void FormLicense_Load(object sender, EventArgs e)
        {
            try
            {
                var licensesWithNames = licenseManager.GetAllWithNames();
                dgwLicense.DataSource = licensesWithNames;
                dgwLicense.Columns["LicenseID"].HeaderText = "Lisans ID";
                dgwLicense.Columns["CustomerName"].HeaderText = "Müşteri Adı";
                dgwLicense.Columns["Type"].HeaderText = "Tip";
                dgwLicense.Columns["StartDate"].HeaderText = "Başlangıç Tarihi";
                dgwLicense.Columns["EndDate"].HeaderText = "Bitiş Tarihi";
                dgwLicense.Columns["Description"].HeaderText = "Açıklama";

                if (licensesWithNames.Count == 0)
                {
                    MessageBox.Show("Veritabanında lisans bulunamadı.");
                }

                dgwLicense.CellFormatting += DgwLicense_CellFormatting;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void DgwLicense_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwLicense.Columns[e.ColumnIndex].Name == "Type" && e.Value != null)
            {
                e.Value = e.Value.ToString() == "1" ? "1 Günlük" :
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

            FormLicenseDetails form = new FormLicenseDetails(); 
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

            if (dgwLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir lisans seçin.");
                return;
            }

            CustomerLicenseDto selectedLicenseDTO = (CustomerLicenseDto)dgwLicense.CurrentRow.DataBoundItem;

            var originalLicense = licenseManager.GetByLicenseId(selectedLicenseDTO.LicenseID).FirstOrDefault();

            if (originalLicense == null)
            {
                MessageBox.Show("Seçilen lisans bulunamadı.");
                return;
            }

            FormLicenseDetails form = new FormLicenseDetails(originalLicense);
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

            if (dgwLicense.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir lisans seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomerLicenseDto selectedLicenseDto = (CustomerLicenseDto)dgwLicense.CurrentRow.DataBoundItem;

            var originalLicense = licenseManager.GetByLicenseId(selectedLicenseDto.LicenseID).FirstOrDefault();

            if (originalLicense == null)
            {
                MessageBox.Show("Seçilen lisans bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"{originalLicense.LicenseID} numaralı lisansı ve bağlı tüm Program-Lisans verilerini silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteProgramLicensesWithDependencies(originalLicense.LicenseID);

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
        private void DeleteProgramLicensesWithDependencies(int licenseId)
        {
            var dependentProgramLicenses = programLicenseManager.GetByLicenseId(licenseId).ToList();

            foreach (var programLicense in dependentProgramLicenses)
            {
                programLicenseManager.Delete(programLicense); 
            }

            var license = licenseManager.GetByLicenseId(licenseId).FirstOrDefault();
            if (license != null)
            {
                licenseManager.Delete(license); 
                MessageBox.Show("Lisans ve bağlı program lisansları başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RefreshDataGridView()
        {
            var licenses = licenseManager.GetAllWithNames();
            dgwLicense.DataSource = null;
            dgwLicense.DataSource = licenses;
        }


    }
}
