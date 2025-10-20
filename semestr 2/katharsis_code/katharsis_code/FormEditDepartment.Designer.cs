namespace katharsis_code.Models
{
    partial class FormEditDepartment
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
            this.buttonEditDepartmentExit = new System.Windows.Forms.Button();
            this.buttonEditDepartmentSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_editDepartment_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditDepartmentExit
            // 
            this.buttonEditDepartmentExit.Location = new System.Drawing.Point(713, 415);
            this.buttonEditDepartmentExit.Name = "buttonEditDepartmentExit";
            this.buttonEditDepartmentExit.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDepartmentExit.TabIndex = 17;
            this.buttonEditDepartmentExit.Text = "Выход";
            this.buttonEditDepartmentExit.UseVisualStyleBackColor = true;
            this.buttonEditDepartmentExit.Click += new System.EventHandler(this.buttonEditDepartmentExit_Click);
            // 
            // buttonEditDepartmentSave
            // 
            this.buttonEditDepartmentSave.Location = new System.Drawing.Point(637, 415);
            this.buttonEditDepartmentSave.Name = "buttonEditDepartmentSave";
            this.buttonEditDepartmentSave.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDepartmentSave.TabIndex = 16;
            this.buttonEditDepartmentSave.Text = "Сохранить";
            this.buttonEditDepartmentSave.UseVisualStyleBackColor = true;
            this.buttonEditDepartmentSave.Click += new System.EventHandler(this.buttonEditDepartmentSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // textBox_editDepartment_Name
            // 
            this.textBox_editDepartment_Name.Location = new System.Drawing.Point(12, 29);
            this.textBox_editDepartment_Name.Name = "textBox_editDepartment_Name";
            this.textBox_editDepartment_Name.Size = new System.Drawing.Size(194, 20);
            this.textBox_editDepartment_Name.TabIndex = 14;
            // 
            // FormEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditDepartmentExit);
            this.Controls.Add(this.buttonEditDepartmentSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_editDepartment_Name);
            this.Name = "FormEditDepartment";
            this.Text = "Редактировать отдел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditDepartmentExit;
        private System.Windows.Forms.Button buttonEditDepartmentSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_editDepartment_Name;
    }
}