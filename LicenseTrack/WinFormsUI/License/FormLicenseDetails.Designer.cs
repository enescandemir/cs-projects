using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.License
{
    partial class FormLicenseDetails
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
            cmbType = new MaterialComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtDescription = new MaterialMultiLineTextBox2();
            btnSave = new MaterialButton();
            btnCancel = new MaterialButton();
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
            cmbCustomer.Hint = "Müşteri Seçin";
            cmbCustomer.IntegralHeight = false;
            cmbCustomer.ItemHeight = 43;
            cmbCustomer.Location = new Point(46, 82);
            cmbCustomer.MaxDropDownItems = 4;
            cmbCustomer.MouseState = MaterialSkin.MouseState.OUT;
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(300, 49);
            cmbCustomer.StartIndex = 0;
            cmbCustomer.TabIndex = 1;
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
            cmbType.Hint = "Lisans Tipi Seçin";
            cmbType.IntegralHeight = false;
            cmbType.ItemHeight = 43;
            cmbType.Location = new Point(46, 137);
            cmbType.MaxDropDownItems = 4;
            cmbType.MouseState = MaterialSkin.MouseState.OUT;
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(300, 49);
            cmbType.StartIndex = 0;
            cmbType.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(46, 192);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(46, 225);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 27);
            dtpEndDate.TabIndex = 4;
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
            txtDescription.Hint = "Açıklama";
            txtDescription.Location = new Point(46, 258);
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
            txtDescription.Size = new Size(300, 123);
            txtDescription.TabIndex = 5;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(46, 390);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 6;
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
            btnCancel.Location = new Point(269, 390);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "İptal";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormLicenseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(cmbCustomer);
            Controls.Add(cmbType);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(txtDescription);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormLicenseDetails";
            Text = "Lisans Detayları";
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            cmbCustomer.Location = new Point(46, 82);
            cmbCustomer.Size = new Size(formWidth - 92, cmbCustomer.Height);

            cmbType.Location = new Point(46, cmbCustomer.Bottom + 10);
            cmbType.Size = new Size(formWidth - 92, cmbType.Height);

            dtpStartDate.Location = new Point(46, cmbType.Bottom + 10);
            dtpStartDate.Size = new Size(formWidth - 92, dtpStartDate.Height);

            dtpEndDate.Location = new Point(46, dtpStartDate.Bottom + 10);
            dtpEndDate.Size = new Size(formWidth - 92, dtpEndDate.Height);

            txtDescription.Location = new Point(46, dtpEndDate.Bottom + 10);
            txtDescription.Size = new Size(formWidth - 92, formHeight - txtDescription.Top - 70);

            btnSave.Location = new Point(46, txtDescription.Bottom + 10); 
            btnCancel.Location = new Point(formWidth - btnCancel.Width - 46, txtDescription.Bottom + 10);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnResize(EventArgs.Empty);
        }

        #endregion

        private MaterialComboBox cmbCustomer;
        private MaterialComboBox cmbType;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private MaterialMultiLineTextBox2 txtDescription;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;
    }
}
