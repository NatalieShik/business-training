namespace BusinessTraining
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.textBoxForQuestions = new System.Windows.Forms.TextBox();
            this.comboBoxAnswer = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelQuestionsLeft = new System.Windows.Forms.Label();
            this.labelQuestionsLeftNum = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxForQuestions
            // 
            this.textBoxForQuestions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxForQuestions.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForQuestions.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxForQuestions.Location = new System.Drawing.Point(43, 66);
            this.textBoxForQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForQuestions.Multiline = true;
            this.textBoxForQuestions.Name = "textBoxForQuestions";
            this.textBoxForQuestions.ReadOnly = true;
            this.textBoxForQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForQuestions.Size = new System.Drawing.Size(715, 212);
            this.textBoxForQuestions.TabIndex = 15;
            this.textBoxForQuestions.TabStop = false;
            // 
            // comboBoxAnswer
            // 
            this.comboBoxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.comboBoxAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAnswer.Font = new System.Drawing.Font("Candara", 10F);
            this.comboBoxAnswer.FormattingEnabled = true;
            this.comboBoxAnswer.Location = new System.Drawing.Point(43, 366);
            this.comboBoxAnswer.Name = "comboBoxAnswer";
            this.comboBoxAnswer.Size = new System.Drawing.Size(715, 29);
            this.comboBoxAnswer.TabIndex = 16;
            this.comboBoxAnswer.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(66)))));
            this.labelInfo.Location = new System.Drawing.Point(308, 328);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(150, 24);
            this.labelInfo.TabIndex = 19;
            this.labelInfo.Text = "Выберите ответ";
            // 
            // labelQuestionsLeft
            // 
            this.labelQuestionsLeft.AutoSize = true;
            this.labelQuestionsLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionsLeft.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionsLeft.Location = new System.Drawing.Point(39, 280);
            this.labelQuestionsLeft.Name = "labelQuestionsLeft";
            this.labelQuestionsLeft.Size = new System.Drawing.Size(159, 21);
            this.labelQuestionsLeft.TabIndex = 22;
            this.labelQuestionsLeft.Text = "Осталовь вопросов:";
            // 
            // labelQuestionsLeftNum
            // 
            this.labelQuestionsLeftNum.AutoSize = true;
            this.labelQuestionsLeftNum.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionsLeftNum.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionsLeftNum.Location = new System.Drawing.Point(217, 280);
            this.labelQuestionsLeftNum.Name = "labelQuestionsLeftNum";
            this.labelQuestionsLeftNum.Size = new System.Drawing.Size(0, 21);
            this.labelQuestionsLeftNum.TabIndex = 23;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panelUp.Controls.Add(this.buttonBack);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(803, 44);
            this.panelUp.TabIndex = 24;
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 44);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panelDown.Location = new System.Drawing.Point(0, 509);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(803, 44);
            this.panelDown.TabIndex = 25;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(312, 444);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(159, 50);
            this.buttonNext.TabIndex = 26;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.labelQuestionsLeftNum);
            this.Controls.Add(this.labelQuestionsLeft);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.comboBoxAnswer);
            this.Controls.Add(this.textBoxForQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForQuestions;
        private System.Windows.Forms.ComboBox comboBoxAnswer;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelQuestionsLeft;
        private System.Windows.Forms.Label labelQuestionsLeftNum;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button buttonNext;
    }
}