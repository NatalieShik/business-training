namespace BusinessTraining.Configuration
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCompanyBranch = new System.Windows.Forms.TextBox();
            this.labelCompanyBranch = new System.Windows.Forms.Label();
            this.textBoxBotToken = new System.Windows.Forms.TextBox();
            this.labelBotToken = new System.Windows.Forms.Label();
            this.textBoxChatId = new System.Windows.Forms.TextBox();
            this.labelChatId = new System.Windows.Forms.Label();
            this.textBoxVerifyPassword = new System.Windows.Forms.TextBox();
            this.labelVerifyPassword = new System.Windows.Forms.Label();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBuildConfig = new System.Windows.Forms.Button();
            this.pictureBoxClosedEye = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpenedEye = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Candara", 11F);
            this.labelPassword.Location = new System.Drawing.Point(52, 102);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 23);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxPassword.Location = new System.Drawing.Point(55, 128);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(240, 29);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // textBoxCompanyBranch
            // 
            this.textBoxCompanyBranch.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxCompanyBranch.Location = new System.Drawing.Point(55, 271);
            this.textBoxCompanyBranch.Name = "textBoxCompanyBranch";
            this.textBoxCompanyBranch.Size = new System.Drawing.Size(240, 29);
            this.textBoxCompanyBranch.TabIndex = 3;
            this.textBoxCompanyBranch.TabStop = false;
            // 
            // labelCompanyBranch
            // 
            this.labelCompanyBranch.AutoSize = true;
            this.labelCompanyBranch.Font = new System.Drawing.Font("Candara", 11F);
            this.labelCompanyBranch.Location = new System.Drawing.Point(52, 245);
            this.labelCompanyBranch.Name = "labelCompanyBranch";
            this.labelCompanyBranch.Size = new System.Drawing.Size(136, 23);
            this.labelCompanyBranch.TabIndex = 2;
            this.labelCompanyBranch.Text = "Адрес филиала";
            // 
            // textBoxBotToken
            // 
            this.textBoxBotToken.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxBotToken.Location = new System.Drawing.Point(55, 420);
            this.textBoxBotToken.Name = "textBoxBotToken";
            this.textBoxBotToken.Size = new System.Drawing.Size(509, 29);
            this.textBoxBotToken.TabIndex = 5;
            this.textBoxBotToken.TabStop = false;
            // 
            // labelBotToken
            // 
            this.labelBotToken.AutoSize = true;
            this.labelBotToken.Font = new System.Drawing.Font("Candara", 11F);
            this.labelBotToken.Location = new System.Drawing.Point(52, 394);
            this.labelBotToken.Name = "labelBotToken";
            this.labelBotToken.Size = new System.Drawing.Size(184, 23);
            this.labelBotToken.TabIndex = 4;
            this.labelBotToken.Text = "Токен телеграм бота";
            // 
            // textBoxChatId
            // 
            this.textBoxChatId.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxChatId.Location = new System.Drawing.Point(55, 345);
            this.textBoxChatId.Name = "textBoxChatId";
            this.textBoxChatId.Size = new System.Drawing.Size(240, 29);
            this.textBoxChatId.TabIndex = 7;
            this.textBoxChatId.TabStop = false;
            // 
            // labelChatId
            // 
            this.labelChatId.AutoSize = true;
            this.labelChatId.Font = new System.Drawing.Font("Candara", 11F);
            this.labelChatId.Location = new System.Drawing.Point(52, 319);
            this.labelChatId.Name = "labelChatId";
            this.labelChatId.Size = new System.Drawing.Size(66, 23);
            this.labelChatId.TabIndex = 6;
            this.labelChatId.Text = "ID чата";
            // 
            // textBoxVerifyPassword
            // 
            this.textBoxVerifyPassword.Font = new System.Drawing.Font("Candara", 10.8F);
            this.textBoxVerifyPassword.Location = new System.Drawing.Point(55, 198);
            this.textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            this.textBoxVerifyPassword.Size = new System.Drawing.Size(240, 29);
            this.textBoxVerifyPassword.TabIndex = 10;
            this.textBoxVerifyPassword.TabStop = false;
            // 
            // labelVerifyPassword
            // 
            this.labelVerifyPassword.AutoSize = true;
            this.labelVerifyPassword.Font = new System.Drawing.Font("Candara", 11F);
            this.labelVerifyPassword.Location = new System.Drawing.Point(52, 172);
            this.labelVerifyPassword.Name = "labelVerifyPassword";
            this.labelVerifyPassword.Size = new System.Drawing.Size(184, 23);
            this.labelVerifyPassword.TabIndex = 9;
            this.labelVerifyPassword.Text = "Подтвердите пароль";
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.AutoSize = true;
            this.labelConfiguration.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.labelConfiguration.Location = new System.Drawing.Point(173, 58);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(280, 28);
            this.labelConfiguration.TabIndex = 12;
            this.labelConfiguration.Text = "Конфигурация не выбрана";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.buttonChoose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 44);
            this.panel1.TabIndex = 17;
            // 
            // buttonChoose
            // 
            this.buttonChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.buttonChoose.FlatAppearance.BorderSize = 0;
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChoose.ForeColor = System.Drawing.Color.White;
            this.buttonChoose.Location = new System.Drawing.Point(0, 0);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(255, 44);
            this.buttonChoose.TabIndex = 30;
            this.buttonChoose.Text = "Выбрать конфигурацию";
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel2.Location = new System.Drawing.Point(0, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 40);
            this.panel2.TabIndex = 18;
            // 
            // buttonBuildConfig
            // 
            this.buttonBuildConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonBuildConfig.FlatAppearance.BorderSize = 0;
            this.buttonBuildConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuildConfig.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuildConfig.ForeColor = System.Drawing.Color.White;
            this.buttonBuildConfig.Location = new System.Drawing.Point(191, 477);
            this.buttonBuildConfig.Name = "buttonBuildConfig";
            this.buttonBuildConfig.Size = new System.Drawing.Size(240, 50);
            this.buttonBuildConfig.TabIndex = 19;
            this.buttonBuildConfig.Text = "Сохранить настройки";
            this.buttonBuildConfig.UseVisualStyleBackColor = false;
            this.buttonBuildConfig.Click += new System.EventHandler(this.ButtonBuildConfig_Click);
            // 
            // pictureBoxClosedEye
            // 
            this.pictureBoxClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClosedEye.Image")));
            this.pictureBoxClosedEye.Location = new System.Drawing.Point(315, 131);
            this.pictureBoxClosedEye.Name = "pictureBoxClosedEye";
            this.pictureBoxClosedEye.Size = new System.Drawing.Size(31, 23);
            this.pictureBoxClosedEye.TabIndex = 27;
            this.pictureBoxClosedEye.TabStop = false;
            this.pictureBoxClosedEye.Click += new System.EventHandler(this.PictureBoxClosedEye_Click);
            // 
            // pictureBoxOpenedEye
            // 
            this.pictureBoxOpenedEye.Image = global::BusinessTraining.Configuration.Properties.Resources.open;
            this.pictureBoxOpenedEye.Location = new System.Drawing.Point(315, 131);
            this.pictureBoxOpenedEye.Name = "pictureBoxOpenedEye";
            this.pictureBoxOpenedEye.Size = new System.Drawing.Size(31, 23);
            this.pictureBoxOpenedEye.TabIndex = 26;
            this.pictureBoxOpenedEye.TabStop = false;
            this.pictureBoxOpenedEye.Click += new System.EventHandler(this.PictureBoxOpenedEye_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(335, 172);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 202);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 592);
            this.Controls.Add(this.pictureBoxClosedEye);
            this.Controls.Add(this.pictureBoxOpenedEye);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonBuildConfig);
            this.Controls.Add(this.labelConfiguration);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxVerifyPassword);
            this.Controls.Add(this.labelVerifyPassword);
            this.Controls.Add(this.textBoxChatId);
            this.Controls.Add(this.labelChatId);
            this.Controls.Add(this.textBoxBotToken);
            this.Controls.Add(this.labelBotToken);
            this.Controls.Add(this.textBoxCompanyBranch);
            this.Controls.Add(this.labelCompanyBranch);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка конфигурации";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCompanyBranch;
        private System.Windows.Forms.Label labelCompanyBranch;
        private System.Windows.Forms.TextBox textBoxBotToken;
        private System.Windows.Forms.Label labelBotToken;
        private System.Windows.Forms.TextBox textBoxChatId;
        private System.Windows.Forms.Label labelChatId;
        private System.Windows.Forms.TextBox textBoxVerifyPassword;
        private System.Windows.Forms.Label labelVerifyPassword;
        private System.Windows.Forms.Label labelConfiguration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonBuildConfig;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBoxClosedEye;
        private System.Windows.Forms.PictureBox pictureBoxOpenedEye;
    }
}

