using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsUI.License
{
    partial class FormAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            buttonSetNewPassword = new MaterialButton();
            buttonToggleAdmin = new MaterialButton();
            buttonDeleteUser = new MaterialButton();
            dgwUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwUser).BeginInit();
            SuspendLayout();
            // 
            // buttonSetNewPassword
            // 
            buttonSetNewPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSetNewPassword.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonSetNewPassword.Depth = 0;
            buttonSetNewPassword.HighEmphasis = true;
            buttonSetNewPassword.Icon = null;
            buttonSetNewPassword.Location = new Point(12, 82);
            buttonSetNewPassword.Margin = new Padding(4, 6, 4, 6);
            buttonSetNewPassword.MouseState = MouseState.HOVER;
            buttonSetNewPassword.Name = "buttonSetNewPassword";
            buttonSetNewPassword.NoAccentTextColor = Color.Empty;
            buttonSetNewPassword.Size = new Size(146, 36);
            buttonSetNewPassword.TabIndex = 1;
            buttonSetNewPassword.Text = "Set New Password";
            buttonSetNewPassword.Type = MaterialButton.MaterialButtonType.Contained;
            buttonSetNewPassword.UseAccentColor = false;
            buttonSetNewPassword.Click += buttonSetNewPassword_Click;
            // 
            // buttonToggleAdmin
            // 
            buttonToggleAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonToggleAdmin.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonToggleAdmin.Depth = 0;
            buttonToggleAdmin.HighEmphasis = true;
            buttonToggleAdmin.Icon = null;
            buttonToggleAdmin.Location = new Point(346, 82);
            buttonToggleAdmin.Margin = new Padding(4, 6, 4, 6);
            buttonToggleAdmin.MouseState = MouseState.HOVER;
            buttonToggleAdmin.Name = "buttonToggleAdmin";
            buttonToggleAdmin.NoAccentTextColor = Color.Empty;
            buttonToggleAdmin.Size = new Size(128, 36);
            buttonToggleAdmin.TabIndex = 2;
            buttonToggleAdmin.Text = "Toggle Admin";
            buttonToggleAdmin.Type = MaterialButton.MaterialButtonType.Contained;
            buttonToggleAdmin.UseAccentColor = false;
            buttonToggleAdmin.Click += buttonToggleAdmin_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDeleteUser.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonDeleteUser.Depth = 0;
            buttonDeleteUser.HighEmphasis = true;
            buttonDeleteUser.Icon = null;
            buttonDeleteUser.Location = new Point(698, 82);
            buttonDeleteUser.Margin = new Padding(4, 6, 4, 6);
            buttonDeleteUser.MouseState = MouseState.HOVER;
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.NoAccentTextColor = Color.Empty;
            buttonDeleteUser.Size = new Size(113, 36);
            buttonDeleteUser.TabIndex = 3;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.Type = MaterialButton.MaterialButtonType.Contained;
            buttonDeleteUser.UseAccentColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // dgwUser
            // 
            dgwUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUser.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgwUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgwUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 239, 241);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(144, 202, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgwUser.DefaultCellStyle = dataGridViewCellStyle4;
            dgwUser.EnableHeadersVisualStyles = false;
            dgwUser.GridColor = Color.FromArgb(176, 190, 197);
            dgwUser.Location = new Point(12, 127);
            dgwUser.Name = "dgwUser";
            dgwUser.RowHeadersWidth = 51;
            dgwUser.Size = new Size(799, 311);
            dgwUser.TabIndex = 4;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(dgwUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonToggleAdmin);
            Controls.Add(buttonSetNewPassword);
            Name = "FormAdmin";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)dgwUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialButton buttonSetNewPassword;
        private MaterialButton buttonToggleAdmin;
        private MaterialButton buttonDeleteUser;
        private DataGridView dgwUser;
    }
}
