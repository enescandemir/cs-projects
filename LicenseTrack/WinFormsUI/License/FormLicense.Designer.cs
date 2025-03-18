namespace WinFormsUI.License
{
    partial class FormLicense
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
            dgwLicense = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwLicense).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(34, 63);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 41);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(197, 63);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 41);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(356, 63);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 41);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dgwLicense
            // 
            dgwLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLicense.Location = new Point(24, 139);
            dgwLicense.Name = "dgwLicense";
            dgwLicense.RowHeadersWidth = 51;
            dgwLicense.Size = new Size(754, 299);
            dgwLicense.TabIndex = 5;
            // 
            // FormLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwLicense);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Name = "FormLicense";
            Text = "FormLicense";
            ((System.ComponentModel.ISupportInitialize)dgwLicense).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dgwLicense;
    }
}