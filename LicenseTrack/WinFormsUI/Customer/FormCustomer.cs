using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Core.Utilities.Session;

namespace WinFormsUI.Customer
{
    public partial class FormCustomer : MaterialForm
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

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
                $"{selectedCustomer.Name} adlı müşteriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                customerManager.Delete(selectedCustomer);
                MessageBox.Show("Müşteri başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
