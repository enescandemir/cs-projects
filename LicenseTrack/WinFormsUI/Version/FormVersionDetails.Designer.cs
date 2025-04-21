using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.Version
{
    partial class FormVersionDetails
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
            cmbType = new MaterialComboBox();
            txtName = new MaterialTextBox();
            txtNumber = new MaterialTextBox();
            txtDescription = new MaterialMultiLineTextBox2();
            cmbDependentID = new MaterialComboBox();
            btnCancel = new MaterialButton();
            btnSave = new MaterialButton();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.AutoResize = false;
            cmbType.BackColor = Color.FromArgb(255, 255, 255);
            cmbType.Depth = 0;
            cmbType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbType.DropDownHeight = 174;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.DropDownWidth = 121;
            cmbType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbType.Hint = "Select Type";
            cmbType.IntegralHeight = false;
            cmbType.ItemHeight = 43;
            cmbType.Location = new Point(48, 82);
            cmbType.MaxDropDownItems = 4;
            cmbType.MouseState = MaterialSkin.MouseState.OUT;
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(273, 49);
            cmbType.StartIndex = 0;
            cmbType.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(48, 137);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 50);
            txtName.TabIndex = 9;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // txtNumber
            // 
            txtNumber.AnimateReadOnly = false;
            txtNumber.BorderStyle = BorderStyle.None;
            txtNumber.Depth = 0;
            txtNumber.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumber.Hint = "Number";
            txtNumber.LeadingIcon = null;
            txtNumber.Location = new Point(48, 193);
            txtNumber.MaxLength = 32767;
            txtNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtNumber.Multiline = false;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(273, 50);
            txtNumber.TabIndex = 12;
            txtNumber.Text = "";
            txtNumber.TrailingIcon = null;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackColor = SystemColors.Control;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Description";
            txtDescription.Location = new Point(48, 249);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(273, 111);
            txtDescription.TabIndex = 13;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // cmbDependentID
            // 
            cmbDependentID.AutoResize = false;
            cmbDependentID.BackColor = Color.FromArgb(255, 255, 255);
            cmbDependentID.Depth = 0;
            cmbDependentID.DrawMode = DrawMode.OwnerDrawVariable;
            cmbDependentID.DropDownHeight = 174;
            cmbDependentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDependentID.DropDownWidth = 121;
            cmbDependentID.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbDependentID.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbDependentID.Hint = "Select Dependent ID";
            cmbDependentID.IntegralHeight = false;
            cmbDependentID.ItemHeight = 43;
            cmbDependentID.Location = new Point(48, 366);
            cmbDependentID.MaxDropDownItems = 4;
            cmbDependentID.MouseState = MaterialSkin.MouseState.OUT;
            cmbDependentID.Name = "cmbDependentID";
            cmbDependentID.Size = new Size(273, 49);
            cmbDependentID.StartIndex = 0;
            cmbDependentID.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(228, 424);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(48, 424);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.Type = MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FormVersionDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 479);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cmbDependentID);
            Controls.Add(txtDescription);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Controls.Add(cmbType);
            Name = "FormVersionDetails";
            Text = "Version Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialComboBox cmbType;
        private MaterialTextBox txtName;
        private MaterialTextBox txtNumber;
        private MaterialMultiLineTextBox2 txtDescription;
        private MaterialComboBox cmbDependentID;
        private MaterialButton btnCancel;
        private MaterialButton btnSave;
    }
}
