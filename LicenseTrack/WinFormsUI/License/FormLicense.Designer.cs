using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;
using WinFormsUI.Helpers;

namespace WinFormsUI.License
{
    partial class FormLicense
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonAdd = new IconLeftMaterialButton();
            buttonUpdate = new IconLeftMaterialButton();
            buttonDelete = new IconLeftMaterialButton();
            dgwLicense = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwLicense).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = Properties.Resources.add.ToBitmap();
            buttonAdd.Location = new Point(12, 82);
            buttonAdd.Margin = new Padding(4, 6, 4, 6);
            buttonAdd.MouseState = MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(130, 40);
            buttonAdd.AutoSize = false;
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Ekle";
            buttonAdd.Type = MaterialButton.MaterialButtonType.Contained;
            buttonAdd.UseAccentColor = false;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUpdate.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonUpdate.Depth = 0;
            buttonUpdate.HighEmphasis = true;
            buttonUpdate.Icon = Properties.Resources.edit.ToBitmap();
            buttonUpdate.Location = new Point(346, 82);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.MouseState = MouseState.HOVER;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.NoAccentTextColor = Color.Empty;
            buttonUpdate.Size = new Size(130, 40);
            buttonUpdate.AutoSize = false;
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.Type = MaterialButton.MaterialButtonType.Contained;
            buttonUpdate.UseAccentColor = false;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = Properties.Resources.delete.ToBitmap();
            buttonDelete.Location = new Point(738, 82);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(130, 40);
            buttonDelete.AutoSize = false;
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Sil";
            buttonDelete.Type = MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dgwLicense
            // 
            dgwLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwLicense.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 239, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(144, 202, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwLicense.DefaultCellStyle = dataGridViewCellStyle2;
            dgwLicense.EnableHeadersVisualStyles = false;
            dgwLicense.GridColor = Color.FromArgb(176, 190, 197);
            dgwLicense.Location = new Point(12, 127);
            dgwLicense.Name = "dgwLicense";
            dgwLicense.RowHeadersWidth = 51;
            dgwLicense.Size = new Size(799, 311);
            dgwLicense.TabIndex = 5;
            // 
            // FormLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(dgwLicense);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormLicense";
            Text = "Lisans Detayları";
            ((System.ComponentModel.ISupportInitialize)dgwLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            dgwLicense.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 145);
            int spacing = 10;
            int topY = dgwLicense.Location.Y - 50;

            buttonAdd.Location = new Point(dgwLicense.Location.X, topY);
            buttonUpdate.Location = new Point(buttonAdd.Right + spacing, topY);
            buttonDelete.Location = new Point(buttonUpdate.Right + spacing, topY);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MaterialButton[] buttons = { buttonAdd, buttonUpdate, buttonDelete };
            foreach (var btn in buttons)
            {
                UIHelper.ApplyRoundedCorners(btn, 10);
            }

        }


        #endregion

        private IconLeftMaterialButton buttonAdd;
        private IconLeftMaterialButton buttonUpdate;
        private IconLeftMaterialButton buttonDelete;
        private DataGridView dgwLicense;
    }
}