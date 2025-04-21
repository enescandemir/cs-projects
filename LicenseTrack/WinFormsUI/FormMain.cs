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
            labelUserInfo.Text = $"Hoþ geldiniz, {Session.UserName}!\nRolünüz: {Session.UserRole}";

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
