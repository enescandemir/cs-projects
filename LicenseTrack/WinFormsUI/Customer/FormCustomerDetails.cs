using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation;
using MaterialSkin.Controls;
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
    public partial class FormCustomerDetails : MaterialForm
    {
        public Entities.Concrete.Customer Customer { get; set; }
        private CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public FormCustomerDetails(Entities.Concrete.Customer customer = null)
        {
            InitializeComponent();
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
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
            txtAddress.TextChanged += txtAddress_TextChanged;


        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.TextChanged -= txtAddress_TextChanged;

            int cursorPosition = txtAddress.SelectionStart;
            string digitsOnly = new string(txtAddress.Text.Where(char.IsDigit).ToArray());

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < digitsOnly.Length; i++)
            {
                sb.Append(digitsOnly[i]);
                if ((i + 1) % 3 == 0 && i + 1 != digitsOnly.Length && (i + 1) / 3 < 4)
                {
                    sb.Append('.');
                }
            }

            txtAddress.Text = sb.ToString();
            txtAddress.SelectionStart = Math.Min(cursorPosition + (txtAddress.Text.Length - digitsOnly.Length), txtAddress.Text.Length);

            txtAddress.TextChanged += txtAddress_TextChanged;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer.Name = txtName.Text;
            Customer.DBName = txtDBName.Text;
            Customer.Address = txtAddress.Text;

            if (!string.IsNullOrWhiteSpace(txtPort.Text))
            {
                if (int.TryParse(txtPort.Text, out int portValue))
                {
                    Customer.Port = portValue;
                }
                else
                {
                    MessageBox.Show("Port sadece 1 ile 65535 arasında olmalıdır (sayı olarak).", "Geçersiz Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                Customer.Port = null;
            }

            try
            {
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
            catch (ValidationException vex)
            {
                MessageBox.Show("Doğrulama hatası:\n" + vex.Message, "Geçersiz Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
