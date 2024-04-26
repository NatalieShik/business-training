namespace BusinessTraining
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonOpenTest = new System.Windows.Forms.Button();
            this.buttonOpenPrepearing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHowToUse = new System.Windows.Forms.Label();
            this.labelTableInfo = new System.Windows.Forms.Label();
            this.labelPrepearingInfo = new System.Windows.Forms.Label();
            this.labelTestInfo = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labellabelPrepearingInfo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonChooseFile.FlatAppearance.BorderSize = 0;
            this.buttonChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseFile.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseFile.ForeColor = System.Drawing.Color.White;
            this.buttonChooseFile.Location = new System.Drawing.Point(86, 479);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(213, 50);
            this.buttonChooseFile.TabIndex = 1;
            this.buttonChooseFile.Text = "Загрузить курс";
            this.buttonChooseFile.UseVisualStyleBackColor = false;
            this.buttonChooseFile.Click += new System.EventHandler(this.ButtonChooseFile_Click);
            // 
            // buttonOpenTest
            // 
            this.buttonOpenTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonOpenTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenTest.FlatAppearance.BorderSize = 0;
            this.buttonOpenTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenTest.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTest.ForeColor = System.Drawing.Color.White;
            this.buttonOpenTest.Location = new System.Drawing.Point(551, 479);
            this.buttonOpenTest.Name = "buttonOpenTest";
            this.buttonOpenTest.Size = new System.Drawing.Size(348, 50);
            this.buttonOpenTest.TabIndex = 2;
            this.buttonOpenTest.Text = "Экзаменационное тестирование";
            this.buttonOpenTest.UseVisualStyleBackColor = false;
            this.buttonOpenTest.Click += new System.EventHandler(this.ButtonOpenTest_Click);
            // 
            // buttonOpenPrepearing
            // 
            this.buttonOpenPrepearing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonOpenPrepearing.FlatAppearance.BorderSize = 0;
            this.buttonOpenPrepearing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPrepearing.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPrepearing.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPrepearing.Location = new System.Drawing.Point(305, 479);
            this.buttonOpenPrepearing.Name = "buttonOpenPrepearing";
            this.buttonOpenPrepearing.Size = new System.Drawing.Size(240, 50);
            this.buttonOpenPrepearing.TabIndex = 3;
            this.buttonOpenPrepearing.Text = "Подготовка к работе";
            this.buttonOpenPrepearing.UseVisualStyleBackColor = false;
            this.buttonOpenPrepearing.Click += new System.EventHandler(this.ButtonOpenPrepearing_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(-3, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 40);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panel2.Location = new System.Drawing.Point(-3, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 40);
            this.panel2.TabIndex = 6;
            // 
            // labelHowToUse
            // 
            this.labelHowToUse.AutoSize = true;
            this.labelHowToUse.BackColor = System.Drawing.Color.Transparent;
            this.labelHowToUse.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold);
            this.labelHowToUse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelHowToUse.Location = new System.Drawing.Point(45, 133);
            this.labelHowToUse.Name = "labelHowToUse";
            this.labelHowToUse.Size = new System.Drawing.Size(305, 27);
            this.labelHowToUse.TabIndex = 7;
            this.labelHowToUse.Text = "Как использовать программу?";
            // 
            // labelTableInfo
            // 
            this.labelTableInfo.AutoSize = true;
            this.labelTableInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelTableInfo.Font = new System.Drawing.Font("Candara", 13F);
            this.labelTableInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTableInfo.Location = new System.Drawing.Point(45, 176);
            this.labelTableInfo.Name = "labelTableInfo";
            this.labelTableInfo.Size = new System.Drawing.Size(642, 27);
            this.labelTableInfo.TabIndex = 8;
            this.labelTableInfo.Text = "1. Записать и/или загрузить список вопросов в таблицу вопросов.";
            // 
            // labelPrepearingInfo
            // 
            this.labelPrepearingInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPrepearingInfo.Font = new System.Drawing.Font("Candara", 13F);
            this.labelPrepearingInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPrepearingInfo.Location = new System.Drawing.Point(45, 219);
            this.labelPrepearingInfo.Name = "labelPrepearingInfo";
            this.labelPrepearingInfo.Size = new System.Drawing.Size(698, 74);
            this.labelPrepearingInfo.TabIndex = 9;
            this.labelPrepearingInfo.Text = "2. Готовиться к работе самостоятельно с режимом \"Подготовка к работе\". При правил" +
    "ьном устном ответе на вопрос нажимать";
            // 
            // labelTestInfo
            // 
            this.labelTestInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelTestInfo.Font = new System.Drawing.Font("Candara", 13F);
            this.labelTestInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTestInfo.Location = new System.Drawing.Point(45, 343);
            this.labelTestInfo.Name = "labelTestInfo";
            this.labelTestInfo.Size = new System.Drawing.Size(905, 89);
            this.labelTestInfo.TabIndex = 10;
            this.labelTestInfo.Text = "3. Чтобы показать свою компетентность, пройдите экзаменационное тестирование и по" +
    "кажите результаты работы отделу кадров или менеджеру. Учтите, что попытка у вас " +
    "будет всего одна.";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Candara", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.labelWelcome.Location = new System.Drawing.Point(337, 56);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(338, 46);
            this.labelWelcome.TabIndex = 11;
            this.labelWelcome.Text = "Добро пожаловать";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMain.Image = global::BusinessTraining.Properties.Resources.picture_smaller_but_no_yellow_no_blue;
            this.pictureBoxMain.Location = new System.Drawing.Point(749, 56);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(201, 237);
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // labellabelPrepearingInfo2
            // 
            this.labellabelPrepearingInfo2.BackColor = System.Drawing.Color.Transparent;
            this.labellabelPrepearingInfo2.Font = new System.Drawing.Font("Candara", 13F);
            this.labellabelPrepearingInfo2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labellabelPrepearingInfo2.Location = new System.Drawing.Point(45, 273);
            this.labellabelPrepearingInfo2.Name = "labellabelPrepearingInfo2";
            this.labellabelPrepearingInfo2.Size = new System.Drawing.Size(786, 55);
            this.labellabelPrepearingInfo2.TabIndex = 13;
            this.labellabelPrepearingInfo2.Text = "\"Верно\", при неправильном или неуверенном \"Неверно\". При желании можно подсмотрет" +
    "ь ответ.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.labellabelPrepearingInfo2);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTestInfo);
            this.Controls.Add(this.labelPrepearingInfo);
            this.Controls.Add(this.labelTableInfo);
            this.Controls.Add(this.labelHowToUse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOpenPrepearing);
            this.Controls.Add(this.buttonOpenTest);
            this.Controls.Add(this.buttonChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор режима";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonOpenTest;
        private System.Windows.Forms.Button buttonOpenPrepearing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHowToUse;
        private System.Windows.Forms.Label labelTableInfo;
        private System.Windows.Forms.Label labelPrepearingInfo;
        private System.Windows.Forms.Label labelTestInfo;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labellabelPrepearingInfo2;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}