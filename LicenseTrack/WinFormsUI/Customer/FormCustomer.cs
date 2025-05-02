using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;
using System.ComponentModel;

namespace WinFormsUI.Customer
{
    public partial class FormCustomer : MaterialForm
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        Business.Concrete.LicenseManager licenseManager = new Business.Concrete.LicenseManager(new EfLicenseDal());
        ProgramLicenseManager programLicenseManager = new ProgramLicenseManager(new EfProgramLicenseDal());
        UpdateTableManager updateTableManager = new UpdateTableManager(new EfUpdateTableDal());

        public FormCustomer()
        {
            InitializeComponent();
            this.Load += FormCustomer_Load;

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                var customers = customerManager.GetAll();
                dgwCustomers.DataSource = customers;
                SetColumnHeaders();

                if (customers.Count == 0)
                {
                    MessageBox.Show("Veritabanında müşteri bulunamadı.");
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
            FormCustomerDetails form = new FormCustomerDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwCustomers.DataSource = customerManager.GetAll();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwCustomers.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.");
                return;
            }

            Entities.Concrete.Customer selectedCustomer = (Entities.Concrete.Customer)dgwCustomers.CurrentRow.DataBoundItem;

            FormCustomerDetails form = new FormCustomerDetails(selectedCustomer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwCustomers.DataSource = customerManager.GetAll();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için admin yetkisine sahip olmalısınız.", "Yetkisiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgwCustomers.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entities.Concrete.Customer selectedCustomer = (Entities.Concrete.Customer)dgwCustomers.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show(
                $"{selectedCustomer.Name} adlı müşteri ve bağlı tüm lisansları silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteCustomerWithDependencies(selectedCustomer.CustomerID);

                dgwCustomers.DataSource = customerManager.GetAll();
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
        private void DeleteCustomerWithDependencies(int customerId)
        {
            DeleteUpdatesWithDependencies(customerId);

            DeleteLicenseWithDependencies(customerId);

            var customer = customerManager.GetByCustomerId(customerId).FirstOrDefault();
            if (customer != null)
            {
                customerManager.Delete(customer);
                MessageBox.Show("Müşteri ve tüm bağlı kayıtlar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void DeleteLicenseWithDependencies(int customerId)
        {
            var dependentLicenses = licenseManager.GetAll().Where(l => l.CustomerID == customerId).ToList();

            foreach (var license in dependentLicenses)
            {
                var dependentProgramLicenses = programLicenseManager.GetByLicenseId(license.LicenseID).ToList();
                foreach (var programLicense in dependentProgramLicenses)
                {
                    programLicenseManager.Delete(programLicense);
                }

                licenseManager.Delete(license);
            }

            MessageBox.Show("Müşteriye bağlı lisanslar ve program lisansları başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteUpdatesWithDependencies(int customerId)
        {
            var dependentUpdateTables = updateTableManager.GetAll().Where(u => u.CustomerID == customerId).ToList();
            foreach (var updateTable in dependentUpdateTables)
            {
                updateTableManager.Delete(updateTable);
            }

            MessageBox.Show("Bağlı güncelleme kayıtları başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SetColumnHeaders()
        {
            dgwCustomers.Columns["CustomerID"].HeaderText = "Müşteri ID";
            dgwCustomers.Columns["Name"].HeaderText = "Müşteri Adı";
            dgwCustomers.Columns["DBName"].HeaderText = "Veritabanı Adı";
            dgwCustomers.Columns["Address"].HeaderText = "Adres";
            dgwCustomers.Columns["Port"].HeaderText = "Port";
        }



    }
}
