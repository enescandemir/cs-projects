using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Customer;

namespace WinFormsUI
{
    public partial class FormCustomer : Form
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
            FormCustomerDetails form = new FormCustomerDetails();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgwCustomers.DataSource = customerManager.GetAll();
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
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

        private void dgwCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
