using MaterialSkin;
using MaterialSkin.Controls;
using WinFormsUI.Helpers;

namespace WinFormsUI.Customer
{
    partial class FormCustomer
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
            dgwCustomers = new DataGridView();
            buttonAdd = new IconLeftMaterialButton();
            buttonDelete = new IconLeftMaterialButton();
            buttonUpdate = new IconLeftMaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgwCustomers
            // 
            dgwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCustomers.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(55, 71, 79);
            dataGridViewCellStyle3.Font = new Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgwCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(236, 239, 241);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(144, 202, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgwCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            dgwCustomers.EnableHeadersVisualStyles = false;
            dgwCustomers.GridColor = Color.FromArgb(176, 190, 197);
            dgwCustomers.Location = new Point(12, 125);
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.RowHeadersWidth = 51;
            dgwCustomers.Size = new Size(686, 313);
            dgwCustomers.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = Properties.Resources.add.ToBitmap();
            buttonAdd.Location = new Point(12, 80);
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
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = Properties.Resources.delete.ToBitmap();
            buttonDelete.Location = new Point(625, 80);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(130, 40);
            buttonDelete.AutoSize = false;
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Sil";
            buttonDelete.Type = MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUpdate.Density = MaterialButton.MaterialButtonDensity.Default;
            buttonUpdate.Depth = 0;
            buttonUpdate.HighEmphasis = true;
            buttonUpdate.Icon = Properties.Resources.edit.ToBitmap();
            buttonUpdate.Location = new Point(296, 80);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.MouseState = MouseState.HOVER;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.NoAccentTextColor = Color.Empty;
            buttonUpdate.Size = new Size(130,40);
            buttonUpdate.AutoSize = false;
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.Type = MaterialButton.MaterialButtonType.Contained;
            buttonUpdate.UseAccentColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // FormCustomer
            //
            ClientSize = new Size(707, 447);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dgwCustomers);
            Name = "FormCustomer";
            Text = "Müşteri Yönetimi";
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            dgwCustomers.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 145);
            int spacing = 10;
            int topY = dgwCustomers.Location.Y - 50;

            buttonAdd.Location = new Point(dgwCustomers.Location.X, topY);
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

        private System.Windows.Forms.DataGridView dgwCustomers;
        private IconLeftMaterialButton buttonAdd;
        private IconLeftMaterialButton buttonDelete;
        private IconLeftMaterialButton buttonUpdate;
    }
}