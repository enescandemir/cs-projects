namespace WinFormsUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCustomer = new Button();
            buttonLicense = new Button();
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.Location = new Point(42, 35);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(94, 29);
            buttonCustomer.TabIndex = 0;
            buttonCustomer.Text = "Customer";
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonLicense
            // 
            buttonLicense.Location = new Point(42, 82);
            buttonLicense.Name = "buttonLicense";
            buttonLicense.Size = new Size(94, 29);
            buttonLicense.TabIndex = 1;
            buttonLicense.Text = "License";
            buttonLicense.UseVisualStyleBackColor = true;
            buttonLicense.Click += buttonLicense_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(686, 359);
            Controls.Add(buttonLicense);
            Controls.Add(buttonCustomer);
            Name = "FormMain";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCustomer;
        private Button buttonLicense;
    }
}
