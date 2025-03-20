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
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCustomer.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonCustomer.Depth = 0;
            buttonCustomer.HighEmphasis = true;
            buttonCustomer.Icon = null;
            buttonCustomer.Location = new Point(50, 111);
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
            buttonLicense.Location = new Point(50, 203);
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
            buttonProgram.Location = new Point(50, 296);
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
            buttonProgramLicense.Location = new Point(362, 111);
            buttonProgramLicense.Margin = new Padding(4, 6, 4, 6);
            buttonProgramLicense.MouseState = MouseState.HOVER;
            buttonProgramLicense.Name = "buttonProgramLicense";
            buttonProgramLicense.NoAccentTextColor = Color.Empty;
            buttonProgramLicense.Size = new Size(150, 36);
            buttonProgramLicense.TabIndex = 3;
            buttonProgramLicense.Text = "Program License";
            buttonProgramLicense.Type = MaterialButton.MaterialButtonType.Contained;
            buttonProgramLicense.UseAccentColor = false;
            buttonProgramLicense.UseVisualStyleBackColor = true;
            buttonProgramLicense.Click += buttonProgramLicense_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(600, 400);
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
    }
}
