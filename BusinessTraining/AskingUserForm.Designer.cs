namespace BusinessTraining
{
    partial class AskingUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskingUserForm));
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSections = new System.Windows.Forms.CheckedListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDirection.Font = new System.Drawing.Font("Candara", 10F);
            this.comboBoxDirection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(46, 145);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(181, 29);
            this.comboBoxDirection.TabIndex = 0;
            this.comboBoxDirection.TabStop = false;
            this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDirection_SelectedIndexChanged);
            // 
            // checkedListBoxSections
            // 
            this.checkedListBoxSections.Font = new System.Drawing.Font("Candara", 10F);
            this.checkedListBoxSections.FormattingEnabled = true;
            this.checkedListBoxSections.Location = new System.Drawing.Point(304, 145);
            this.checkedListBoxSections.Name = "checkedListBoxSections";
            this.checkedListBoxSections.Size = new System.Drawing.Size(209, 119);
            this.checkedListBoxSections.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Candara", 13F);
            this.labelInfo.Location = new System.Drawing.Point(59, 87);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(405, 27);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.Text = "Выберите направление, а затем разделы";
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(157)))));
            this.panelUp.Controls.Add(this.buttonBack);
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(557, 44);
            this.panelUp.TabIndex = 19;
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
            this.panelDown.Location = new System.Drawing.Point(0, 332);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(557, 40);
            this.panelDown.TabIndex = 20;
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(195)))));
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(211, 268);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(121, 41);
            this.buttonOpen.TabIndex = 21;
            this.buttonOpen.Text = "Далее";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // AskingUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 370);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.checkedListBoxSections);
            this.Controls.Add(this.comboBoxDirection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AskingUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор темы и подтемы";
            this.Load += new System.EventHandler(this.AskingUserForm_Load);
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.CheckedListBox checkedListBoxSections;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonBack;
    }
}