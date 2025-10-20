namespace katharsis_code
{
    partial class FormEmployee
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
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonCloseFormEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonFormEmployeeDelete = new System.Windows.Forms.Button();
            this.textBoxSearchFullName = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(717, 321);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // buttonCloseFormEmployee
            // 
            this.buttonCloseFormEmployee.Location = new System.Drawing.Point(670, 388);
            this.buttonCloseFormEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCloseFormEmployee.Name = "buttonCloseFormEmployee";
            this.buttonCloseFormEmployee.Size = new System.Drawing.Size(56, 19);
            this.buttonCloseFormEmployee.TabIndex = 1;
            this.buttonCloseFormEmployee.Text = "Закрыть";
            this.buttonCloseFormEmployee.UseVisualStyleBackColor = true;
            this.buttonCloseFormEmployee.Click += new System.EventHandler(this.buttonCloseFormEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(609, 388);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(56, 19);
            this.buttonAddEmployee.TabIndex = 2;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Location = new System.Drawing.Point(548, 388);
            this.buttonEditEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(56, 19);
            this.buttonEditEmployee.TabIndex = 3;
            this.buttonEditEmployee.Text = "Редактировать";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonFormEmployeeDelete
            // 
            this.buttonFormEmployeeDelete.Location = new System.Drawing.Point(488, 388);
            this.buttonFormEmployeeDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFormEmployeeDelete.Name = "buttonFormEmployeeDelete";
            this.buttonFormEmployeeDelete.Size = new System.Drawing.Size(56, 19);
            this.buttonFormEmployeeDelete.TabIndex = 4;
            this.buttonFormEmployeeDelete.Text = "Удалить";
            this.buttonFormEmployeeDelete.UseVisualStyleBackColor = true;
            this.buttonFormEmployeeDelete.Click += new System.EventHandler(this.buttonFormEmployeeDelete_Click);
            // 
            // textBoxSearchFullName
            // 
            this.textBoxSearchFullName.Location = new System.Drawing.Point(9, 336);
            this.textBoxSearchFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchFullName.Name = "textBoxSearchFullName";
            this.textBoxSearchFullName.Size = new System.Drawing.Size(76, 20);
            this.textBoxSearchFullName.TabIndex = 6;
            this.textBoxSearchFullName.TextChanged += new System.EventHandler(this.FiltersChanged);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(88, 336);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPosition.TabIndex = 7;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.FiltersChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(184, 336);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatus.TabIndex = 8;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.FiltersChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(279, 336);
            this.comboBoxDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDepartment.TabIndex = 9;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.FiltersChanged);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 417);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.textBoxSearchFullName);
            this.Controls.Add(this.buttonFormEmployeeDelete);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonCloseFormEmployee);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEmployee";
            this.Text = "Сотрудник";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonCloseFormEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonFormEmployeeDelete;
        private System.Windows.Forms.TextBox textBoxSearchFullName;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
    }
}