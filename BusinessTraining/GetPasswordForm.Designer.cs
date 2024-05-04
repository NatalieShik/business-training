namespace BusinessTraining
{
    partial class GetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPasswordForm));
            this.buttonVerifyPassword = new System.Windows.Forms.Button();
            this.labelForInfo = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonVerifyPassword
            // 
            this.buttonVerifyPassword.Location = new System.Drawing.Point(139, 179);
            this.buttonVerifyPassword.Name = "buttonVerifyPassword";
            this.buttonVerifyPassword.Size = new System.Drawing.Size(128, 37);
            this.buttonVerifyPassword.TabIndex = 0;
            this.buttonVerifyPassword.Text = "ПОДТВЕРДИТЬ ";
            this.buttonVerifyPassword.UseVisualStyleBackColor = true;
            this.buttonVerifyPassword.Click += new System.EventHandler(this.buttonVerifyPassword_Click);
            // 
            // labelForInfo
            // 
            this.labelForInfo.AutoSize = true;
            this.labelForInfo.Location = new System.Drawing.Point(93, 61);
            this.labelForInfo.Name = "labelForInfo";
            this.labelForInfo.Size = new System.Drawing.Size(208, 16);
            this.labelForInfo.TabIndex = 1;
            this.labelForInfo.Text = "ВВЕДИ ПАРОЛЬ И Я ОТСТАНУ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(125, 104);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // GetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelForInfo);
            this.Controls.Add(this.buttonVerifyPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ВВЕДИ ПАРОЛЬ, УБЛЮДОК";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerifyPassword;
        private System.Windows.Forms.Label labelForInfo;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}