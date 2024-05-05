namespace BusinessTraining
{
    partial class PreparationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreparationForm));
            this.textBoxForQuestions = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.textBoxForAnswers = new System.Windows.Forms.TextBox();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonWrong = new System.Windows.Forms.Button();
            this.buttonShowOrHideAnswer = new System.Windows.Forms.Button();
            this.textBoxTrainingTitle = new System.Windows.Forms.TextBox();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxForQuestions
            // 
            this.textBoxForQuestions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxForQuestions.Font = new System.Drawing.Font("Candara", 13F);
            this.textBoxForQuestions.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxForQuestions.Location = new System.Drawing.Point(31, 71);
            this.textBoxForQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForQuestions.Multiline = true;
            this.textBoxForQuestions.Name = "textBoxForQuestions";
            this.textBoxForQuestions.ReadOnly = true;
            this.textBoxForQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForQuestions.Size = new System.Drawing.Size(1090, 212);
            this.textBoxForQuestions.TabIndex = 14;
            this.textBoxForQuestions.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Candara", 13F);
            this.labelInfo.Location = new System.Drawing.Point(37, 318);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(208, 27);
            this.labelInfo.TabIndex = 17;
            this.labelInfo.Text = "Осталось вопросов: ";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Candara", 13F);
            this.labelCounter.Location = new System.Drawing.Point(261, 318);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(0, 27);
            this.labelCounter.TabIndex = 18;
            // 
            // textBoxForAnswers
            // 
            this.textBoxForAnswers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxForAnswers.Font = new System.Drawing.Font("Candara", 13F);
            this.textBoxForAnswers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxForAnswers.Location = new System.Drawing.Point(31, 379);
            this.textBoxForAnswers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForAnswers.Multiline = true;
            this.textBoxForAnswers.Name = "textBoxForAnswers";
            this.textBoxForAnswers.ReadOnly = true;
            this.textBoxForAnswers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForAnswers.Size = new System.Drawing.Size(1090, 212);
            this.textBoxForAnswers.TabIndex = 19;
            this.textBoxForAnswers.TabStop = false;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panelUp.Controls.Add(this.textBoxTrainingTitle);
            this.panelUp.Controls.Add(this.buttonBack);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1184, 44);
            this.panelUp.TabIndex = 20;
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
            this.panelDown.Location = new System.Drawing.Point(0, 614);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1155, 44);
            this.panelDown.TabIndex = 21;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.ForeColor = System.Drawing.Color.White;
            this.buttonRight.Location = new System.Drawing.Point(377, 307);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(159, 50);
            this.buttonRight.TabIndex = 22;
            this.buttonRight.Text = "Верно";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // buttonWrong
            // 
            this.buttonWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonWrong.FlatAppearance.BorderSize = 0;
            this.buttonWrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWrong.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWrong.ForeColor = System.Drawing.Color.White;
            this.buttonWrong.Location = new System.Drawing.Point(575, 307);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(159, 50);
            this.buttonWrong.TabIndex = 23;
            this.buttonWrong.Text = "Неверно";
            this.buttonWrong.UseVisualStyleBackColor = false;
            this.buttonWrong.Click += new System.EventHandler(this.ButtonWrong_Click);
            // 
            // buttonShowOrHideAnswer
            // 
            this.buttonShowOrHideAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonShowOrHideAnswer.FlatAppearance.BorderSize = 0;
            this.buttonShowOrHideAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowOrHideAnswer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowOrHideAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonShowOrHideAnswer.Location = new System.Drawing.Point(941, 307);
            this.buttonShowOrHideAnswer.Name = "buttonShowOrHideAnswer";
            this.buttonShowOrHideAnswer.Size = new System.Drawing.Size(181, 50);
            this.buttonShowOrHideAnswer.TabIndex = 24;
            this.buttonShowOrHideAnswer.Text = "Показать ответ";
            this.buttonShowOrHideAnswer.UseVisualStyleBackColor = false;
            this.buttonShowOrHideAnswer.Click += new System.EventHandler(this.ButtonShowOrHideAnswer_Click);
            // 
            // textBoxTrainingTitle
            // 
            this.textBoxTrainingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.textBoxTrainingTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTrainingTitle.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxTrainingTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTrainingTitle.Location = new System.Drawing.Point(575, 11);
            this.textBoxTrainingTitle.Multiline = true;
            this.textBoxTrainingTitle.Name = "textBoxTrainingTitle";
            this.textBoxTrainingTitle.Size = new System.Drawing.Size(547, 22);
            this.textBoxTrainingTitle.TabIndex = 1;
            this.textBoxTrainingTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PreparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 655);
            this.Controls.Add(this.buttonShowOrHideAnswer);
            this.Controls.Add(this.buttonWrong);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.textBoxForAnswers);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.textBoxForQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PreparationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подготовка к работе";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxForQuestions;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.TextBox textBoxForAnswers;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.Button buttonShowOrHideAnswer;
        private System.Windows.Forms.TextBox textBoxTrainingTitle;
    }
}

