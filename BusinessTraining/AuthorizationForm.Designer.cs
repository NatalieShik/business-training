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
            this.checkBoxIsUserManager = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCompanyBranch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxClosedEye = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenedEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedEye)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(139, 165);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 29);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxSurname.Location = new System.Drawing.Point(139, 216);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(195, 29);
            this.textBoxSurname.TabIndex = 1;
            // 
            // checkBoxIsUserManager
            // 
            this.checkBoxIsUserManager.AutoSize = true;
            this.checkBoxIsUserManager.Font = new System.Drawing.Font("Candara", 11F);
            this.checkBoxIsUserManager.Location = new System.Drawing.Point(139, 281);
            this.checkBoxIsUserManager.Name = "checkBoxIsUserManager";
            this.checkBoxIsUserManager.Size = new System.Drawing.Size(206, 27);
            this.checkBoxIsUserManager.TabIndex = 3;
            this.checkBoxIsUserManager.Text = "Войти как менеджер";
            this.checkBoxIsUserManager.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxPassword.Location = new System.Drawing.Point(139, 314);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(195, 29);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxCompanyBranch
            // 
            this.textBoxCompanyBranch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCompanyBranch.Font = new System.Drawing.Font("Candara", 13.8F);
            this.textBoxCompanyBranch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCompanyBranch.Location = new System.Drawing.Point(12, 108);
            this.textBoxCompanyBranch.Name = "textBoxCompanyBranch";
            this.textBoxCompanyBranch.Size = new System.Drawing.Size(438, 29);
            this.textBoxCompanyBranch.TabIndex = 15;
            this.textBoxCompanyBranch.TabStop = false;
            this.textBoxCompanyBranch.Text = "Филиал";
            this.textBoxCompanyBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCompanyBranch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCompanyBranch_KeyDown);
            this.textBoxCompanyBranch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCompanyBranch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 40);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel2.Location = new System.Drawing.Point(-2, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 40);
            this.panel2.TabIndex = 17;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold);
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(139, 380);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(195, 38);
            this.buttonEnter.TabIndex = 18;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Candara", 11F);
            this.labelName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelName.Location = new System.Drawing.Point(87, 168);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 23);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Имя";
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.labelAuthorization.Location = new System.Drawing.Point(132, 68);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(192, 37);
            this.labelAuthorization.TabIndex = 21;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.Transparent;
            this.labelSurname.Font = new System.Drawing.Font("Candara", 11F);
            this.labelSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelSurname.Location = new System.Drawing.Point(49, 219);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(84, 23);
            this.labelSurname.TabIndex = 22;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Candara", 11F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPassword.Location = new System.Drawing.Point(62, 317);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 23);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Пароль";
            // 
            // pictureBoxClosedEye
            // 
            this.pictureBoxClosedEye.Image = global::BusinessTraining.Properties.Resources.close;
            this.pictureBoxClosedEye.Location = new System.Drawing.Point(356, 317);
            this.pictureBoxClosedEye.Name = "pictureBoxClosedEye";
            this.pictureBoxClosedEye.Size = new System.Drawing.Size(31, 23);
            this.pictureBoxClosedEye.TabIndex = 25;
            this.pictureBoxClosedEye.TabStop = false;
            this.pictureBoxClosedEye.Click += new System.EventHandler(this.pictureBoxClosedEye_Click);
            // 
            // pictureBoxOpenedEye
            // 
            this.pictureBoxOpenedEye.Image = global::BusinessTraining.Properties.Resources.open;
            this.pictureBoxOpenedEye.Location = new System.Drawing.Point(356, 317);
            this.pictureBoxOpenedEye.Name = "pictureBoxOpenedEye";
            this.pictureBoxOpenedEye.Size = new System.Drawing.Size(31, 23);
            this.pictureBoxOpenedEye.TabIndex = 24;
            this.pictureBoxOpenedEye.TabStop = false;
            this.pictureBoxOpenedEye.Click += new System.EventHandler(this.pictureBoxOpenedEye_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 496);
            this.Controls.Add(this.pictureBoxClosedEye);
            this.Controls.Add(this.pictureBoxOpenedEye);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelAuthorization);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxCompanyBranch);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxIsUserManager);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.CheckBox checkBoxIsUserManager;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCompanyBranch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxClosedEye;
        private System.Windows.Forms.PictureBox pictureBoxOpenedEye;
    }
}