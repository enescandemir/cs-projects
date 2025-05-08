using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;
using WinFormsUI.Helpers;

namespace WinFormsUI.UpdateTable
{
    partial class FormUpdateTable
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgwUpdateTable = new DataGridView();
            buttonAdd = new IconLeftMaterialButton();
            buttonUpdate = new IconLeftMaterialButton();
            buttonDelete = new IconLeftMaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgwUpdateTable).BeginInit();
            SuspendLayout();
            // 
            // dgwUpdateTable
            // 
            dgwUpdateTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUpdateTable.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgwUpdateTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgwUpdateTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 239, 241);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(144, 202, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgwUpdateTable.DefaultCellStyle = dataGridViewCellStyle4;
            dgwUpdateTable.EnableHeadersVisualStyles = false;
            dgwUpdateTable.GridColor = Color.FromArgb(176, 190, 197);
            dgwUpdateTable.Location = new Point(17, 130);
            dgwUpdateTable.Name = "dgwUpdateTable";
            dgwUpdateTable.RowHeadersWidth = 51;
            dgwUpdateTable.Size = new Size(634, 308);
            dgwUpdateTable.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = Properties.Resources.add.ToBitmap();
            buttonAdd.Location = new Point(17, 85);
            buttonAdd.Margin = new Padding(4, 6, 4, 6);
            buttonAdd.MouseState = MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(130, 40);
            buttonAdd.AutoSize = false;
            buttonAdd.TabIndex = 5;
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
            buttonUpdate.Location = new Point(280, 85);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.MouseState = MouseState.HOVER;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.NoAccentTextColor = Color.Empty;
            buttonUpdate.Size = new Size(130, 40);
            buttonUpdate.AutoSize = false;
            buttonUpdate.TabIndex = 6;
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
            buttonDelete.Location = new Point(578, 85);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(130, 40);
            buttonDelete.AutoSize = false;
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Sil";
            buttonDelete.Type = MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormUpdateTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 449);
            Controls.Add(dgwUpdateTable);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormUpdateTable";
            Text = "Güncelleme Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgwUpdateTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            dgwUpdateTable.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 145);
            int spacing = 10;
            int topY = dgwUpdateTable.Location.Y - 50;

            buttonAdd.Location = new Point(dgwUpdateTable.Location.X, topY);
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

        private DataGridView dgwUpdateTable;
        private IconLeftMaterialButton buttonAdd;
        private IconLeftMaterialButton buttonUpdate;
        private IconLeftMaterialButton buttonDelete;
    }
}
