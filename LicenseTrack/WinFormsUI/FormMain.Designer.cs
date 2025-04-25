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
            buttonCustomer.Location = new Point(57, 124);
            buttonCustomer.Margin = new Padding(4, 6, 4, 6);
            buttonCustomer.MouseState = MouseState.HOVER;
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.NoAccentTextColor = Color.Empty;
            buttonCustomer.AutoSize = false;
            buttonCustomer.Size = new Size(120, 120);
            buttonCustomer.TabIndex = 0;
            buttonCustomer.Text = "Müşteri";
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
            buttonLicense.Location = new Point(475, 124);
            buttonLicense.Margin = new Padding(4, 6, 4, 6);
            buttonLicense.MouseState = MouseState.HOVER;
            buttonLicense.Name = "buttonLicense";
            buttonLicense.NoAccentTextColor = Color.Empty;
            buttonLicense.AutoSize = false;
            buttonLicense.Size = new Size(120, 120);
            buttonLicense.TabIndex = 1;
            buttonLicense.Text = "Lisans";
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
            buttonProgram.Location = new Point(57, 193);
            buttonProgram.Margin = new Padding(4, 6, 4, 6);
            buttonProgram.MouseState = MouseState.HOVER;
            buttonProgram.Name = "buttonProgram";
            buttonProgram.NoAccentTextColor = Color.Empty;
            buttonProgram.AutoSize = false;
            buttonProgram.Size = new Size(120, 120);
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
            buttonProgramLicense.Location = new Point(400, 193);
            buttonProgramLicense.Margin = new Padding(4, 6, 4, 6);
            buttonProgramLicense.MouseState = MouseState.HOVER;
            buttonProgramLicense.Name = "buttonProgramLicense";
            buttonProgramLicense.NoAccentTextColor = Color.Empty;
            buttonProgramLicense.AutoSize = false;
            buttonProgramLicense.Size = new Size(120, 120);
            buttonProgramLicense.TabIndex = 3;
            buttonProgramLicense.Text = "Program-Lisans";
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
            buttonUpdateTable.Location = new Point(475, 264);
            buttonUpdateTable.Margin = new Padding(4, 6, 4, 6);
            buttonUpdateTable.MouseState = MouseState.HOVER;
            buttonUpdateTable.Name = "buttonUpdateTable";
            buttonUpdateTable.NoAccentTextColor = Color.Empty;
            buttonUpdateTable.AutoSize = false;
            buttonUpdateTable.Size = new Size(120, 120);
            buttonUpdateTable.TabIndex = 4;
            buttonUpdateTable.Text = "Güncellemeler";
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
            buttonVersion.Location = new Point(57, 264);
            buttonVersion.Margin = new Padding(4, 6, 4, 6);
            buttonVersion.MouseState = MouseState.HOVER;
            buttonVersion.Name = "buttonVersion";
            buttonVersion.NoAccentTextColor = Color.Empty;
            buttonVersion.AutoSize = false;
            buttonVersion.Size = new Size(120,120);
            buttonVersion.TabIndex = 5;
            buttonVersion.Text = "Versiyon";
            buttonVersion.Type = MaterialButton.MaterialButtonType.Contained;
            buttonVersion.UseAccentColor = false;
            buttonVersion.Click += buttonVersion_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdmin.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdmin.Depth = 0;
            buttonAdmin.HighEmphasis = true;
            buttonAdmin.Icon = null;
            buttonAdmin.Location = new Point(237, 328);
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
            Controls.Add(buttonVersion);
            Controls.Add(buttonUpdateTable);
            Controls.Add(buttonProgramLicense);
            Controls.Add(buttonProgram);
            Controls.Add(buttonCustomer);
            Controls.Add(buttonLicense);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            int buttonSize = Math.Min(formWidth / 8, 150);

            int spacing = (formWidth - (buttonSize * 6)) / 7; 

            int topMargin = formHeight / 4;

            MaterialButton[] buttons = {
        buttonCustomer, buttonLicense, buttonProgram,
        buttonProgramLicense, buttonVersion, buttonUpdateTable
    };

            for (int i = 0; i < buttons.Length; i++)
            {
                var btn = buttons[i];
                btn.Size = new Size(buttonSize, buttonSize);
                int x = spacing + i * (buttonSize + spacing);
                btn.Location = new Point(x, topMargin);
            }

            int adminX = (formWidth - buttonAdmin.Width) / 2;
            int adminY = topMargin + buttonSize + 60; 
            buttonAdmin.Location = new Point(adminX, adminY);
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
