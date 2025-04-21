using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.UpdateTable
{
    partial class FormUpdateTableDetails
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
            cmbCustomer = new MaterialComboBox();
            cmbVersion = new MaterialComboBox();
            btnSave = new MaterialButton();
            btnCancel = new MaterialButton();
            dtpUpdateDate = new DateTimePicker();
            txtDescription = new MaterialMultiLineTextBox2();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.AutoResize = false;
            cmbCustomer.BackColor = Color.FromArgb(255, 255, 255);
            cmbCustomer.Depth = 0;
            cmbCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCustomer.DropDownHeight = 174;
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.DropDownWidth = 121;
            cmbCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCustomer.Hint = "Select Customer";
            cmbCustomer.IntegralHeight = false;
            cmbCustomer.ItemHeight = 43;
            cmbCustomer.Location = new Point(36, 79);
            cmbCustomer.MaxDropDownItems = 4;
            cmbCustomer.MouseState = MaterialSkin.MouseState.OUT;
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(284, 49);
            cmbCustomer.StartIndex = 0;
            cmbCustomer.TabIndex = 6;
            // 
            // cmbVersion
            // 
            cmbVersion.AutoResize = false;
            cmbVersion.BackColor = Color.FromArgb(255, 255, 255);
            cmbVersion.Depth = 0;
            cmbVersion.DrawMode = DrawMode.OwnerDrawVariable;
            cmbVersion.DropDownHeight = 174;
            cmbVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVersion.DropDownWidth = 121;
            cmbVersion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbVersion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbVersion.Hint = "Select Version";
            cmbVersion.IntegralHeight = false;
            cmbVersion.ItemHeight = 43;
            cmbVersion.Location = new Point(36, 134);
            cmbVersion.MaxDropDownItems = 4;
            cmbVersion.MouseState = MaterialSkin.MouseState.OUT;
            cmbVersion.Name = "cmbVersion";
            cmbVersion.Size = new Size(284, 49);
            cmbVersion.StartIndex = 0;
            cmbVersion.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(36, 376);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
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
            btnCancel.Location = new Point(243, 376);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpUpdateDate
            // 
            dtpUpdateDate.Format = DateTimePickerFormat.Short;
            dtpUpdateDate.Location = new Point(36, 189);
            dtpUpdateDate.Name = "dtpUpdateDate";
            dtpUpdateDate.Size = new Size(284, 27);
            dtpUpdateDate.TabIndex = 14;
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
            txtDescription.Hint = "Enter Description";
            txtDescription.Location = new Point(36, 222);
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
            txtDescription.Size = new Size(284, 132);
            txtDescription.TabIndex = 17;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // FormUpdateTableDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 440);
            Controls.Add(txtDescription);
            Controls.Add(dtpUpdateDate);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cmbVersion);
            Controls.Add(cmbCustomer);
            Name = "FormUpdateTableDetails";
            Text = "Update Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialComboBox cmbCustomer;
        private MaterialComboBox cmbVersion;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;
        private DateTimePicker dtpUpdateDate;
        private MaterialMultiLineTextBox2 txtDescription;
    }
}
