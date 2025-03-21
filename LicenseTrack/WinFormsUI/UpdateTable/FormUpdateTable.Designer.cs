namespace WinFormsUI.UpdateTable
{
    partial class FormUpdateTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dgwUpdateTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwUpdateTable).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(52, 57);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 41);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(262, 57);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 41);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(472, 57);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 41);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dgwUpdateTable
            // 
            dgwUpdateTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUpdateTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUpdateTable.Location = new Point(28, 139);
            dgwUpdateTable.Name = "dgwUpdateTable";
            dgwUpdateTable.RowHeadersWidth = 51;
            dgwUpdateTable.Size = new Size(634, 299);
            dgwUpdateTable.TabIndex = 8;
            // 
            // FormUpdateTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(dgwUpdateTable);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormUpdateTable";
            Text = "FormUpdateTable";
            ((System.ComponentModel.ISupportInitialize)dgwUpdateTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dgwUpdateTable;
    }
}