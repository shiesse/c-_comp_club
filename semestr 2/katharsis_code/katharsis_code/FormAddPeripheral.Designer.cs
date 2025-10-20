
namespace katharsis_code
{
    partial class FormAddPeripheral
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
            this.textBox_addPeripheral_InvNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_addPeripheral_type = new System.Windows.Forms.ComboBox();
            this.buttonAddPeripheralSave = new System.Windows.Forms.Button();
            this.buttonAddPeripheralExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_addPeripheral_manufacturer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_addPeripheral_InvNum
            // 
            this.textBox_addPeripheral_InvNum.Location = new System.Drawing.Point(12, 29);
            this.textBox_addPeripheral_InvNum.Name = "textBox_addPeripheral_InvNum";
            this.textBox_addPeripheral_InvNum.Size = new System.Drawing.Size(194, 20);
            this.textBox_addPeripheral_InvNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Инвентарный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип";
            // 
            // comboBox_addPeripheral_type
            // 
            this.comboBox_addPeripheral_type.FormattingEnabled = true;
            this.comboBox_addPeripheral_type.Location = new System.Drawing.Point(15, 82);
            this.comboBox_addPeripheral_type.Name = "comboBox_addPeripheral_type";
            this.comboBox_addPeripheral_type.Size = new System.Drawing.Size(191, 21);
            this.comboBox_addPeripheral_type.TabIndex = 3;
            // 
            // buttonAddPeripheralSave
            // 
            this.buttonAddPeripheralSave.Location = new System.Drawing.Point(637, 415);
            this.buttonAddPeripheralSave.Name = "buttonAddPeripheralSave";
            this.buttonAddPeripheralSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPeripheralSave.TabIndex = 5;
            this.buttonAddPeripheralSave.Text = "Сохранить";
            this.buttonAddPeripheralSave.UseVisualStyleBackColor = true;
            this.buttonAddPeripheralSave.Click += new System.EventHandler(this.buttonAddPeripheralSave_Click);
            // 
            // buttonAddPeripheralExit
            // 
            this.buttonAddPeripheralExit.Location = new System.Drawing.Point(718, 415);
            this.buttonAddPeripheralExit.Name = "buttonAddPeripheralExit";
            this.buttonAddPeripheralExit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPeripheralExit.TabIndex = 4;
            this.buttonAddPeripheralExit.Text = "Выход";
            this.buttonAddPeripheralExit.UseVisualStyleBackColor = true;
            this.buttonAddPeripheralExit.Click += new System.EventHandler(this.buttonAddPeripheralExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Производитель";
            // 
            // comboBox_addPeripheral_manufacturer
            // 
            this.comboBox_addPeripheral_manufacturer.FormattingEnabled = true;
            this.comboBox_addPeripheral_manufacturer.Location = new System.Drawing.Point(15, 145);
            this.comboBox_addPeripheral_manufacturer.Name = "comboBox_addPeripheral_manufacturer";
            this.comboBox_addPeripheral_manufacturer.Size = new System.Drawing.Size(191, 21);
            this.comboBox_addPeripheral_manufacturer.TabIndex = 7;
            // 
            // FormAddPeripheral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_addPeripheral_manufacturer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddPeripheralSave);
            this.Controls.Add(this.buttonAddPeripheralExit);
            this.Controls.Add(this.comboBox_addPeripheral_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_addPeripheral_InvNum);
            this.Name = "FormAddPeripheral";
            this.Text = "Добавить периферию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_addPeripheral_InvNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_addPeripheral_type;
        private System.Windows.Forms.Button buttonAddPeripheralSave;
        private System.Windows.Forms.Button buttonAddPeripheralExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_addPeripheral_manufacturer;
    }
}