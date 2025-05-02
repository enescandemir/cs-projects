using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using FluentValidation;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsUI.ProgramFrm
{
    public partial class FormProgramDetails : MaterialForm
    {
        public Entities.Concrete.Program Program { get; set; }
        private ProgramManager programManager = new ProgramManager(new EfProgramDal());

        public FormProgramDetails(Entities.Concrete.Program program = null)
        {
            InitializeComponent();
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );

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
            Program.Name = txtName.Text;

            try
            {
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
