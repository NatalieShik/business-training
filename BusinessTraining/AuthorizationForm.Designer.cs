namespace BusinessTraining
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.checkBoxIsUserManager = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelCompanyBranch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(99, 112);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(195, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(143, 244);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(103, 37);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // checkBoxIsUserManager
            // 
            this.checkBoxIsUserManager.AutoSize = true;
            this.checkBoxIsUserManager.Location = new System.Drawing.Point(99, 190);
            this.checkBoxIsUserManager.Name = "checkBoxIsUserManager";
            this.checkBoxIsUserManager.Size = new System.Drawing.Size(163, 20);
            this.checkBoxIsUserManager.TabIndex = 3;
            this.checkBoxIsUserManager.Text = "Войти как менеджер";
            this.checkBoxIsUserManager.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(99, 216);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(195, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelCompanyBranch
            // 
            this.labelCompanyBranch.AutoSize = true;
            this.labelCompanyBranch.Location = new System.Drawing.Point(122, 9);
            this.labelCompanyBranch.Name = "labelCompanyBranch";
            this.labelCompanyBranch.Size = new System.Drawing.Size(58, 16);
            this.labelCompanyBranch.TabIndex = 5;
            this.labelCompanyBranch.Text = "Филиал";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 331);
            this.Controls.Add(this.labelCompanyBranch);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxIsUserManager);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.CheckBox checkBoxIsUserManager;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelCompanyBranch;
    }
}