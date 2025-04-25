using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtEmail = new MaterialTextBox();
            txtPassword = new MaterialTextBox();
            btnLogin = new MaterialButton();
            btnRegister = new MaterialButton();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(184, 124);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 50);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Şifre";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(184, 193);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 50);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            txtPassword.TrailingIconClick += TxtPassword_TrailingIconClick;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(197, 273);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(89, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.Type = MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.Location = new Point(362, 273);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(84, 36);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.Type = MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "FormLogin";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int formCenterY = ClientSize.Height / 2;
            int startingY = formCenterY - 100;

            txtEmail.Location = new Point((ClientSize.Width - txtEmail.Width) / 2, startingY + 30);
            txtPassword.Location = new Point((ClientSize.Width - txtPassword.Width) / 2, startingY + 100);

            btnLogin.Location = new Point((ClientSize.Width - (btnLogin.Width + btnRegister.Width + 20)) / 2, startingY + 180); 
            btnRegister.Location = new Point(btnLogin.Location.X + btnLogin.Width + 20, startingY + 180);
        }

        #endregion

        private MaterialTextBox txtEmail;
        private MaterialTextBox txtPassword;
        private MaterialButton btnLogin;
        private MaterialButton btnRegister;
    }
}
