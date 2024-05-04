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
            this.buttonBuildConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(54, 26);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 16);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(57, 54);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxCompanyBranch
            // 
            this.textBoxCompanyBranch.Location = new System.Drawing.Point(57, 123);
            this.textBoxCompanyBranch.Name = "textBoxCompanyBranch";
            this.textBoxCompanyBranch.Size = new System.Drawing.Size(164, 22);
            this.textBoxCompanyBranch.TabIndex = 3;
            // 
            // labelCompanyBranch
            // 
            this.labelCompanyBranch.AutoSize = true;
            this.labelCompanyBranch.Location = new System.Drawing.Point(54, 95);
            this.labelCompanyBranch.Name = "labelCompanyBranch";
            this.labelCompanyBranch.Size = new System.Drawing.Size(109, 16);
            this.labelCompanyBranch.TabIndex = 2;
            this.labelCompanyBranch.Text = "Адрес филиала";
            // 
            // textBoxBotToken
            // 
            this.textBoxBotToken.Location = new System.Drawing.Point(57, 189);
            this.textBoxBotToken.Name = "textBoxBotToken";
            this.textBoxBotToken.Size = new System.Drawing.Size(200, 22);
            this.textBoxBotToken.TabIndex = 5;
            // 
            // labelBotToken
            // 
            this.labelBotToken.AutoSize = true;
            this.labelBotToken.Location = new System.Drawing.Point(54, 161);
            this.labelBotToken.Name = "labelBotToken";
            this.labelBotToken.Size = new System.Drawing.Size(146, 16);
            this.labelBotToken.TabIndex = 4;
            this.labelBotToken.Text = "Токен телеграм бота";
            // 
            // textBoxChatId
            // 
            this.textBoxChatId.Location = new System.Drawing.Point(57, 256);
            this.textBoxChatId.Name = "textBoxChatId";
            this.textBoxChatId.Size = new System.Drawing.Size(100, 22);
            this.textBoxChatId.TabIndex = 7;
            // 
            // labelChatId
            // 
            this.labelChatId.AutoSize = true;
            this.labelChatId.Location = new System.Drawing.Point(54, 228);
            this.labelChatId.Name = "labelChatId";
            this.labelChatId.Size = new System.Drawing.Size(54, 16);
            this.labelChatId.TabIndex = 6;
            this.labelChatId.Text = "ID чата";
            // 
            // buttonBuildConfig
            // 
            this.buttonBuildConfig.Location = new System.Drawing.Point(57, 308);
            this.buttonBuildConfig.Name = "buttonBuildConfig";
            this.buttonBuildConfig.Size = new System.Drawing.Size(125, 42);
            this.buttonBuildConfig.TabIndex = 8;
            this.buttonBuildConfig.Text = "Сохранить настройки";
            this.buttonBuildConfig.UseVisualStyleBackColor = true;
            this.buttonBuildConfig.Click += new System.EventHandler(this.buttonBuildConfig_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 421);
            this.Controls.Add(this.buttonBuildConfig);
            this.Controls.Add(this.textBoxChatId);
            this.Controls.Add(this.labelChatId);
            this.Controls.Add(this.textBoxBotToken);
            this.Controls.Add(this.labelBotToken);
            this.Controls.Add(this.textBoxCompanyBranch);
            this.Controls.Add(this.labelCompanyBranch);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка конфигурации";
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
        private System.Windows.Forms.Button buttonBuildConfig;
    }
}

