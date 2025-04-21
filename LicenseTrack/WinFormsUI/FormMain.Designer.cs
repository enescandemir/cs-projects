using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    partial class FormMain
    {
        private MaterialButton buttonCustomer;
        private MaterialButton buttonLicense;

        /// <summary>
        ///  Designer tarafından kullanılan bileşenleri temizler.
        /// </summary>
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
            buttonCustomer = new MaterialButton();
            buttonLicense = new MaterialButton();
            buttonProgram = new MaterialButton();
            buttonProgramLicense = new MaterialButton();
            buttonUpdateTable = new MaterialButton();
            buttonVersion = new MaterialButton();
            labelUserInfo = new MaterialLabel();
            buttonAdmin = new MaterialButton();
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCustomer.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonCustomer.Depth = 0;
            buttonCustomer.HighEmphasis = true;
            buttonCustomer.Icon = null;
            buttonCustomer.Location = new Point(69, 124);
            buttonCustomer.Margin = new Padding(4, 6, 4, 6);
            buttonCustomer.MouseState = MouseState.HOVER;
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.NoAccentTextColor = Color.Empty;
            buttonCustomer.Size = new Size(99, 36);
            buttonCustomer.TabIndex = 0;
            buttonCustomer.Text = "Customer";
            buttonCustomer.Type = MaterialButton.MaterialButtonType.Contained;
            buttonCustomer.UseAccentColor = false;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonLicense
            // 
            buttonLicense.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonLicense.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonLicense.Depth = 0;
            buttonLicense.HighEmphasis = true;
            buttonLicense.Icon = null;
            buttonLicense.Location = new Point(376, 124);
            buttonLicense.Margin = new Padding(4, 6, 4, 6);
            buttonLicense.MouseState = MouseState.HOVER;
            buttonLicense.Name = "buttonLicense";
            buttonLicense.NoAccentTextColor = Color.Empty;
            buttonLicense.Size = new Size(79, 36);
            buttonLicense.TabIndex = 1;
            buttonLicense.Text = "License";
            buttonLicense.Type = MaterialButton.MaterialButtonType.Contained;
            buttonLicense.UseAccentColor = false;
            buttonLicense.Click += buttonLicense_Click;
            // 
            // buttonProgram
            // 
            buttonProgram.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonProgram.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonProgram.Depth = 0;
            buttonProgram.HighEmphasis = true;
            buttonProgram.Icon = null;
            buttonProgram.Location = new Point(69, 193);
            buttonProgram.Margin = new Padding(4, 6, 4, 6);
            buttonProgram.MouseState = MouseState.HOVER;
            buttonProgram.Name = "buttonProgram";
            buttonProgram.NoAccentTextColor = Color.Empty;
            buttonProgram.Size = new Size(92, 36);
            buttonProgram.TabIndex = 2;
            buttonProgram.Text = "Program";
            buttonProgram.Type = MaterialButton.MaterialButtonType.Contained;
            buttonProgram.UseAccentColor = false;
            buttonProgram.UseVisualStyleBackColor = true;
            buttonProgram.Click += buttonProgram_Click;
            // 
            // buttonProgramLicense
            // 
            buttonProgramLicense.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonProgramLicense.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonProgramLicense.Depth = 0;
            buttonProgramLicense.HighEmphasis = true;
            buttonProgramLicense.Icon = null;
            buttonProgramLicense.Location = new Point(336, 193);
            buttonProgramLicense.Margin = new Padding(4, 6, 4, 6);
            buttonProgramLicense.MouseState = MouseState.HOVER;
            buttonProgramLicense.Name = "buttonProgramLicense";
            buttonProgramLicense.NoAccentTextColor = Color.Empty;
            buttonProgramLicense.Size = new Size(154, 36);
            buttonProgramLicense.TabIndex = 3;
            buttonProgramLicense.Text = "Program License";
            buttonProgramLicense.Type = MaterialButton.MaterialButtonType.Contained;
            buttonProgramLicense.UseAccentColor = false;
            buttonProgramLicense.UseVisualStyleBackColor = true;
            buttonProgramLicense.Click += buttonProgramLicense_Click;
            // 
            // buttonUpdateTable
            // 
            buttonUpdateTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUpdateTable.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonUpdateTable.Depth = 0;
            buttonUpdateTable.HighEmphasis = true;
            buttonUpdateTable.Icon = null;
            buttonUpdateTable.Location = new Point(378, 264);
            buttonUpdateTable.Margin = new Padding(4, 6, 4, 6);
            buttonUpdateTable.MouseState = MouseState.HOVER;
            buttonUpdateTable.Name = "buttonUpdateTable";
            buttonUpdateTable.NoAccentTextColor = Color.Empty;
            buttonUpdateTable.Size = new Size(77, 36);
            buttonUpdateTable.TabIndex = 4;
            buttonUpdateTable.Text = "Update";
            buttonUpdateTable.Type = MaterialButton.MaterialButtonType.Contained;
            buttonUpdateTable.UseAccentColor = false;
            buttonUpdateTable.Click += buttonUpdateTable_Click;
            // 
            // buttonVersion
            // 
            buttonVersion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonVersion.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonVersion.Depth = 0;
            buttonVersion.HighEmphasis = true;
            buttonVersion.Icon = null;
            buttonVersion.Location = new Point(69, 264);
            buttonVersion.Margin = new Padding(4, 6, 4, 6);
            buttonVersion.MouseState = MouseState.HOVER;
            buttonVersion.Name = "buttonVersion";
            buttonVersion.NoAccentTextColor = Color.Empty;
            buttonVersion.Size = new Size(82, 36);
            buttonVersion.TabIndex = 5;
            buttonVersion.Text = "Version";
            buttonVersion.Type = MaterialButton.MaterialButtonType.Contained;
            buttonVersion.UseAccentColor = false;
            buttonVersion.Click += buttonVersion_Click;
            // 
            // labelUserInfo
            // 
            labelUserInfo.AutoSize = true;
            labelUserInfo.Depth = 0;
            labelUserInfo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelUserInfo.Location = new Point(362, 75);
            labelUserInfo.MouseState = MouseState.HOVER;
            labelUserInfo.Name = "labelUserInfo";
            labelUserInfo.Size = new Size(109, 19);
            labelUserInfo.TabIndex = 6;
            labelUserInfo.Text = "Kullanıcı Bilgisi";
            // 
            // buttonAdmin
            // 
            buttonAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdmin.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdmin.Depth = 0;
            buttonAdmin.HighEmphasis = true;
            buttonAdmin.Icon = null;
            buttonAdmin.Location = new Point(200, 312);
            buttonAdmin.Margin = new Padding(4, 6, 4, 6);
            buttonAdmin.MouseState = MouseState.HOVER;
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.NoAccentTextColor = Color.Empty;
            buttonAdmin.Size = new Size(118, 36);
            buttonAdmin.TabIndex = 7;
            buttonAdmin.Text = "Admin Panel";
            buttonAdmin.Type = MaterialButton.MaterialButtonType.Contained;
            buttonAdmin.UseAccentColor = false;
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(buttonAdmin);
            Controls.Add(labelUserInfo);
            Controls.Add(buttonVersion);
            Controls.Add(buttonUpdateTable);
            Controls.Add(buttonProgramLicense);
            Controls.Add(buttonProgram);
            Controls.Add(buttonCustomer);
            Controls.Add(buttonLicense);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialButton buttonProgram;
        private MaterialButton buttonProgramLicense;
        private MaterialButton buttonUpdateTable;
        private MaterialButton buttonVersion;
        private MaterialLabel labelUserInfo;
        private MaterialButton buttonAdmin;
    }
}
