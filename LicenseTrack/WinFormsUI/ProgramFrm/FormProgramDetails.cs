using Business.Concrete;
using DataAccess.Concrete;
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
using System.Xml.Linq;

namespace WinFormsUI.ProgramFrm
{
    public partial class FormProgramDetails : MaterialForm
    {
        public Entities.Concrete.Program Program { get; set; }
        private ProgramManager programManager = new ProgramManager(new EfProgramDal());
        public FormProgramDetails(Entities.Concrete.Program program = null)
        {
            InitializeComponent();
            if (program != null)
            {
                Program = program;
                txtName.Text = program.Name;
            }
            else
            {
                Program = new Entities.Concrete.Program();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Lütfen program adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.Name = txtName.Text;

            if (Program.ProgramID == 0)
            {
                programManager.Add(Program);
            }
            else
            {
                programManager.Update(Program);
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
