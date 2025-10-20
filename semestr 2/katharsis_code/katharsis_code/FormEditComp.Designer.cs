
namespace katharsis_code
{
	partial class FormEditComp
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
            this.comboBox_EditComputer_Employee = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_EditComputer_HDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_EditComputer_Motherboard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_EditComputer_CPU = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEditComputerSave = new System.Windows.Forms.Button();
            this.buttonEditComputerExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EditComputer_InvNum = new System.Windows.Forms.TextBox();
            this.comboBox_EditComp_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_EditComputer_Employee
            // 
            this.comboBox_EditComputer_Employee.FormattingEnabled = true;
            this.comboBox_EditComputer_Employee.Location = new System.Drawing.Point(12, 131);
            this.comboBox_EditComputer_Employee.Name = "comboBox_EditComputer_Employee";
            this.comboBox_EditComputer_Employee.Size = new System.Drawing.Size(191, 21);
            this.comboBox_EditComputer_Employee.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ответственный";
            // 
            // comboBox_EditComputer_HDD
            // 
            this.comboBox_EditComputer_HDD.FormattingEnabled = true;
            this.comboBox_EditComputer_HDD.Location = new System.Drawing.Point(11, 334);
            this.comboBox_EditComputer_HDD.Name = "comboBox_EditComputer_HDD";
            this.comboBox_EditComputer_HDD.Size = new System.Drawing.Size(191, 21);
            this.comboBox_EditComputer_HDD.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Жесткий диск";
            // 
            // comboBox_EditComputer_Motherboard
            // 
            this.comboBox_EditComputer_Motherboard.FormattingEnabled = true;
            this.comboBox_EditComputer_Motherboard.Location = new System.Drawing.Point(11, 265);
            this.comboBox_EditComputer_Motherboard.Name = "comboBox_EditComputer_Motherboard";
            this.comboBox_EditComputer_Motherboard.Size = new System.Drawing.Size(191, 21);
            this.comboBox_EditComputer_Motherboard.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Материнская плата";
            // 
            // comboBox_EditComputer_CPU
            // 
            this.comboBox_EditComputer_CPU.FormattingEnabled = true;
            this.comboBox_EditComputer_CPU.Location = new System.Drawing.Point(11, 199);
            this.comboBox_EditComputer_CPU.Name = "comboBox_EditComputer_CPU";
            this.comboBox_EditComputer_CPU.Size = new System.Drawing.Size(191, 21);
            this.comboBox_EditComputer_CPU.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Процессор";
            // 
            // buttonEditComputerSave
            // 
            this.buttonEditComputerSave.Location = new System.Drawing.Point(46, 403);
            this.buttonEditComputerSave.Name = "buttonEditComputerSave";
            this.buttonEditComputerSave.Size = new System.Drawing.Size(75, 23);
            this.buttonEditComputerSave.TabIndex = 25;
            this.buttonEditComputerSave.Text = "Сохранить";
            this.buttonEditComputerSave.UseVisualStyleBackColor = true;
            this.buttonEditComputerSave.Click += new System.EventHandler(this.buttonEditComputerSave_Click);
            // 
            // buttonEditComputerExit
            // 
            this.buttonEditComputerExit.Location = new System.Drawing.Point(127, 403);
            this.buttonEditComputerExit.Name = "buttonEditComputerExit";
            this.buttonEditComputerExit.Size = new System.Drawing.Size(75, 23);
            this.buttonEditComputerExit.TabIndex = 24;
            this.buttonEditComputerExit.Text = "Выход";
            this.buttonEditComputerExit.UseVisualStyleBackColor = true;
            this.buttonEditComputerExit.Click += new System.EventHandler(this.buttonEditComputerExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Инвентарный номер";
            // 
            // textBox_EditComputer_InvNum
            // 
            this.textBox_EditComputer_InvNum.Location = new System.Drawing.Point(12, 29);
            this.textBox_EditComputer_InvNum.Name = "textBox_EditComputer_InvNum";
            this.textBox_EditComputer_InvNum.Size = new System.Drawing.Size(194, 20);
            this.textBox_EditComputer_InvNum.TabIndex = 22;
            // 
            // comboBox_EditComp_status
            // 
            this.comboBox_EditComp_status.FormattingEnabled = true;
            this.comboBox_EditComp_status.Location = new System.Drawing.Point(15, 79);
            this.comboBox_EditComp_status.Name = "comboBox_EditComp_status";
            this.comboBox_EditComp_status.Size = new System.Drawing.Size(191, 21);
            this.comboBox_EditComp_status.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Статус";
            // 
            // FormEditComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 450);
            this.Controls.Add(this.comboBox_EditComp_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_EditComputer_Employee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_EditComputer_HDD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_EditComputer_Motherboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_EditComputer_CPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEditComputerSave);
            this.Controls.Add(this.buttonEditComputerExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_EditComputer_InvNum);
            this.Name = "FormEditComp";
            this.Text = "Редактирование компьютера";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_EditComputer_Employee;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox_EditComputer_HDD;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox_EditComputer_Motherboard;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox_EditComputer_CPU;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonEditComputerSave;
		private System.Windows.Forms.Button buttonEditComputerExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_EditComputer_InvNum;
		private System.Windows.Forms.ComboBox comboBox_EditComp_status;
		private System.Windows.Forms.Label label2;
	}
}