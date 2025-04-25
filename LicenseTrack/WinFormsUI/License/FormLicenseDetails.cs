using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.Enums;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsUI.License
{
    public partial class FormLicenseDetails : MaterialForm
    {
        public Entities.Concrete.License License { get; set; }
        private LicenseManager licenseManager = new LicenseManager(new EfLicenseDal());

        public FormLicenseDetails(Entities.Concrete.License license = null)
        {
            InitializeComponent();
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );

            LoadLicenseTypes();
            LoadCustomers();

            if (license != null)
            {
                License = license;
                cmbCustomer.SelectedValue = (int)License.CustomerID;
                cmbType.SelectedValue = (int)license.Type;
                dtpStartDate.Value = license.StartDate;
                dtpEndDate.Value = license.EndDate;
                txtDescription.Text = license.Description;
                dtpEndDate.Enabled = false;
            }
            else
            {
                License = new Entities.Concrete.License();
                if ((int)cmbType.SelectedValue == (int)LicenseType.Demo)
                {
                    dtpStartDate.Value = DateTime.Today;
                    dtpEndDate.Value = DateTime.Today.AddDays(1);
                }

                dtpEndDate.Enabled = false;
            } 
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
        }

        private void LoadLicenseTypes()
        {
            var licenseTypes = Enum.GetValues(typeof(LicenseType))
                .Cast<LicenseType>()
                .Select(x => new { Key = (int)x, Value = GetLicenseTypeDescription(x) })
                .ToList();

            cmbType.DataSource = licenseTypes;
            cmbType.DisplayMember = "Value";
            cmbType.ValueMember = "Key";
        }

        private string GetLicenseTypeDescription(LicenseType type)
        {
            switch (type)
            {
                case LicenseType.Demo:
                    return "1 Günlük";
                case LicenseType.SixMonths:
                    return "6 Aylık";
                default:
                    return type.ToString();
            }
        }


        private void LoadCustomers()
        {
            var customers = new CustomerManager(new EfCustomerDal()).GetAll(); 
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name"; 
            cmbCustomer.ValueMember = "CustomerID"; 
            cmbCustomer.SelectedIndex = -1;
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedValue is int selectedType)
            {
                if (selectedType == (int)LicenseType.SixMonths)
                {
                    dtpStartDate.Value = DateTime.Now;
                    dtpEndDate.Value = dtpStartDate.Value.AddMonths(6);
                }
                else if (selectedType == (int)LicenseType.Demo)
                {
                    dtpStartDate.Value = DateTime.Now;
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
                }
                else
                {
                    dtpStartDate.Value = DateTime.Now;
                    dtpEndDate.Value = DateTime.Now.AddYears(1);
                }
            }
        }


        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedValue is int selectedType)
            {
                if (selectedType == (int)LicenseType.SixMonths)
                {
                    dtpEndDate.Value = dtpStartDate.Value.AddMonths(6);
                }
                else if (selectedType == (int)LicenseType.Demo)
                {
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            License.CustomerID = (int)cmbCustomer.SelectedValue;
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

            MessageBox.Show("Lisans kaydı başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
