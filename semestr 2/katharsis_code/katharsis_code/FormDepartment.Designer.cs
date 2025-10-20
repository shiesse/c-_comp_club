namespace katharsis_code
{
    partial class FormDepartment
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
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.buttonCloseDepartment = new System.Windows.Forms.Button();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.buttonEditDepartment = new System.Windows.Forms.Button();
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(3, 1);
            this.dataGridViewDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowHeadersWidth = 51;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(1063, 447);
            this.dataGridViewDepartment.TabIndex = 0;
            // 
            // buttonCloseDepartment
            // 
            this.buttonCloseDepartment.Location = new System.Drawing.Point(947, 519);
            this.buttonCloseDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseDepartment.Name = "buttonCloseDepartment";
            this.buttonCloseDepartment.Size = new System.Drawing.Size(108, 32);
            this.buttonCloseDepartment.TabIndex = 1;
            this.buttonCloseDepartment.Text = "Закрыть";
            this.buttonCloseDepartment.UseVisualStyleBackColor = true;
            this.buttonCloseDepartment.Click += new System.EventHandler(this.buttonCloseDepartment_Click);
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(833, 519);
            this.buttonAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(108, 32);
            this.buttonAddDepartment.TabIndex = 2;
            this.buttonAddDepartment.Text = "Добавить";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // buttonEditDepartment
            // 
            this.buttonEditDepartment.Location = new System.Drawing.Point(701, 519);
            this.buttonEditDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditDepartment.Name = "buttonEditDepartment";
            this.buttonEditDepartment.Size = new System.Drawing.Size(127, 32);
            this.buttonEditDepartment.TabIndex = 3;
            this.buttonEditDepartment.Text = "Редактировать";
            this.buttonEditDepartment.UseVisualStyleBackColor = true;
            this.buttonEditDepartment.Click += new System.EventHandler(this.buttonEditDepartment_Click);
            // 
            // buttonDeleteDepartment
            // 
            this.buttonDeleteDepartment.Location = new System.Drawing.Point(589, 519);
            this.buttonDeleteDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(107, 32);
            this.buttonDeleteDepartment.TabIndex = 4;
            this.buttonDeleteDepartment.Text = "Удалить";
            this.buttonDeleteDepartment.UseVisualStyleBackColor = true;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(12, 455);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 558);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonDeleteDepartment);
            this.Controls.Add(this.buttonEditDepartment);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.buttonCloseDepartment);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDepartment";
            this.Text = "Отделы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Button buttonCloseDepartment;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Button buttonEditDepartment;
        private System.Windows.Forms.Button buttonDeleteDepartment;
        private System.Windows.Forms.TextBox textBoxFilter;
    }
}