
namespace katharsis_code
{
    partial class FormEditManufacturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_editManufacturer_Name = new System.Windows.Forms.TextBox();
            this.buttonEditManufacturerExit = new System.Windows.Forms.Button();
            this.buttonEditManufacturerSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Наименование";
            // 
            // textBox_editManufacturer_Name
            // 
            this.textBox_editManufacturer_Name.Location = new System.Drawing.Point(12, 29);
            this.textBox_editManufacturer_Name.Name = "textBox_editManufacturer_Name";
            this.textBox_editManufacturer_Name.Size = new System.Drawing.Size(194, 20);
            this.textBox_editManufacturer_Name.TabIndex = 10;
            // 
            // buttonEditManufacturerExit
            // 
            this.buttonEditManufacturerExit.Location = new System.Drawing.Point(713, 415);
            this.buttonEditManufacturerExit.Name = "buttonEditManufacturerExit";
            this.buttonEditManufacturerExit.Size = new System.Drawing.Size(75, 23);
            this.buttonEditManufacturerExit.TabIndex = 13;
            this.buttonEditManufacturerExit.Text = "Выход";
            this.buttonEditManufacturerExit.UseVisualStyleBackColor = true;
            this.buttonEditManufacturerExit.Click += new System.EventHandler(this.buttonEditManufacturerExit_Click);
            // 
            // buttonEditManufacturerSave
            // 
            this.buttonEditManufacturerSave.Location = new System.Drawing.Point(637, 415);
            this.buttonEditManufacturerSave.Name = "buttonEditManufacturerSave";
            this.buttonEditManufacturerSave.Size = new System.Drawing.Size(75, 23);
            this.buttonEditManufacturerSave.TabIndex = 12;
            this.buttonEditManufacturerSave.Text = "Сохранить";
            this.buttonEditManufacturerSave.UseVisualStyleBackColor = true;
            this.buttonEditManufacturerSave.Click += new System.EventHandler(this.buttonEditManufacturerSave_Click);
            // 
            // FormEditManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditManufacturerExit);
            this.Controls.Add(this.buttonEditManufacturerSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_editManufacturer_Name);
            this.Name = "FormEditManufacturer";
            this.Text = "Редактировать производителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_editManufacturer_Name;
        private System.Windows.Forms.Button buttonEditManufacturerExit;
        private System.Windows.Forms.Button buttonEditManufacturerSave;
    }
}