namespace katharsis_code
{
    partial class FormWriteOffReport
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
            this.dataGridViewWriteOffReport = new System.Windows.Forms.DataGridView();
            this.buttonWriteOffReportListExit = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxResponsiblePerson = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOffReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWriteOffReport
            // 
            this.dataGridViewWriteOffReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriteOffReport.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewWriteOffReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewWriteOffReport.Name = "dataGridViewWriteOffReport";
            this.dataGridViewWriteOffReport.RowHeadersWidth = 51;
            this.dataGridViewWriteOffReport.Size = new System.Drawing.Size(1035, 378);
            this.dataGridViewWriteOffReport.TabIndex = 0;
            // 
            // buttonWriteOffReportListExit
            // 
            this.buttonWriteOffReportListExit.Location = new System.Drawing.Point(951, 511);
            this.buttonWriteOffReportListExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWriteOffReportListExit.Name = "buttonWriteOffReportListExit";
            this.buttonWriteOffReportListExit.Size = new System.Drawing.Size(100, 28);
            this.buttonWriteOffReportListExit.TabIndex = 2;
            this.buttonWriteOffReportListExit.Text = "Выход";
            this.buttonWriteOffReportListExit.UseVisualStyleBackColor = true;
            this.buttonWriteOffReportListExit.Click += new System.EventHandler(this.buttonWriteOffReportListExit_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(288, 401);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // textBoxResponsiblePerson
            // 
            this.textBoxResponsiblePerson.Location = new System.Drawing.Point(543, 401);
            this.textBoxResponsiblePerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResponsiblePerson.Name = "textBoxResponsiblePerson";
            this.textBoxResponsiblePerson.Size = new System.Drawing.Size(100, 22);
            this.textBoxResponsiblePerson.TabIndex = 9;
            this.textBoxResponsiblePerson.TextChanged += new System.EventHandler(this.textBoxNameFilter_TextChanged);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(416, 401);
            this.textBoxNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxNum.TabIndex = 10;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNameFilter_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 401);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 433);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // FormWriteOffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.textBoxResponsiblePerson);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonWriteOffReportListExit);
            this.Controls.Add(this.dataGridViewWriteOffReport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormWriteOffReport";
            this.Text = "Акт о списании";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOffReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWriteOffReport;
        private System.Windows.Forms.Button buttonWriteOffReportListExit;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxResponsiblePerson;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}