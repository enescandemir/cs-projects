namespace WinFormsUI.ProgramLicense
{
    partial class FormProgramLicense
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
            dgwProgramLicense = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwProgramLicense).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(47, 36);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 41);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(236, 36);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 41);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(435, 36);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 41);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dgwProgramLicense
            // 
            dgwProgramLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProgramLicense.Location = new Point(24, 139);
            dgwProgramLicense.Name = "dgwProgramLicense";
            dgwProgramLicense.RowHeadersWidth = 51;
            dgwProgramLicense.Size = new Size(609, 299);
            dgwProgramLicense.TabIndex = 7;
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
            Text = "FormProgramLicense";
            ((System.ComponentModel.ISupportInitialize)dgwProgramLicense).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dgwProgramLicense;
    }
}