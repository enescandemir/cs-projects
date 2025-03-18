using WinFormsUI.License;

namespace WinFormsUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
    }
}
