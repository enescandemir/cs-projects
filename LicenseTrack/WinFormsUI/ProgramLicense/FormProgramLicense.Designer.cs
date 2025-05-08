using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;
using WinFormsUI.Helpers;

namespace WinFormsUI.ProgramLicense
{
    partial class FormProgramLicense
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
            dgwProgramLicense = new DataGridView();
            buttonAdd = new IconLeftMaterialButton();
            buttonUpdate = new IconLeftMaterialButton();
            buttonDelete = new IconLeftMaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgwProgramLicense).BeginInit();
            SuspendLayout();
            // 
            // dgwProgramLicense
            // 
            dgwProgramLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProgramLicense.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwProgramLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwProgramLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 239, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(144, 202, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwProgramLicense.DefaultCellStyle = dataGridViewCellStyle2;
            dgwProgramLicense.EnableHeadersVisualStyles = false;
            dgwProgramLicense.GridColor = Color.FromArgb(176, 190, 197);
            dgwProgramLicense.Location = new Point(24, 130);
            dgwProgramLicense.Name = "dgwProgramLicense";
            dgwProgramLicense.RowHeadersWidth = 51;
            dgwProgramLicense.Size = new Size(609, 308);
            dgwProgramLicense.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = Properties.Resources.add.ToBitmap();
            buttonAdd.Location = new Point(24, 85);
            buttonAdd.Margin = new Padding(4, 6, 4, 6);
            buttonAdd.MouseState = MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(130, 40);
            buttonAdd.AutoSize = false;
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Ekle";
            buttonAdd.Type = MaterialButton.MaterialButtonType.Contained;
            buttonAdd.UseAccentColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUpdate.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonUpdate.Depth = 0;
            buttonUpdate.HighEmphasis = true;
            buttonUpdate.Icon = Properties.Resources.edit.ToBitmap();
            buttonUpdate.Location = new Point(276, 85);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.MouseState = MouseState.HOVER;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.NoAccentTextColor = Color.Empty;
            buttonUpdate.Size = new Size(130, 40);
            buttonUpdate.AutoSize = false;
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.Type = MaterialButton.MaterialButtonType.Contained;
            buttonUpdate.UseAccentColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = Properties.Resources.delete.ToBitmap();
            buttonDelete.Location = new Point(560, 85);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(130, 40);
            buttonDelete.AutoSize = false;
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Sil";
            buttonDelete.Type = MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormProgramLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(dgwProgramLicense);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormProgramLicense";
            Text = "Program-Lisans Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgwProgramLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            dgwProgramLicense.Size = new Size(ClientSize.Width - 37, ClientSize.Height - 145);
            int spacing = 10;
            int topY = dgwProgramLicense.Location.Y - 50;

            buttonAdd.Location = new Point(dgwProgramLicense.Location.X, topY);
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

        private DataGridView dgwProgramLicense;
        private IconLeftMaterialButton buttonAdd;
        private IconLeftMaterialButton buttonUpdate;
        private IconLeftMaterialButton buttonDelete;
    }
}
