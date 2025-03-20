namespace WinFormsUI.ProgramLicense
{
    partial class FormProgramLicenseDetails
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
            cmbProgramID = new ComboBox();
            cmbLicenseID = new ComboBox();
            labelProgram = new Label();
            labelLicense = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbProgramID
            // 
            cmbProgramID.FormattingEnabled = true;
            cmbProgramID.Location = new Point(200, 40);
            cmbProgramID.Name = "cmbProgramID";
            cmbProgramID.Size = new Size(151, 28);
            cmbProgramID.TabIndex = 0;
            // 
            // cmbLicenseID
            // 
            cmbLicenseID.FormattingEnabled = true;
            cmbLicenseID.Location = new Point(200, 125);
            cmbLicenseID.Name = "cmbLicenseID";
            cmbLicenseID.Size = new Size(151, 28);
            cmbLicenseID.TabIndex = 1;
            // 
            // labelProgram
            // 
            labelProgram.AutoSize = true;
            labelProgram.Location = new Point(42, 43);
            labelProgram.Name = "labelProgram";
            labelProgram.Size = new Size(66, 20);
            labelProgram.TabIndex = 2;
            labelProgram.Text = "Program";
            // 
            // labelLicense
            // 
            labelLicense.AutoSize = true;
            labelLicense.Location = new Point(42, 125);
            labelLicense.Name = "labelLicense";
            labelLicense.Size = new Size(57, 20);
            labelLicense.TabIndex = 3;
            labelLicense.Text = "License";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(42, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(257, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormProgramLicenseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(labelLicense);
            Controls.Add(labelProgram);
            Controls.Add(cmbLicenseID);
            Controls.Add(cmbProgramID);
            Name = "FormProgramLicenseDetails";
            Text = "FormProgramLicenseDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProgramID;
        private ComboBox cmbLicenseID;
        private Label labelProgram;
        private Label labelLicense;
        private Button btnSave;
        private Button btnCancel;
    }
}