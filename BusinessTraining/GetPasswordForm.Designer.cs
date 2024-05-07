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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonVerifyPassword = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.pictureBoxClosedEye = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenedEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedEye)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxPassword.Location = new System.Drawing.Point(66, 141);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 29);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonVerifyPassword
            // 
            this.buttonVerifyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonVerifyPassword.FlatAppearance.BorderSize = 0;
            this.buttonVerifyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerifyPassword.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonVerifyPassword.ForeColor = System.Drawing.Color.White;
            this.buttonVerifyPassword.Location = new System.Drawing.Point(83, 207);
            this.buttonVerifyPassword.Name = "buttonVerifyPassword";
            this.buttonVerifyPassword.Size = new System.Drawing.Size(203, 41);
            this.buttonVerifyPassword.TabIndex = 3;
            this.buttonVerifyPassword.Text = "Подтвердить пароль";
            this.buttonVerifyPassword.UseVisualStyleBackColor = false;
            this.buttonVerifyPassword.Click += new System.EventHandler(this.ButtonVerifyPassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 40);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 40);
            this.panel1.TabIndex = 8;
            // 
            // labelEnterPassword
            // 
            this.labelEnterPassword.AutoSize = true;
            this.labelEnterPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterPassword.Font = new System.Drawing.Font("Candara", 12F);
            this.labelEnterPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelEnterPassword.Location = new System.Drawing.Point(108, 97);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(148, 24);
            this.labelEnterPassword.TabIndex = 9;
            this.labelEnterPassword.Text = "Введите пароль";
            // 
            // pictureBoxClosedEye
            // 
            this.pictureBoxClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClosedEye.Image")));
            this.pictureBoxClosedEye.Location = new System.Drawing.Point(292, 143);
            this.pictureBoxClosedEye.Name = "pictureBoxClosedEye";
            this.pictureBoxClosedEye.Size = new System.Drawing.Size(31, 23);
            this.pictureBoxClosedEye.TabIndex = 11;
            this.pictureBoxClosedEye.TabStop = false;
            this.pictureBoxClosedEye.Click += new System.EventHandler(this.PictureBoxClosedEye_Click);
            // 
            // pictureBoxOpenedEye
            // 
            this.pictureBoxOpenedEye.Image = global::BusinessTraining.Properties.Resources.open;
            this.pictureBoxOpenedEye.Location = new System.Drawing.Point(292, 143);
            this.pictureBoxOpenedEye.Name = "pictureBoxOpenedEye";
            this.pictureBoxOpenedEye.Size = new System.Drawing.Size(31, 23);
            this.pictureBoxOpenedEye.TabIndex = 10;
            this.pictureBoxOpenedEye.TabStop = false;
            this.pictureBoxOpenedEye.Click += new System.EventHandler(this.PictureBoxOpenedEye_Click);
            // 
            // GetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 330);
            this.Controls.Add(this.pictureBoxClosedEye);
            this.Controls.Add(this.pictureBoxOpenedEye);
            this.Controls.Add(this.labelEnterPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonVerifyPassword);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonVerifyPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEnterPassword;
        private System.Windows.Forms.PictureBox pictureBoxOpenedEye;
        private System.Windows.Forms.PictureBox pictureBoxClosedEye;
    }
}