namespace WinFormsUI.Version
{
    partial class FormVersion
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
            dgwVersion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwVersion).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(39, 44);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 41);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(282, 44);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 41);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(597, 44);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 41);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dgwVersion
            // 
            dgwVersion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwVersion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwVersion.Location = new Point(12, 126);
            dgwVersion.Name = "dgwVersion";
            dgwVersion.RowHeadersWidth = 51;
            dgwVersion.Size = new Size(776, 299);
            dgwVersion.TabIndex = 6;
            // 
            // FormVersion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwVersion);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormVersion";
            Text = "FormVersion";
            ((System.ComponentModel.ISupportInitialize)dgwVersion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dgwVersion;
    }
}