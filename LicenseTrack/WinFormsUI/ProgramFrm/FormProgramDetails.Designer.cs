using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.ProgramFrm
{
    partial class FormProgramDetails
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
            txtName = new MaterialTextBox();
            btnSave = new MaterialButton();
            btnCancel = new MaterialButton();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Program Adı";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(29, 77);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 50);
            txtName.TabIndex = 1;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(29, 146);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 2;
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
            btnCancel.Location = new Point(252, 146);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "İptal";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormProgramDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 198);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormProgramDetails";
            Text = "Program Detayları";
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            txtName.Location = new Point(29, 77);
            txtName.Size = new Size(formWidth - 58, txtName.Height); 

            btnSave.Location = new Point(29, txtName.Bottom + 20); 
            btnCancel.Location = new Point(formWidth - btnCancel.Width - 29, txtName.Bottom + 20); 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnResize(EventArgs.Empty); 
        }

        #endregion

        private MaterialTextBox txtName;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;
    }
}
