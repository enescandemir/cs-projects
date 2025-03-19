using MaterialSkin;
using MaterialSkin.Controls;
using WinFormsUI.License;
using WinFormsUI.Program;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();

            // MaterialSkin Temalarýný Ayarla
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
        }

        private void buttonLicense_Click(object sender, EventArgs e)
        {
            FormLicense formLicense = new FormLicense();
            formLicense.Show();
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            WinFormsUI.Program.FormProgram formProgram = new WinFormsUI.Program.FormProgram();
            formProgram.Show();
        }
    }
}
