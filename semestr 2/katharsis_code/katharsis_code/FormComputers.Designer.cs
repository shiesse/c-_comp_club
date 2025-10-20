namespace katharsis_code
{
    partial class FormComputers
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
            this.dataGridViewComputer = new System.Windows.Forms.DataGridView();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            this.buttonComputerExit = new System.Windows.Forms.Button();
            this.buttonEditComputer = new System.Windows.Forms.Button();
            this.button_Comp_delete = new System.Windows.Forms.Button();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxCPU = new System.Windows.Forms.ComboBox();
            this.comboBoxMotherBoard = new System.Windows.Forms.ComboBox();
            this.comboBoxHDD = new System.Windows.Forms.ComboBox();
            this.button_Comp_decomm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComputer
            // 
            this.dataGridViewComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComputer.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewComputer.Name = "dataGridViewComputer";
            this.dataGridViewComputer.RowHeadersWidth = 51;
            this.dataGridViewComputer.Size = new System.Drawing.Size(776, 324);
            this.dataGridViewComputer.TabIndex = 0;
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.Location = new System.Drawing.Point(530, 415);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddComputer.TabIndex = 4;
            this.buttonAddComputer.Text = "Добавить";
            this.buttonAddComputer.UseVisualStyleBackColor = true;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAddComputer_Click);
            // 
            // buttonComputerExit
            // 
            this.buttonComputerExit.Location = new System.Drawing.Point(713, 415);
            this.buttonComputerExit.Name = "buttonComputerExit";
            this.buttonComputerExit.Size = new System.Drawing.Size(75, 23);
            this.buttonComputerExit.TabIndex = 3;
            this.buttonComputerExit.Text = "Выход";
            this.buttonComputerExit.UseVisualStyleBackColor = true;
            this.buttonComputerExit.Click += new System.EventHandler(this.buttonComputerExit_Click);
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.Location = new System.Drawing.Point(611, 415);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(96, 23);
            this.buttonEditComputer.TabIndex = 5;
            this.buttonEditComputer.Text = "Редактировать";
            this.buttonEditComputer.UseVisualStyleBackColor = true;
            this.buttonEditComputer.Click += new System.EventHandler(this.buttonEditComputer_Click);
            // 
            // button_Comp_delete
            // 
            this.button_Comp_delete.Location = new System.Drawing.Point(449, 415);
            this.button_Comp_delete.Name = "button_Comp_delete";
            this.button_Comp_delete.Size = new System.Drawing.Size(75, 23);
            this.button_Comp_delete.TabIndex = 6;
            this.button_Comp_delete.Text = "Удалить";
            this.button_Comp_delete.UseVisualStyleBackColor = true;
            this.button_Comp_delete.Click += new System.EventHandler(this.button_Comp_delete_Click);
            // 
            // textBoxInventoryNumber
            // 
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(12, 342);
            this.textBoxInventoryNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(76, 20);
            this.textBoxInventoryNumber.TabIndex = 7;
            this.textBoxInventoryNumber.TextChanged += new System.EventHandler(this.textBoxInventoryNumber_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(92, 342);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStatus.TabIndex = 8;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(187, 342);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(92, 21);
            this.comboBoxEmployee.TabIndex = 9;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxCPU
            // 
            this.comboBoxCPU.FormattingEnabled = true;
            this.comboBoxCPU.Location = new System.Drawing.Point(282, 342);
            this.comboBoxCPU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCPU.Name = "comboBoxCPU";
            this.comboBoxCPU.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCPU.TabIndex = 11;
            this.comboBoxCPU.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxMotherBoard
            // 
            this.comboBoxMotherBoard.FormattingEnabled = true;
            this.comboBoxMotherBoard.Location = new System.Drawing.Point(377, 342);
            this.comboBoxMotherBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMotherBoard.Name = "comboBoxMotherBoard";
            this.comboBoxMotherBoard.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMotherBoard.TabIndex = 12;
            this.comboBoxMotherBoard.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxHDD
            // 
            this.comboBoxHDD.FormattingEnabled = true;
            this.comboBoxHDD.Location = new System.Drawing.Point(472, 342);
            this.comboBoxHDD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHDD.Name = "comboBoxHDD";
            this.comboBoxHDD.Size = new System.Drawing.Size(92, 21);
            this.comboBoxHDD.TabIndex = 13;
            this.comboBoxHDD.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // button_Comp_decomm
            // 
            this.button_Comp_decomm.Location = new System.Drawing.Point(368, 415);
            this.button_Comp_decomm.Name = "button_Comp_decomm";
            this.button_Comp_decomm.Size = new System.Drawing.Size(75, 23);
            this.button_Comp_decomm.TabIndex = 14;
            this.button_Comp_decomm.Text = "Списать";
            this.button_Comp_decomm.UseVisualStyleBackColor = true;
            this.button_Comp_decomm.Click += new System.EventHandler(this.button_Comp_decomm_Click);
            // 
            // FormComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Comp_decomm);
            this.Controls.Add(this.comboBoxHDD);
            this.Controls.Add(this.comboBoxMotherBoard);
            this.Controls.Add(this.comboBoxCPU);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxInventoryNumber);
            this.Controls.Add(this.button_Comp_delete);
            this.Controls.Add(this.buttonEditComputer);
            this.Controls.Add(this.buttonAddComputer);
            this.Controls.Add(this.buttonComputerExit);
            this.Controls.Add(this.dataGridViewComputer);
            this.Name = "FormComputers";
            this.Text = "Компьютеры";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComputer;
        private System.Windows.Forms.Button buttonAddComputer;
        private System.Windows.Forms.Button buttonComputerExit;
        private System.Windows.Forms.Button buttonEditComputer;
        private System.Windows.Forms.Button button_Comp_delete;
        private System.Windows.Forms.TextBox textBoxInventoryNumber;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxCPU;
        private System.Windows.Forms.ComboBox comboBoxMotherBoard;
        private System.Windows.Forms.ComboBox comboBoxHDD;
        private System.Windows.Forms.Button button_Comp_decomm;
    }
}