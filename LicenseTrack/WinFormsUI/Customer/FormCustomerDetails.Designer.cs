namespace WinFormsUI.Customer
{
    partial class FormCustomerDetails
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
            components = new System.ComponentModel.Container();
            labelName = new Label();
            labelDBName = new Label();
            labelAddress = new Label();
            labelPort = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtName = new TextBox();
            txtDBName = new TextBox();
            txtAddress = new TextBox();
            txtPort = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(46, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // labelDBName
            // 
            labelDBName.AutoSize = true;
            labelDBName.Location = new Point(46, 83);
            labelDBName.Name = "labelDBName";
            labelDBName.Size = new Size(116, 20);
            labelDBName.TabIndex = 1;
            labelDBName.Text = "Database Name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(46, 136);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 20);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "Address";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(46, 187);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(35, 20);
            labelPort.TabIndex = 3;
            labelPort.Text = "Port";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtName
            // 
            txtName.Location = new Point(198, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // txtDBName
            // 
            txtDBName.Location = new Point(198, 83);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(125, 27);
            txtDBName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(198, 136);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(198, 187);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(46, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(229, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPort);
            Controls.Add(txtAddress);
            Controls.Add(txtDBName);
            Controls.Add(txtName);
            Controls.Add(labelPort);
            Controls.Add(labelAddress);
            Controls.Add(labelDBName);
            Controls.Add(labelName);
            Name = "FormCustomerDetails";
            Text = "FormCustomerDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDBName;
        private Label labelAddress;
        private Label labelPort;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtName;
        private TextBox txtDBName;
        private TextBox txtAddress;
        private TextBox txtPort;
        private Button btnSave;
        private Button btnCancel;


    }
}