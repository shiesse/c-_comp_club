namespace katharsis_code
{
    partial class FormEditEmployee
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
            this.buttonEditEmployeeExit = new System.Windows.Forms.Button();
            this.buttonEditEmployeeSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditEmployeeFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEditEmployeePosition = new System.Windows.Forms.ComboBox();
            this.comboBoxEditEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEditEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEditEmployeeExit
            // 
            this.buttonEditEmployeeExit.Location = new System.Drawing.Point(634, 403);
            this.buttonEditEmployeeExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditEmployeeExit.Name = "buttonEditEmployeeExit";
            this.buttonEditEmployeeExit.Size = new System.Drawing.Size(56, 19);
            this.buttonEditEmployeeExit.TabIndex = 0;
            this.buttonEditEmployeeExit.Text = "Выход";
            this.buttonEditEmployeeExit.UseVisualStyleBackColor = true;
            this.buttonEditEmployeeExit.Click += new System.EventHandler(this.buttonEditEmployeeExit_Click);
            // 
            // buttonEditEmployeeSave
            // 
            this.buttonEditEmployeeSave.Location = new System.Drawing.Point(573, 403);
            this.buttonEditEmployeeSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditEmployeeSave.Name = "buttonEditEmployeeSave";
            this.buttonEditEmployeeSave.Size = new System.Drawing.Size(56, 19);
            this.buttonEditEmployeeSave.TabIndex = 1;
            this.buttonEditEmployeeSave.Text = "Сохранить";
            this.buttonEditEmployeeSave.UseVisualStyleBackColor = true;
            this.buttonEditEmployeeSave.Click += new System.EventHandler(this.buttonEditEmployeeSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // textBoxEditEmployeeFIO
            // 
            this.textBoxEditEmployeeFIO.Location = new System.Drawing.Point(9, 23);
            this.textBoxEditEmployeeFIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditEmployeeFIO.Name = "textBoxEditEmployeeFIO";
            this.textBoxEditEmployeeFIO.Size = new System.Drawing.Size(76, 20);
            this.textBoxEditEmployeeFIO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Должность";
            // 
            // comboBoxEditEmployeePosition
            // 
            this.comboBoxEditEmployeePosition.FormattingEnabled = true;
            this.comboBoxEditEmployeePosition.Location = new System.Drawing.Point(11, 58);
            this.comboBoxEditEmployeePosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEditEmployeePosition.Name = "comboBoxEditEmployeePosition";
            this.comboBoxEditEmployeePosition.Size = new System.Drawing.Size(150, 21);
            this.comboBoxEditEmployeePosition.TabIndex = 5;
            // 
            // comboBoxEditEmployeeStatus
            // 
            this.comboBoxEditEmployeeStatus.FormattingEnabled = true;
            this.comboBoxEditEmployeeStatus.Location = new System.Drawing.Point(11, 99);
            this.comboBoxEditEmployeeStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEditEmployeeStatus.Name = "comboBoxEditEmployeeStatus";
            this.comboBoxEditEmployeeStatus.Size = new System.Drawing.Size(150, 21);
            this.comboBoxEditEmployeeStatus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Статус";
            // 
            // comboBoxEditEmployeeDepartment
            // 
            this.comboBoxEditEmployeeDepartment.FormattingEnabled = true;
            this.comboBoxEditEmployeeDepartment.Location = new System.Drawing.Point(11, 145);
            this.comboBoxEditEmployeeDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEditEmployeeDepartment.Name = "comboBoxEditEmployeeDepartment";
            this.comboBoxEditEmployeeDepartment.Size = new System.Drawing.Size(150, 21);
            this.comboBoxEditEmployeeDepartment.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отдел";
            // 
            // FormEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 431);
            this.Controls.Add(this.comboBoxEditEmployeeDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEditEmployeeStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEditEmployeePosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEditEmployeeFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditEmployeeSave);
            this.Controls.Add(this.buttonEditEmployeeExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEditEmployee";
            this.Text = "Редактировать сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditEmployeeExit;
        private System.Windows.Forms.Button buttonEditEmployeeSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditEmployeeFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEditEmployeePosition;
        private System.Windows.Forms.ComboBox comboBoxEditEmployeeStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEditEmployeeDepartment;
        private System.Windows.Forms.Label label4;
    }
}