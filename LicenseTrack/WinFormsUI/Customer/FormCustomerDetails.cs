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

namespace WinFormsUI.Customer
{
    public partial class FormCustomerDetails : Form
    {
        public Entities.Concrete.Customer Customer { get; set; }
        private CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public FormCustomerDetails(Entities.Concrete.Customer customer = null)
        {
            InitializeComponent();
            if (customer != null)
            {
                Customer = customer;
                txtName.Text = customer.Name;
                txtDBName.Text = customer.DBName;
                txtAddress.Text = customer.Address;
                txtPort.Text = customer.Port.ToString();
            }
            else
            {
                Customer = new Entities.Concrete.Customer();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer.Name = txtName.Text;
            Customer.DBName = txtDBName.Text;
            Customer.Address = txtAddress.Text;
            Customer.Port = int.Parse(txtPort.Text);

            if (Customer.CustomerID == 0) 
            {
                customerManager.Add(Customer);
            }
            else 
            {
                customerManager.Update(Customer);
            }

            MessageBox.Show("İşlem başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
