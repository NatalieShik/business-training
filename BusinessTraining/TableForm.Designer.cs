namespace BusinessTraining
{
    partial class TableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxDirection = new System.Windows.Forms.TextBox();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.dataGridViewForQandA = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WrongAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelWrongAnswers = new System.Windows.Forms.Label();
            this.textBoxWrongAnswers = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForQandA)).BeginInit();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(45, 94);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(233, 122);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.TabStop = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.Location = new System.Drawing.Point(45, 251);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(233, 28);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.TabStop = false;
            // 
            // textBoxDirection
            // 
            this.textBoxDirection.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDirection.Location = new System.Drawing.Point(44, 479);
            this.textBoxDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDirection.Name = "textBoxDirection";
            this.textBoxDirection.Size = new System.Drawing.Size(233, 28);
            this.textBoxDirection.TabIndex = 2;
            this.textBoxDirection.TabStop = false;
            // 
            // textBoxSection
            // 
            this.textBoxSection.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSection.Location = new System.Drawing.Point(45, 543);
            this.textBoxSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(233, 28);
            this.textBoxSection.TabIndex = 3;
            this.textBoxSection.TabStop = false;
            // 
            // dataGridViewForQandA
            // 
            this.dataGridViewForQandA.AllowUserToAddRows = false;
            this.dataGridViewForQandA.AllowUserToDeleteRows = false;
            this.dataGridViewForQandA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewForQandA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForQandA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForQandA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewForQandA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForQandA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Answer,
            this.WrongAnswers,
            this.Direction,
            this.Section});
            this.dataGridViewForQandA.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForQandA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewForQandA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewForQandA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.dataGridViewForQandA.Location = new System.Drawing.Point(319, 59);
            this.dataGridViewForQandA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewForQandA.MultiSelect = false;
            this.dataGridViewForQandA.Name = "dataGridViewForQandA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara Light", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForQandA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewForQandA.RowHeadersVisible = false;
            this.dataGridViewForQandA.RowHeadersWidth = 51;
            this.dataGridViewForQandA.RowTemplate.Height = 24;
            this.dataGridViewForQandA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForQandA.Size = new System.Drawing.Size(812, 754);
            this.dataGridViewForQandA.TabIndex = 22;
            this.dataGridViewForQandA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewForQandA_CellClick);
            // 
            // Question
            // 
            this.Question.HeaderText = "Вопрос";
            this.Question.MinimumWidth = 6;
            this.Question.Name = "Question";
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Ответ";
            this.Answer.MinimumWidth = 6;
            this.Answer.Name = "Answer";
            // 
            // WrongAnswers
            // 
            this.WrongAnswers.HeaderText = "Неправильные ответы";
            this.WrongAnswers.MinimumWidth = 6;
            this.WrongAnswers.Name = "WrongAnswers";
            // 
            // Direction
            // 
            this.Direction.HeaderText = "Направление";
            this.Direction.MinimumWidth = 6;
            this.Direction.Name = "Direction";
            // 
            // Section
            // 
            this.Section.HeaderText = "Раздел";
            this.Section.MinimumWidth = 6;
            this.Section.Name = "Section";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(43, 69);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(66, 21);
            this.labelQuestion.TabIndex = 23;
            this.labelQuestion.Text = "Вопрос";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswer.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(43, 226);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(53, 21);
            this.labelAnswer.TabIndex = 24;
            this.labelAnswer.Text = "Ответ";
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.BackColor = System.Drawing.Color.Transparent;
            this.labelDirection.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirection.Location = new System.Drawing.Point(40, 455);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(107, 21);
            this.labelDirection.TabIndex = 25;
            this.labelDirection.Text = "Направление";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.BackColor = System.Drawing.Color.Transparent;
            this.labelSection.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSection.Location = new System.Drawing.Point(41, 519);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(61, 21);
            this.labelSection.TabIndex = 26;
            this.labelSection.Text = "Раздел";
            // 
            // panelUp
            // 
            this.panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panelUp.Controls.Add(this.buttonExport);
            this.panelUp.Controls.Add(this.buttonBack);
            this.panelUp.Controls.Add(this.buttonImport);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1144, 44);
            this.panelUp.TabIndex = 27;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(216, 0);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(101, 44);
            this.buttonExport.TabIndex = 30;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.buttonImport.FlatAppearance.BorderSize = 0;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(108, 0);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(101, 44);
            this.buttonImport.TabIndex = 29;
            this.buttonImport.Text = "Импорт";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // panelDown
            // 
            this.panelDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panelDown.Location = new System.Drawing.Point(0, 818);
            this.panelDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1144, 44);
            this.panelDown.TabIndex = 28;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(85, 596);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 50);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(85, 661);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(149, 50);
            this.buttonChange.TabIndex = 31;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(85, 726);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 50);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // labelWrongAnswers
            // 
            this.labelWrongAnswers.AutoSize = true;
            this.labelWrongAnswers.BackColor = System.Drawing.Color.Transparent;
            this.labelWrongAnswers.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWrongAnswers.Location = new System.Drawing.Point(43, 297);
            this.labelWrongAnswers.Name = "labelWrongAnswers";
            this.labelWrongAnswers.Size = new System.Drawing.Size(174, 21);
            this.labelWrongAnswers.TabIndex = 34;
            this.labelWrongAnswers.Text = "Неправильные ответы";
            // 
            // textBoxWrongAnswers
            // 
            this.textBoxWrongAnswers.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWrongAnswers.Location = new System.Drawing.Point(44, 321);
            this.textBoxWrongAnswers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWrongAnswers.Multiline = true;
            this.textBoxWrongAnswers.Name = "textBoxWrongAnswers";
            this.textBoxWrongAnswers.Size = new System.Drawing.Size(233, 122);
            this.textBoxWrongAnswers.TabIndex = 33;
            this.textBoxWrongAnswers.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(101, 44);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 846);
            this.Controls.Add(this.labelWrongAnswers);
            this.Controls.Add(this.textBoxWrongAnswers);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.dataGridViewForQandA);
            this.Controls.Add(this.textBoxSection);
            this.Controls.Add(this.textBoxDirection);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(799, 851);
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица вопросов и ответов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForQandA)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxDirection;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.DataGridView dataGridViewForQandA;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelWrongAnswers;
        private System.Windows.Forms.TextBox textBoxWrongAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn WrongAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonBack;
    }
}