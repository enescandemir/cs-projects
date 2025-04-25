using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.ProgramLicense
{
    partial class FormProgramLicenseDetails
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
            cmbProgramID = new MaterialComboBox();
            cmbLicenseID = new MaterialComboBox();
            btnSave = new MaterialButton();
            btnCancel = new MaterialButton();
            SuspendLayout();
            // 
            // cmbProgramID
            // 
            cmbProgramID.AutoResize = false;
            cmbProgramID.BackColor = Color.FromArgb(255, 255, 255);
            cmbProgramID.Depth = 0;
            cmbProgramID.DrawMode = DrawMode.OwnerDrawVariable;
            cmbProgramID.DropDownHeight = 174;
            cmbProgramID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgramID.DropDownWidth = 121;
            cmbProgramID.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbProgramID.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbProgramID.Hint = "Program Seçin";
            cmbProgramID.IntegralHeight = false;
            cmbProgramID.ItemHeight = 43;
            cmbProgramID.Location = new Point(28, 82);
            cmbProgramID.MaxDropDownItems = 4;
            cmbProgramID.MouseState = MaterialSkin.MouseState.OUT;
            cmbProgramID.Name = "cmbProgramID";
            cmbProgramID.Size = new Size(257, 49);
            cmbProgramID.StartIndex = 0;
            cmbProgramID.TabIndex = 0;
            // 
            // cmbLicenseID
            // 
            cmbLicenseID.AutoResize = false;
            cmbLicenseID.BackColor = Color.FromArgb(255, 255, 255);
            cmbLicenseID.Depth = 0;
            cmbLicenseID.DrawMode = DrawMode.OwnerDrawVariable;
            cmbLicenseID.DropDownHeight = 174;
            cmbLicenseID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicenseID.DropDownWidth = 121;
            cmbLicenseID.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbLicenseID.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbLicenseID.Hint = "Lisans Seçin";
            cmbLicenseID.IntegralHeight = false;
            cmbLicenseID.ItemHeight = 43;
            cmbLicenseID.Location = new Point(28, 147);
            cmbLicenseID.MaxDropDownItems = 4;
            cmbLicenseID.MouseState = MaterialSkin.MouseState.OUT;
            cmbLicenseID.Name = "cmbLicenseID";
            cmbLicenseID.Size = new Size(257, 49);
            cmbLicenseID.StartIndex = 0;
            cmbLicenseID.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(28, 225);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.Type = MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(208, 225);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "İptal";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormProgramLicenseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 286);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbLicenseID);
            Controls.Add(cmbProgramID);
            Name = "FormProgramLicenseDetails";
            Text = "Program-Lisans Detayları";
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            cmbProgramID.Location = new Point(28, 82);
            cmbProgramID.Size = new Size(formWidth - 56, cmbProgramID.Height); 

            cmbLicenseID.Location = new Point(28, cmbProgramID.Bottom + 10);
            cmbLicenseID.Size = new Size(formWidth - 56, cmbLicenseID.Height);

            btnSave.Location = new Point(28, cmbLicenseID.Bottom + 20); 
            btnCancel.Location = new Point(formWidth - btnCancel.Width - 28, cmbLicenseID.Bottom + 20);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnResize(EventArgs.Empty);
        }


        #endregion

        private MaterialComboBox cmbProgramID;
        private MaterialComboBox cmbLicenseID;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;
    }
}
