namespace WinFormsUI.License
{
    partial class FormLicenseDetails
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
            labelCustomerID = new Label();
            labelType = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            labelDescription = new Label();
            cmbCustomerID = new ComboBox();
            cmbType = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(47, 41);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(87, 20);
            labelCustomerID.TabIndex = 0;
            labelCustomerID.Text = "CustomerID";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(47, 90);
            labelType.Name = "labelType";
            labelType.Size = new Size(40, 20);
            labelType.TabIndex = 1;
            labelType.Text = "Type";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(47, 144);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(72, 20);
            labelStartDate.TabIndex = 2;
            labelStartDate.Text = "StartDate";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(47, 198);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(70, 20);
            labelEndDate.TabIndex = 3;
            labelEndDate.Text = "End Date";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(47, 253);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description";
            // 
            // cmbCustomerID
            // 
            cmbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerID.FormattingEnabled = true;
            cmbCustomerID.Location = new Point(181, 38);
            cmbCustomerID.Name = "cmbCustomerID";
            cmbCustomerID.Size = new Size(151, 28);
            cmbCustomerID.TabIndex = 5;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(181, 90);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 28);
            cmbType.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(181, 144);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(181, 198);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(181, 253);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 174);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(47, 451);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(270, 451);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormLicenseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 505);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cmbType);
            Controls.Add(cmbCustomerID);
            Controls.Add(labelDescription);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelType);
            Controls.Add(labelCustomerID);
            Name = "FormLicenseDetails";
            Text = "FormLicenseDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomerID;
        private Label labelType;
        private Label labelStartDate;
        private Label labelEndDate;
        private Label labelDescription;
        private ComboBox cmbCustomerID;
        private ComboBox cmbType;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private RichTextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}