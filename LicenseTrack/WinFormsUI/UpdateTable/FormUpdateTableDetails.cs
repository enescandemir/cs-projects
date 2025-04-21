using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsUI.UpdateTable
{
    public partial class FormUpdateTableDetails : MaterialForm
    {
        public Entities.Concrete.UpdateTable Update { get; set; }
        private UpdateTableManager updateManager = new UpdateTableManager(new EfUpdateTableDal());

        public FormUpdateTableDetails(Entities.Concrete.UpdateTable update = null)
        {
            InitializeComponent();
            LoadCustomers();
            LoadVersions();

            Update = new Entities.Concrete.UpdateTable();
            if (update != null)
            {
                Update = update;
                cmbCustomer.SelectedValue = update.CustomerID;
                cmbVersion.SelectedValue = update.VersionID;
                dtpUpdateDate.Value = update.UpdateDate;
                txtDescription.Text = update.Description;
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

        private void LoadVersions()
        {
            var versions = new VersionManager(new EfVersionDal()).GetAll();
            cmbVersion.DataSource = versions;
            cmbVersion.DisplayMember = "Name";
            cmbVersion.ValueMember = "VersionID";
            cmbVersion.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null || cmbVersion.SelectedValue == null)
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Update.CustomerID = (int)cmbCustomer.SelectedValue;
            Update.VersionID = (int)cmbVersion.SelectedValue;
            Update.UpdateDate = dtpUpdateDate.Value;
            Update.Description = txtDescription.Text;

            if (Update.UpdateID == 0)
            {
                updateManager.Add(Update);
            }
            else
            {
                updateManager.Update(Update);
            }

            MessageBox.Show("Güncelleme ekleme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
