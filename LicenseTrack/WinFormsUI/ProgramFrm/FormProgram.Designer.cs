using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.ProgramFrm
{
    partial class FormProgram
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
            buttonAdd = new MaterialButton();
            buttonUpdate = new MaterialButton();
            buttonDelete = new MaterialButton();
            dgwProgram = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwProgram).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = null;
            buttonAdd.Location = new Point(12, 84);
            buttonAdd.Margin = new Padding(4, 6, 4, 6);
            buttonAdd.MouseState = MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(64, 36);
            buttonAdd.TabIndex = 3;
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
            buttonUpdate.Icon = null;
            buttonUpdate.Location = new Point(252, 84);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.MouseState = MouseState.HOVER;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.NoAccentTextColor = Color.Empty;
            buttonUpdate.Size = new Size(77, 36);
            buttonUpdate.TabIndex = 4;
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
            buttonDelete.Icon = null;
            buttonDelete.Location = new Point(497, 84);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(73, 36);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Sil";
            buttonDelete.Type = MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dgwProgram
            // 
            dgwProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProgram.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwProgram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(236, 239, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(144, 202, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwProgram.DefaultCellStyle = dataGridViewCellStyle2;
            dgwProgram.EnableHeadersVisualStyles = false;
            dgwProgram.GridColor = Color.FromArgb(176, 190, 197);
            dgwProgram.Location = new Point(12, 129);
            dgwProgram.Name = "dgwProgram";
            dgwProgram.RowHeadersWidth = 51;
            dgwProgram.Size = new Size(558, 309);
            dgwProgram.TabIndex = 6;
            // 
            // FormProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 454);
            Controls.Add(dgwProgram);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormProgram";
            Text = "Program Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgwProgram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            dgwProgram.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 145);

            buttonAdd.Location = new Point(dgwProgram.Location.X, dgwProgram.Location.Y - 50); 
            buttonUpdate.Location = new Point(dgwProgram.Location.X + dgwProgram.Width / 2 - buttonUpdate.Width / 2, dgwProgram.Location.Y - 50); 
            buttonDelete.Location = new Point(dgwProgram.Location.X + dgwProgram.Width - buttonDelete.Width, dgwProgram.Location.Y - 50);
        }


        #endregion

        private MaterialButton buttonAdd;
        private MaterialButton buttonUpdate;
        private MaterialButton buttonDelete;
        private DataGridView dgwProgram;
    }
}
