using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.ProgramLicense
{
    public partial class FormProgramLicenseDetails : MaterialForm
    {
        public Entities.Concrete.ProgramLicense ProgramLicense { get; set; }
        private ProgramLicenseManager programLicenseManager = new ProgramLicenseManager(new EfProgramLicenseDal());
        public FormProgramLicenseDetails(Entities.Concrete.ProgramLicense programLicense = null)
        {
            InitializeComponent();
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            LoadPrograms();
            LoadLicenses();
            if (programLicense != null)
            {
                ProgramLicense = programLicense;
                cmbProgramID.SelectedValue = programLicense.ProgramID;
                cmbLicenseID.SelectedValue = programLicense.LicenseID;

            }
            else
            {
                ProgramLicense = new Entities.Concrete.ProgramLicense();
            }
        } 
        private void LoadPrograms()
        {
            var programs = new ProgramManager(new EfProgramDal()).GetAll();
            cmbProgramID.DataSource = programs;
            cmbProgramID.DisplayMember = "Name";
            cmbProgramID.ValueMember = "ProgramID";
            cmbProgramID.SelectedIndex = -1;
        }

        private void LoadLicenses()
        {
            var licenses = new Business.Concrete.LicenseManager(new EfLicenseDal()).GetAll();
            cmbLicenseID.DataSource = licenses;
            cmbLicenseID.DisplayMember = "Name";
            cmbLicenseID.ValueMember = "LicenseID";
            cmbLicenseID.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbProgramID.SelectedItem == null || cmbLicenseID.SelectedItem == null)
            {
                MessageBox.Show("Lütfen boş seçim yapmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProgramLicense.ProgramID = (int)cmbProgramID.SelectedValue;
            ProgramLicense.LicenseID = (int)cmbLicenseID.SelectedValue;
            if (ProgramLicense.ProgramLicenseID == 0)
            {
                programLicenseManager.Add(ProgramLicense);
            }
            else
            {
                programLicenseManager.Update(ProgramLicense);
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
