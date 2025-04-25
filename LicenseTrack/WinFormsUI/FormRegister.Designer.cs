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
            txtFirstName.Size = new Size(280, 50);
            txtFirstName.TabIndex = 0;
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
            txtLastName.Size = new Size(280, 50);
            txtLastName.TabIndex = 1;
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
            txtEmail.Size = new Size(280, 50);
            txtEmail.TabIndex = 2;
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
            txtPassword.Password = true;
            txtPassword.Size = new Size(280, 50);
            txtPassword.TabIndex = 3;
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
            btnRegister.Size = new Size(84, 36);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReturn
            // 
            btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReturn.Density = MaterialButton.MaterialButtonDensity.Default;
            btnReturn.Depth = 0;
            btnReturn.HighEmphasis = true;
            btnReturn.Icon = null;
            btnReturn.Size = new Size(84, 36);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Geri";
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
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int formCenterY = ClientSize.Height / 2;
            int startingY = formCenterY - 140; 

            txtFirstName.Location = new Point((ClientSize.Width - txtFirstName.Width) / 2, startingY);
            txtLastName.Location = new Point((ClientSize.Width - txtLastName.Width) / 2, txtFirstName.Location.Y + 70);
            txtEmail.Location = new Point((ClientSize.Width - txtEmail.Width) / 2, txtLastName.Location.Y + 70);
            txtPassword.Location = new Point((ClientSize.Width - txtPassword.Width) / 2, txtEmail.Location.Y + 70);

            btnRegister.Location = new Point((ClientSize.Width - (btnRegister.Width + btnReturn.Width + 20)) / 2, txtPassword.Location.Y + 80);
            btnReturn.Location = new Point(btnRegister.Location.X + btnRegister.Width + 20, btnRegister.Location.Y);
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
