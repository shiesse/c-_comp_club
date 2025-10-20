namespace katharsis_code
{
    partial class FormPeripheral
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
            this.dataGridViewPeripheral = new System.Windows.Forms.DataGridView();
            this.buttonPeripheralListExit = new System.Windows.Forms.Button();
            this.buttonAddPeripheral = new System.Windows.Forms.Button();
            this.buttonEditPeripheral = new System.Windows.Forms.Button();
            this.buttonDeletePeripheral = new System.Windows.Forms.Button();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.buttonDecommissionPeripheral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeripheral)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPeripheral
            // 
            this.dataGridViewPeripheral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeripheral.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPeripheral.Name = "dataGridViewPeripheral";
            this.dataGridViewPeripheral.RowHeadersWidth = 51;
            this.dataGridViewPeripheral.Size = new System.Drawing.Size(776, 311);
            this.dataGridViewPeripheral.TabIndex = 0;
            // 
            // buttonPeripheralListExit
            // 
            this.buttonPeripheralListExit.Location = new System.Drawing.Point(713, 415);
            this.buttonPeripheralListExit.Name = "buttonPeripheralListExit";
            this.buttonPeripheralListExit.Size = new System.Drawing.Size(75, 23);
            this.buttonPeripheralListExit.TabIndex = 1;
            this.buttonPeripheralListExit.Text = "Выход";
            this.buttonPeripheralListExit.UseVisualStyleBackColor = true;
            this.buttonPeripheralListExit.Click += new System.EventHandler(this.buttonPeripheralListExit_Click);
            // 
            // buttonAddPeripheral
            // 
            this.buttonAddPeripheral.Location = new System.Drawing.Point(632, 415);
            this.buttonAddPeripheral.Name = "buttonAddPeripheral";
            this.buttonAddPeripheral.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPeripheral.TabIndex = 2;
            this.buttonAddPeripheral.Text = "Добавить";
            this.buttonAddPeripheral.UseVisualStyleBackColor = true;
            this.buttonAddPeripheral.Click += new System.EventHandler(this.buttonAddPeripheral_Click);
            // 
            // buttonEditPeripheral
            // 
            this.buttonEditPeripheral.Location = new System.Drawing.Point(533, 415);
            this.buttonEditPeripheral.Name = "buttonEditPeripheral";
            this.buttonEditPeripheral.Size = new System.Drawing.Size(93, 23);
            this.buttonEditPeripheral.TabIndex = 3;
            this.buttonEditPeripheral.Text = "Редактировать";
            this.buttonEditPeripheral.UseVisualStyleBackColor = true;
            this.buttonEditPeripheral.Click += new System.EventHandler(this.buttonEditPeripheral_Click);
            // 
            // buttonDeletePeripheral
            // 
            this.buttonDeletePeripheral.Location = new System.Drawing.Point(451, 415);
            this.buttonDeletePeripheral.Name = "buttonDeletePeripheral";
            this.buttonDeletePeripheral.Size = new System.Drawing.Size(76, 23);
            this.buttonDeletePeripheral.TabIndex = 4;
            this.buttonDeletePeripheral.Text = "Удалить";
            this.buttonDeletePeripheral.UseVisualStyleBackColor = true;
            this.buttonDeletePeripheral.Click += new System.EventHandler(this.buttonDeletePeripheral_Click);
            // 
            // textBoxInventoryNumber
            // 
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(12, 329);
            this.textBoxInventoryNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(76, 20);
            this.textBoxInventoryNumber.TabIndex = 5;
            this.textBoxInventoryNumber.TextChanged += new System.EventHandler(this.textBoxInventoryNumber_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(92, 329);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxType.TabIndex = 6;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(187, 329);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatus.TabIndex = 7;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(282, 329);
            this.comboBoxManufacturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(92, 21);
            this.comboBoxManufacturer.TabIndex = 8;
            this.comboBoxManufacturer.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(377, 329);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(92, 21);
            this.comboBoxEmployee.TabIndex = 9;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // buttonDecommissionPeripheral
            // 
            this.buttonDecommissionPeripheral.Location = new System.Drawing.Point(369, 415);
            this.buttonDecommissionPeripheral.Name = "buttonDecommissionPeripheral";
            this.buttonDecommissionPeripheral.Size = new System.Drawing.Size(76, 23);
            this.buttonDecommissionPeripheral.TabIndex = 10;
            this.buttonDecommissionPeripheral.Text = "Списать";
            this.buttonDecommissionPeripheral.UseVisualStyleBackColor = true;
            this.buttonDecommissionPeripheral.Click += new System.EventHandler(this.buttonDecommissionPeripheral_Click);
            // 
            // FormPeripheral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDecommissionPeripheral);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxInventoryNumber);
            this.Controls.Add(this.buttonDeletePeripheral);
            this.Controls.Add(this.buttonEditPeripheral);
            this.Controls.Add(this.buttonAddPeripheral);
            this.Controls.Add(this.buttonPeripheralListExit);
            this.Controls.Add(this.dataGridViewPeripheral);
            this.Name = "FormPeripheral";
            this.Text = "Периферия";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeripheral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeripheral;
        private System.Windows.Forms.Button buttonPeripheralListExit;
        private System.Windows.Forms.Button buttonAddPeripheral;
        private System.Windows.Forms.Button buttonEditPeripheral;
        private System.Windows.Forms.Button buttonDeletePeripheral;
        private System.Windows.Forms.TextBox textBoxInventoryNumber;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonDecommissionPeripheral;
    }
}