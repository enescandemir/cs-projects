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
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
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
            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbVersion.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir sürüm seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtpUpdateDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Lütfen geçerli bir güncelleme tarihi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show("Güncelleme başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
