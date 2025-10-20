namespace katharsis_code
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenDepatment = new System.Windows.Forms.Button();
            this.buttonOpenComputers = new System.Windows.Forms.Button();
            this.buttonOpenPeripheral = new System.Windows.Forms.Button();
            this.buttonOpenWriteOffReport = new System.Windows.Forms.Button();
            this.buttonOpenManufacturer = new System.Windows.Forms.Button();
            this.buttonOpenEmployee = new System.Windows.Forms.Button();
            this.buttonOpenComponent = new System.Windows.Forms.Button();
            this.button_generateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenDepatment
            // 
            this.buttonOpenDepatment.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenDepatment.Name = "buttonOpenDepatment";
            this.buttonOpenDepatment.Size = new System.Drawing.Size(84, 23);
            this.buttonOpenDepatment.TabIndex = 0;
            this.buttonOpenDepatment.Text = "Отделы";
            this.buttonOpenDepatment.UseVisualStyleBackColor = false;
            this.buttonOpenDepatment.Click += new System.EventHandler(this.buttonOpenDepatment_Click);
            // 
            // buttonOpenComputers
            // 
            this.buttonOpenComputers.Location = new System.Drawing.Point(554, 12);
            this.buttonOpenComputers.Name = "buttonOpenComputers";
            this.buttonOpenComputers.Size = new System.Drawing.Size(91, 23);
            this.buttonOpenComputers.TabIndex = 1;
            this.buttonOpenComputers.Text = "Компьютеры";
            this.buttonOpenComputers.UseVisualStyleBackColor = true;
            this.buttonOpenComputers.Click += new System.EventHandler(this.buttonOpenComputers_Click);
            // 
            // buttonOpenPeripheral
            // 
            this.buttonOpenPeripheral.Location = new System.Drawing.Point(460, 12);
            this.buttonOpenPeripheral.Name = "buttonOpenPeripheral";
            this.buttonOpenPeripheral.Size = new System.Drawing.Size(88, 23);
            this.buttonOpenPeripheral.TabIndex = 2;
            this.buttonOpenPeripheral.Text = "Периферия";
            this.buttonOpenPeripheral.UseVisualStyleBackColor = true;
            this.buttonOpenPeripheral.Click += new System.EventHandler(this.buttonOpenPeripheral_Click);
            // 
            // buttonOpenWriteOffReport
            // 
            this.buttonOpenWriteOffReport.Location = new System.Drawing.Point(198, 98);
            this.buttonOpenWriteOffReport.Name = "buttonOpenWriteOffReport";
            this.buttonOpenWriteOffReport.Size = new System.Drawing.Size(103, 23);
            this.buttonOpenWriteOffReport.TabIndex = 4;
            this.buttonOpenWriteOffReport.Text = "Акт о списании";
            this.buttonOpenWriteOffReport.UseVisualStyleBackColor = true;
            this.buttonOpenWriteOffReport.Click += new System.EventHandler(this.buttonOpenWriteOffReport_Click);
            // 
            // buttonOpenManufacturer
            // 
            this.buttonOpenManufacturer.Location = new System.Drawing.Point(102, 12);
            this.buttonOpenManufacturer.Name = "buttonOpenManufacturer";
            this.buttonOpenManufacturer.Size = new System.Drawing.Size(103, 23);
            this.buttonOpenManufacturer.TabIndex = 3;
            this.buttonOpenManufacturer.Text = "Производитель";
            this.buttonOpenManufacturer.UseVisualStyleBackColor = true;
            this.buttonOpenManufacturer.Click += new System.EventHandler(this.buttonOpenManufacturer_Click);
            // 
            // buttonOpenEmployee
            // 
            this.buttonOpenEmployee.Location = new System.Drawing.Point(364, 12);
            this.buttonOpenEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenEmployee.Name = "buttonOpenEmployee";
            this.buttonOpenEmployee.Size = new System.Drawing.Size(91, 23);
            this.buttonOpenEmployee.TabIndex = 5;
            this.buttonOpenEmployee.Text = "Сотрудники";
            this.buttonOpenEmployee.UseVisualStyleBackColor = true;
            this.buttonOpenEmployee.Click += new System.EventHandler(this.buttonOpenEmployee_Click);
            // 
            // buttonOpenComponent
            // 
            this.buttonOpenComponent.Location = new System.Drawing.Point(210, 12);
            this.buttonOpenComponent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenComponent.Name = "buttonOpenComponent";
            this.buttonOpenComponent.Size = new System.Drawing.Size(91, 23);
            this.buttonOpenComponent.TabIndex = 6;
            this.buttonOpenComponent.Text = "Компоненты";
            this.buttonOpenComponent.UseVisualStyleBackColor = true;
            this.buttonOpenComponent.Click += new System.EventHandler(this.buttonOpenComponent_Click);
            // 
            // button_generateReport
            // 
            this.button_generateReport.Location = new System.Drawing.Point(306, 98);
            this.button_generateReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_generateReport.Name = "button_generateReport";
            this.button_generateReport.Size = new System.Drawing.Size(91, 23);
            this.button_generateReport.TabIndex = 7;
            this.button_generateReport.Text = "Отчет";
            this.button_generateReport.UseVisualStyleBackColor = true;
            this.button_generateReport.Click += new System.EventHandler(this.button_generateReport_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 147);
            this.Controls.Add(this.button_generateReport);
            this.Controls.Add(this.buttonOpenComponent);
            this.Controls.Add(this.buttonOpenEmployee);
            this.Controls.Add(this.buttonOpenWriteOffReport);
            this.Controls.Add(this.buttonOpenManufacturer);
            this.Controls.Add(this.buttonOpenPeripheral);
            this.Controls.Add(this.buttonOpenComputers);
            this.Controls.Add(this.buttonOpenDepatment);
            this.Name = "FormMain";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDepatment;
        private System.Windows.Forms.Button buttonOpenComputers;
        private System.Windows.Forms.Button buttonOpenPeripheral;
        private System.Windows.Forms.Button buttonOpenWriteOffReport;
        private System.Windows.Forms.Button buttonOpenManufacturer;
        private System.Windows.Forms.Button buttonOpenEmployee;
        private System.Windows.Forms.Button buttonOpenComponent;
        private System.Windows.Forms.Button button_generateReport;
    }
}

