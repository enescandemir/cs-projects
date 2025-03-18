using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsUI.License
{
    public partial class FormLicenseDetails : Form
    {
        public Entities.Concrete.License License { get; set; }
        private LicenseManager licenseManager = new LicenseManager(new EfLicenseDal());

        public FormLicenseDetails(Entities.Concrete.License license = null)
        {
            InitializeComponent();
            LoadLicenseTypes();
            LoadCustomers();

            if (license != null)
            {
                License = license;
                cmbCustomerID.SelectedValue = (int)License.CustomerID;
                cmbType.SelectedValue = (int)license.Type;
                dtpStartDate.Value = license.StartDate;
                dtpEndDate.Value = license.EndDate;
                txtDescription.Text = license.Description;
            }
            else
            {
                License = new Entities.Concrete.License();
            }
        }

        private void LoadLicenseTypes()
        {
            cmbType.DataSource = new[]
            {
                new { Key = (int)LicenseType.Demo, Value = "Demo" },
                new { Key = (int)LicenseType.SixMonths, Value = "6 Aylık" }
            }.ToList();

            cmbType.DisplayMember = "Value";
            cmbType.ValueMember = "Key";
        }
        private void LoadCustomers()
        {
            var customers = new CustomerManager(new EfCustomerDal()).GetAll(); 
            cmbCustomerID.DataSource = customers;
            cmbCustomerID.DisplayMember = "Name"; 
            cmbCustomerID.ValueMember = "CustomerID"; 
            cmbCustomerID.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            License.CustomerID = (int)cmbCustomerID.SelectedValue;
            License.Type = (int)cmbType.SelectedValue;
            License.StartDate = dtpStartDate.Value;
            License.EndDate = dtpEndDate.Value;
            License.Description = txtDescription.Text;

            if (License.LicenseID == 0)
            {
                licenseManager.Add(License);
            }
            else
            {
                licenseManager.Update(License);
            }

            MessageBox.Show("Lisans işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
