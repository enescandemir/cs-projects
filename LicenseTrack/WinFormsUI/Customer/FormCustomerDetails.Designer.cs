using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.Customer
{
    partial class FormCustomerDetails
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
            txtDBName = new MaterialTextBox();
            txtAddress = new MaterialTextBox();
            txtPort = new MaterialTextBox();
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
            txtName.Hint = "Müşteri Adı";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(46, 85);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 50);
            txtName.TabIndex = 1;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // txtDBName
            // 
            txtDBName.AnimateReadOnly = false;
            txtDBName.BorderStyle = BorderStyle.None;
            txtDBName.Depth = 0;
            txtDBName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDBName.Hint = "Müşteri Veritabanı Adı";
            txtDBName.LeadingIcon = null;
            txtDBName.Location = new Point(46, 141);
            txtDBName.MaxLength = 50;
            txtDBName.MouseState = MaterialSkin.MouseState.OUT;
            txtDBName.Multiline = false;
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(300, 50);
            txtDBName.TabIndex = 2;
            txtDBName.Text = "";
            txtDBName.TrailingIcon = null;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.Hint = "Müşteri Adresi";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(46, 197);
            txtAddress.MaxLength = 100;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 50);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            // 
            // txtPort
            // 
            txtPort.AnimateReadOnly = false;
            txtPort.BorderStyle = BorderStyle.None;
            txtPort.Depth = 0;
            txtPort.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPort.Hint = "Müşteri Portu";
            txtPort.LeadingIcon = null;
            txtPort.Location = new Point(46, 253);
            txtPort.MaxLength = 10;
            txtPort.MouseState = MaterialSkin.MouseState.OUT;
            txtPort.Multiline = false;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(300, 50);
            txtPort.TabIndex = 4;
            txtPort.Text = "";
            txtPort.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(46, 337);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 5;
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
            btnCancel.Location = new Point(269, 337);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormCustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            Controls.Add(txtName);
            Controls.Add(txtDBName);
            Controls.Add(txtAddress);
            Controls.Add(txtPort);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormCustomerDetails";
            Text = "Müşteri Detayları";
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int formWidth = ClientSize.Width;
            int formHeight = ClientSize.Height;

            txtName.Location = new Point(46, 85);
            txtName.Size = new Size(formWidth - 92, txtName.Height); 

            txtDBName.Location = new Point(46, txtName.Bottom + 10);
            txtDBName.Size = new Size(formWidth - 92, txtDBName.Height);

            txtAddress.Location = new Point(46, txtDBName.Bottom + 10);
            txtAddress.Size = new Size(formWidth - 92, txtAddress.Height);

            txtPort.Location = new Point(46, txtAddress.Bottom + 10);
            txtPort.Size = new Size(formWidth - 92, txtPort.Height);

            btnSave.Location = new Point(46, txtPort.Bottom + 20);
            btnCancel.Location = new Point(formWidth - btnCancel.Width - 46, txtPort.Bottom + 20);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnResize(EventArgs.Empty); // Form yüklendiğinde kontrolleri yeniden düzenle
        }

        #endregion

        private MaterialTextBox txtName;
        private MaterialTextBox txtDBName;
        private MaterialTextBox txtAddress;
        private MaterialTextBox txtPort;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;
    }
}
