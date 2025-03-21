namespace WinFormsUI.Version
{
    partial class FormVersionDetails
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
            cmbType = new ComboBox();
            labelType = new Label();
            txtName = new TextBox();
            labelName = new Label();
            labelNumber = new Label();
            txtNumber = new TextBox();
            txtDescription = new RichTextBox();
            labelDescription = new Label();
            cmbDependentID = new ComboBox();
            labelDependentID = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(193, 59);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 28);
            cmbType.TabIndex = 7;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(34, 62);
            labelType.Name = "labelType";
            labelType.Size = new Size(40, 20);
            labelType.TabIndex = 8;
            labelType.Text = "Type";
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(34, 123);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 10;
            labelName.Text = "Name";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(34, 181);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(63, 20);
            labelNumber.TabIndex = 11;
            labelNumber.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(193, 181);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(193, 231);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(504, 63);
            txtDescription.TabIndex = 13;
            txtDescription.Text = "";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(34, 234);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 14;
            labelDescription.Text = "Description";
            // 
            // cmbDependentID
            // 
            cmbDependentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDependentID.FormattingEnabled = true;
            cmbDependentID.Location = new Point(193, 318);
            cmbDependentID.Name = "cmbDependentID";
            cmbDependentID.Size = new Size(151, 28);
            cmbDependentID.TabIndex = 15;
            // 
            // labelDependentID
            // 
            labelDependentID.AutoSize = true;
            labelDependentID.Location = new Point(21, 321);
            labelDependentID.Name = "labelDependentID";
            labelDependentID.Size = new Size(98, 20);
            labelDependentID.TabIndex = 16;
            labelDependentID.Text = "DependentID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(224, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(48, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormVersionDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(labelDependentID);
            Controls.Add(cmbDependentID);
            Controls.Add(labelDescription);
            Controls.Add(txtDescription);
            Controls.Add(txtNumber);
            Controls.Add(labelNumber);
            Controls.Add(labelName);
            Controls.Add(txtName);
            Controls.Add(labelType);
            Controls.Add(cmbType);
            Name = "FormVersionDetails";
            Text = "FormVersionDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType;
        private Label labelType;
        private TextBox txtName;
        private Label labelName;
        private Label labelNumber;
        private TextBox txtNumber;
        private RichTextBox txtDescription;
        private Label labelDescription;
        private ComboBox cmbDependentID;
        private Label labelDependentID;
        private Button btnCancel;
        private Button btnSave;
    }
}