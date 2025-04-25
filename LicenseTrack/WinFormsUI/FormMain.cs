using Core.Utilities.Session;
using MaterialSkin;
using MaterialSkin.Controls;
using WinFormsUI.Customer;
using WinFormsUI.License;
using WinFormsUI.ProgramFrm;
using WinFormsUI.ProgramLicense;
using WinFormsUI.UpdateTable;
using WinFormsUI.Version;

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
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);

            SetAdminButtonVisibility();
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
