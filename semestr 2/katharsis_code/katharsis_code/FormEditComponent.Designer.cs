namespace katharsis_code
{
    partial class FormEditComponent
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
            this.buttonEditComponentSave = new System.Windows.Forms.Button();
            this.buttonEditComponentExit = new System.Windows.Forms.Button();
            this.comboBox_editComponent_manufacturer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_editComponent_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_editComponent_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditComponentSave
            // 
            this.buttonEditComponentSave.Location = new System.Drawing.Point(632, 415);
            this.buttonEditComponentSave.Name = "buttonEditComponentSave";
            this.buttonEditComponentSave.Size = new System.Drawing.Size(75, 23);
            this.buttonEditComponentSave.TabIndex = 9;
            this.buttonEditComponentSave.Text = "Сохранить";
            this.buttonEditComponentSave.UseVisualStyleBackColor = true;
            this.buttonEditComponentSave.Click += new System.EventHandler(this.buttonEditComponentSave_Click);
            // 
            // buttonEditComponentExit
            // 
            this.buttonEditComponentExit.Location = new System.Drawing.Point(713, 415);
            this.buttonEditComponentExit.Name = "buttonEditComponentExit";
            this.buttonEditComponentExit.Size = new System.Drawing.Size(75, 23);
            this.buttonEditComponentExit.TabIndex = 8;
            this.buttonEditComponentExit.Text = "Выход";
            this.buttonEditComponentExit.UseVisualStyleBackColor = true;
            this.buttonEditComponentExit.Click += new System.EventHandler(this.buttonEditComponentExit_Click);
            // 
            // comboBox_editComponent_manufacturer
            // 
            this.comboBox_editComponent_manufacturer.FormattingEnabled = true;
            this.comboBox_editComponent_manufacturer.Location = new System.Drawing.Point(15, 149);
            this.comboBox_editComponent_manufacturer.Name = "comboBox_editComponent_manufacturer";
            this.comboBox_editComponent_manufacturer.Size = new System.Drawing.Size(191, 21);
            this.comboBox_editComponent_manufacturer.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Производитель";
            // 
            // comboBox_editComponent_type
            // 
            this.comboBox_editComponent_type.FormattingEnabled = true;
            this.comboBox_editComponent_type.Location = new System.Drawing.Point(15, 86);
            this.comboBox_editComponent_type.Name = "comboBox_editComponent_type";
            this.comboBox_editComponent_type.Size = new System.Drawing.Size(191, 21);
            this.comboBox_editComponent_type.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Наименование";
            // 
            // textBox_editComponent_Name
            // 
            this.textBox_editComponent_Name.Location = new System.Drawing.Point(12, 33);
            this.textBox_editComponent_Name.Name = "textBox_editComponent_Name";
            this.textBox_editComponent_Name.Size = new System.Drawing.Size(194, 20);
            this.textBox_editComponent_Name.TabIndex = 16;
            // 
            // FormEditComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_editComponent_manufacturer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_editComponent_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_editComponent_Name);
            this.Controls.Add(this.buttonEditComponentSave);
            this.Controls.Add(this.buttonEditComponentExit);
            this.Name = "FormEditComponent";
            this.Text = "Редактировать компоненту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditComponentSave;
        private System.Windows.Forms.Button buttonEditComponentExit;
        private System.Windows.Forms.ComboBox comboBox_editComponent_manufacturer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_editComponent_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_editComponent_Name;
    }
}