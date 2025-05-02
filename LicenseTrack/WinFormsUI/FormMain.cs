using Core.Utilities.Session;
using MaterialSkin;
using MaterialSkin.Controls;
using WinFormsUI.Customer;
using WinFormsUI.License;
using WinFormsUI.ProgramFrm;
using WinFormsUI.ProgramLicense;
using WinFormsUI.UpdateTable;
using WinFormsUI.Version;
using System.Runtime.InteropServices;
using WinFormsUI.Helpers;

namespace WinFormsUI
{

    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            this.FormClosing += (s, e) => Application.Exit();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey100,
                Primary.BlueGrey200,
                Primary.BlueGrey300,
                Accent.LightBlue400,
                TextShade.BLACK
            );



            this.Load += FormMain_Load;



            SetAdminButtonVisibility();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyRoundedCorners(buttonCustomer, 20);
            UIHelper.ApplyRoundedCorners(buttonLicense, 20);
            UIHelper.ApplyRoundedCorners(buttonProgram, 20);
            UIHelper.ApplyRoundedCorners(buttonProgramLicense, 20);
            UIHelper.ApplyRoundedCorners(buttonVersion, 20);
            UIHelper.ApplyRoundedCorners(buttonUpdateTable, 20);
            UIHelper.ApplyRoundedCorners(buttonAdmin, 20);
        }

        private void SetAdminButtonVisibility()
        {
            buttonAdmin.Visible = Session.UserRole == "Admin";
        }

        private void OpenForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;       
            form.FormBorderStyle = FormBorderStyle.None;       
            form.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCustomer());
        }

        private void buttonLicense_Click(object sender, EventArgs e)
        {
            OpenForm(new FormLicense());
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProgram());
        }

        private void buttonProgramLicense_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProgramLicense());
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            OpenForm(new FormUpdateTable());
        }

        private void buttonVersion_Click(object sender, EventArgs e)
        {
            OpenForm(new FormVersion());
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAdmin());
        }



    }
}
