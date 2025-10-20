namespace katharsis_code
{
    partial class FormAddDepartment
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
            this.labelFormAddDeparment = new System.Windows.Forms.Label();
            this.textBoxFormAddDepartment = new System.Windows.Forms.TextBox();
            this.buttonFormAddDepartment_Close = new System.Windows.Forms.Button();
            this.buttonFormAddDeparment_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFormAddDeparment
            // 
            this.labelFormAddDeparment.AutoSize = true;
            this.labelFormAddDeparment.Location = new System.Drawing.Point(9, 7);
            this.labelFormAddDeparment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormAddDeparment.Name = "labelFormAddDeparment";
            this.labelFormAddDeparment.Size = new System.Drawing.Size(89, 13);
            this.labelFormAddDeparment.TabIndex = 0;
            this.labelFormAddDeparment.Text = "Навание отдела";
            // 
            // textBoxFormAddDepartment
            // 
            this.textBoxFormAddDepartment.Location = new System.Drawing.Point(11, 23);
            this.textBoxFormAddDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFormAddDepartment.Name = "textBoxFormAddDepartment";
            this.textBoxFormAddDepartment.Size = new System.Drawing.Size(263, 20);
            this.textBoxFormAddDepartment.TabIndex = 1;
            // 
            // buttonFormAddDepartment_Close
            // 
            this.buttonFormAddDepartment_Close.Location = new System.Drawing.Point(197, 46);
            this.buttonFormAddDepartment_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFormAddDepartment_Close.Name = "buttonFormAddDepartment_Close";
            this.buttonFormAddDepartment_Close.Size = new System.Drawing.Size(76, 19);
            this.buttonFormAddDepartment_Close.TabIndex = 2;
            this.buttonFormAddDepartment_Close.Text = "Закрыть";
            this.buttonFormAddDepartment_Close.UseVisualStyleBackColor = true;
            this.buttonFormAddDepartment_Close.Click += new System.EventHandler(this.buttonFormAddDepartment_Close_Click);
            // 
            // buttonFormAddDeparment_Add
            // 
            this.buttonFormAddDeparment_Add.Location = new System.Drawing.Point(117, 46);
            this.buttonFormAddDeparment_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFormAddDeparment_Add.Name = "buttonFormAddDeparment_Add";
            this.buttonFormAddDeparment_Add.Size = new System.Drawing.Size(76, 19);
            this.buttonFormAddDeparment_Add.TabIndex = 3;
            this.buttonFormAddDeparment_Add.Text = "Добавить";
            this.buttonFormAddDeparment_Add.UseVisualStyleBackColor = true;
            this.buttonFormAddDeparment_Add.Click += new System.EventHandler(this.buttonFormAddDeparment_Add_Click);
            // 
            // FormAddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 88);
            this.Controls.Add(this.buttonFormAddDeparment_Add);
            this.Controls.Add(this.buttonFormAddDepartment_Close);
            this.Controls.Add(this.textBoxFormAddDepartment);
            this.Controls.Add(this.labelFormAddDeparment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddDepartment";
            this.Text = "Добавить отдел";
            this.Load += new System.EventHandler(this.FormAddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormAddDeparment;
        private System.Windows.Forms.TextBox textBoxFormAddDepartment;
        private System.Windows.Forms.Button buttonFormAddDepartment_Close;
        private System.Windows.Forms.Button buttonFormAddDeparment_Add;
    }
}