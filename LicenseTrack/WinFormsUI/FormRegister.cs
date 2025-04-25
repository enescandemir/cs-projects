using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Core.Entities.Concrete;
using Core.Utilities.Hashing;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using Business.Concrete;
using Core.Utilities.JWT;
using Microsoft.Extensions.Configuration;

namespace WinFormsUI
{
    public partial class FormRegister : MaterialForm
    {
        private AuthManager _authManager;
        private Icon eyeIcon = Properties.Resources.eye;
        private Icon hideIcon = Properties.Resources.hide;
        private bool passwordVisible = false;
        private bool _returningToLogin = false;

        public FormRegister()
        {
            InitializeComponent();
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            this.FormClosing += FormRegister_FormClosing;

            var configuration = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\bilal\source\repos\LicenseTrack\WebAPI")
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _authManager = new AuthManager(new UserManager(new EfUserDal()), new JwtHelper(configuration));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registrationResult = _authManager.Register(firstName, lastName, email, password);

            if (registrationResult)
            {
                MessageBox.Show("Kayıt başarılı! Artık giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Kayıt başarısız. Email zaten kayıtlı olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            _returningToLogin = true;
            FormLogin loginForm = new FormLogin();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Close();
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_returningToLogin)
            {
                Application.Exit();
            }
        }

        private void TxtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtPassword.Password = !passwordVisible;
            txtPassword.TrailingIcon = passwordVisible ? hideIcon.ToBitmap() : eyeIcon.ToBitmap();
        }
    }

}
