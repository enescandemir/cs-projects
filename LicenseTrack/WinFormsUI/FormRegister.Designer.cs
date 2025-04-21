using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI
{
    partial class FormRegister
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
            txtFirstName = new MaterialTextBox();
            txtLastName = new MaterialTextBox();
            txtEmail = new MaterialTextBox();
            txtPassword = new MaterialTextBox();
            btnRegister = new MaterialButton();
            btnReturn = new MaterialButton();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.AnimateReadOnly = false;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Depth = 0;
            txtFirstName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFirstName.Hint = "Ad";
            txtFirstName.LeadingIcon = null;
            txtFirstName.Location = new Point(260, 95);
            txtFirstName.MaxLength = 32767;
            txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 50);
            txtFirstName.TabIndex = 0;
            txtFirstName.Text = "";
            txtFirstName.TrailingIcon = null;
            // 
            // txtLastName
            // 
            txtLastName.AnimateReadOnly = false;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Depth = 0;
            txtLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastName.Hint = "Soyad";
            txtLastName.LeadingIcon = null;
            txtLastName.Location = new Point(260, 166);
            txtLastName.MaxLength = 32767;
            txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 50);
            txtLastName.TabIndex = 1;
            txtLastName.Text = "";
            txtLastName.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(260, 234);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 50);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtPassword
            // 
            // txtPassword
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Şifre";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(260, 305); 
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(280, 50);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = eyeIcon.ToBitmap();
            txtPassword.TrailingIconClick += TxtPassword_TrailingIconClick;

            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.Location = new Point(260, 386);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(84, 36);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.Type = MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReturn
            // 
            btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReturn.Density = MaterialButton.MaterialButtonDensity.Default;
            btnReturn.Depth = 0;
            btnReturn.HighEmphasis = true;
            btnReturn.Icon = null;
            btnReturn.Location = new Point(456, 386);
            btnReturn.Margin = new Padding(4, 6, 4, 6);
            btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            btnReturn.Name = "btnReturn";
            btnReturn.NoAccentTextColor = Color.Empty;
            btnReturn.Size = new Size(84, 36);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Geri";
            btnReturn.Type = MaterialButton.MaterialButtonType.Contained;
            btnReturn.UseAccentColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "FormRegister";
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialTextBox txtFirstName;
        private MaterialTextBox txtLastName;
        private MaterialTextBox txtEmail;
        private MaterialTextBox txtPassword;
        private MaterialButton btnRegister;
        private MaterialButton btnReturn;
    }
}
