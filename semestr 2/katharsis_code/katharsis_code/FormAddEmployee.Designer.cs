namespace katharsis_code
{
    partial class FormAddEmployee
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.buttonCloseFormAddEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.labelEmployeePosition = new System.Windows.Forms.Label();
            this.comboBoxEmployeePosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(9, 7);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(9, 23);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(341, 20);
            this.textBoxFIO.TabIndex = 1;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(9, 50);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(38, 13);
            this.labelDepartment.TabIndex = 2;
            this.labelDepartment.Text = "Отдел";
            // 
            // buttonCloseFormAddEmployee
            // 
            this.buttonCloseFormAddEmployee.Location = new System.Drawing.Point(334, 186);
            this.buttonCloseFormAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseFormAddEmployee.Name = "buttonCloseFormAddEmployee";
            this.buttonCloseFormAddEmployee.Size = new System.Drawing.Size(56, 19);
            this.buttonCloseFormAddEmployee.TabIndex = 4;
            this.buttonCloseFormAddEmployee.Text = "Закрыть";
            this.buttonCloseFormAddEmployee.UseVisualStyleBackColor = true;
            this.buttonCloseFormAddEmployee.Click += new System.EventHandler(this.buttonCloseFormAddEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(262, 186);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(68, 19);
            this.buttonAddEmployee.TabIndex = 5;
            this.buttonAddEmployee.Text = "Сохранить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(9, 65);
            this.comboBoxDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(341, 21);
            this.comboBoxDepartment.TabIndex = 6;
            // 
            // labelEmployeePosition
            // 
            this.labelEmployeePosition.AutoSize = true;
            this.labelEmployeePosition.Location = new System.Drawing.Point(9, 100);
            this.labelEmployeePosition.Name = "labelEmployeePosition";
            this.labelEmployeePosition.Size = new System.Drawing.Size(65, 13);
            this.labelEmployeePosition.TabIndex = 7;
            this.labelEmployeePosition.Text = "Должность";
            // 
            // comboBoxEmployeePosition
            // 
            this.comboBoxEmployeePosition.FormattingEnabled = true;
            this.comboBoxEmployeePosition.Location = new System.Drawing.Point(9, 117);
            this.comboBoxEmployeePosition.Name = "comboBoxEmployeePosition";
            this.comboBoxEmployeePosition.Size = new System.Drawing.Size(341, 21);
            this.comboBoxEmployeePosition.TabIndex = 8;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 216);
            this.Controls.Add(this.comboBoxEmployeePosition);
            this.Controls.Add(this.labelEmployeePosition);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonCloseFormAddEmployee);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddEmployee";
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button buttonCloseFormAddEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelEmployeePosition;
        private System.Windows.Forms.ComboBox comboBoxEmployeePosition;
    }
}