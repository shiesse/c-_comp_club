namespace katharsis_code
{
    partial class FormAddManufacturer
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
            this.buttonAddManufacturerSave = new System.Windows.Forms.Button();
            this.buttonAddManufacturerExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_addManufacturer_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddManufacturerSave
            // 
            this.buttonAddManufacturerSave.Location = new System.Drawing.Point(637, 415);
            this.buttonAddManufacturerSave.Name = "buttonAddManufacturerSave";
            this.buttonAddManufacturerSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAddManufacturerSave.TabIndex = 6;
            this.buttonAddManufacturerSave.Text = "Сохранить";
            this.buttonAddManufacturerSave.UseVisualStyleBackColor = true;
            this.buttonAddManufacturerSave.Click += new System.EventHandler(this.buttonAddManufacturerSave_Click);
            // 
            // buttonAddManufacturerExit
            // 
            this.buttonAddManufacturerExit.Location = new System.Drawing.Point(713, 415);
            this.buttonAddManufacturerExit.Name = "buttonAddManufacturerExit";
            this.buttonAddManufacturerExit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddManufacturerExit.TabIndex = 7;
            this.buttonAddManufacturerExit.Text = "Выход";
            this.buttonAddManufacturerExit.UseVisualStyleBackColor = true;
            this.buttonAddManufacturerExit.Click += new System.EventHandler(this.buttonAddManufacturerExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование";
            // 
            // textBox_addManufacturer_Name
            // 
            this.textBox_addManufacturer_Name.Location = new System.Drawing.Point(12, 26);
            this.textBox_addManufacturer_Name.Name = "textBox_addManufacturer_Name";
            this.textBox_addManufacturer_Name.Size = new System.Drawing.Size(194, 20);
            this.textBox_addManufacturer_Name.TabIndex = 8;
            // 
            // FormAddManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_addManufacturer_Name);
            this.Controls.Add(this.buttonAddManufacturerExit);
            this.Controls.Add(this.buttonAddManufacturerSave);
            this.Name = "FormAddManufacturer";
            this.Text = "Добавить производителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddManufacturerSave;
        private System.Windows.Forms.Button buttonAddManufacturerExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_addManufacturer_Name;
    }
}