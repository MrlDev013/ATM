namespace ATM_Forms
{
    partial class Form3
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
            this.lbl_HelloAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_HelloAccount
            // 
            this.lbl_HelloAccount.AutoSize = true;
            this.lbl_HelloAccount.Location = new System.Drawing.Point(21, 25);
            this.lbl_HelloAccount.Name = "lbl_HelloAccount";
            this.lbl_HelloAccount.Size = new System.Drawing.Size(10, 15);
            this.lbl_HelloAccount.TabIndex = 0;
            this.lbl_HelloAccount.Text = ".";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 444);
            this.Controls.Add(this.lbl_HelloAccount);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_HelloAccount;
    }
}