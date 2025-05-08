using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.JWT;
using Core.Utilities.Session; 
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        private AuthManager _authManager;
        private UserManager _userManager;
        private Icon eyeIcon = Properties.Resources.eye; 
        private Icon hideIcon = Properties.Resources.hide;
        private bool passwordVisible = false;


        public FormLogin()
        {
            InitializeComponent();
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            txtPassword.Password = true;
            txtPassword.TrailingIcon = eyeIcon.ToBitmap(); 
            var configuration = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\bilal\source\repos\LicenseTrack\WebAPI")
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _userManager = new UserManager(new EfUserDal());
            _authManager = new AuthManager(_userManager, new JwtHelper(configuration));
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen email ve şifre giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userExists = _userManager.GetByMail(email);
            if (userExists == null)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı. Lütfen geçerli bir email giriniz.",
                                "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loginResult = _authManager.Login(email, password);

            if (loginResult != null)
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(loginResult.Token);
                var claims = jwtToken.Claims;

                Session.JwtToken = loginResult.Token;
                Session.UserRole = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                Session.UserName = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
                Session.UserId = Convert.ToInt32(claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);

                MessageBox.Show($"Hoş geldiniz, {Session.UserName}!\nRolünüz: {Session.UserRole}");

                FormMain formMain = new FormMain();
                formMain.FormClosed += (s, args) =>
                {
                    if (!Program.isLoggingOut)
                        Environment.Exit(0);
                };
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Email veya şifre hatalı olabilir.",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Password = !txtPassword.Password;
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.Show();
            this.Hide();
        }
        private void TxtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtPassword.Password = !passwordVisible;
            txtPassword.TrailingIcon = passwordVisible ? hideIcon.ToBitmap() : eyeIcon.ToBitmap();
        }
    }
}
