namespace WinFormsUI.UpdateTable
{
    partial class FormUpdateTableDetails
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
            cmbCustomer = new ComboBox();
            labelCustomer = new Label();
            cmbVersion = new ComboBox();
            btnSave = new Button();
            dtpUpdateDate = new DateTimePicker();
            labelVersion = new Label();
            labelUpdateDate = new Label();
            txtDescription = new RichTextBox();
            labelDescription = new Label();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(158, 45);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(151, 28);
            cmbCustomer.TabIndex = 6;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(33, 48);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(72, 20);
            labelCustomer.TabIndex = 7;
            labelCustomer.Text = "Customer";
            // 
            // cmbVersion
            // 
            cmbVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVersion.FormattingEnabled = true;
            cmbVersion.Location = new Point(158, 120);
            cmbVersion.Name = "cmbVersion";
            cmbVersion.Size = new Size(151, 28);
            cmbVersion.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(33, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpUpdateDate
            // 
            dtpUpdateDate.Location = new Point(158, 178);
            dtpUpdateDate.Name = "dtpUpdateDate";
            dtpUpdateDate.Size = new Size(250, 27);
            dtpUpdateDate.TabIndex = 13;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(33, 120);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(57, 20);
            labelVersion.TabIndex = 14;
            labelVersion.Text = "Version";
            // 
            // labelUpdateDate
            // 
            labelUpdateDate.AutoSize = true;
            labelUpdateDate.Location = new Point(24, 178);
            labelUpdateDate.Name = "labelUpdateDate";
            labelUpdateDate.Size = new Size(94, 20);
            labelUpdateDate.TabIndex = 15;
            labelUpdateDate.Text = "Update Date";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(158, 218);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(376, 132);
            txtDescription.TabIndex = 16;
            txtDescription.Text = "";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(33, 232);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 17;
            labelDescription.Text = "Description";
            // 
            // FormUpdateTableDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDescription);
            Controls.Add(txtDescription);
            Controls.Add(labelUpdateDate);
            Controls.Add(labelVersion);
            Controls.Add(dtpUpdateDate);
            Controls.Add(btnSave);
            Controls.Add(cmbVersion);
            Controls.Add(labelCustomer);
            Controls.Add(cmbCustomer);
            Name = "FormUpdateTableDetails";
            Text = "FormUpdateTableDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private Label labelCustomer;
        private ComboBox cmbVersion;
        private Button btnSave;
        private DateTimePicker dtpUpdateDate;
        private Label labelVersion;
        private Label labelUpdateDate;
        private RichTextBox txtDescription;
        private Label labelDescription;
    }
}