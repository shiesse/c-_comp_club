namespace katharsis_code
{
    partial class FormManufacturer
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
            this.dataGridViewManufacturer = new System.Windows.Forms.DataGridView();
            this.buttonAddManufacturer = new System.Windows.Forms.Button();
            this.buttonManufacturerListExit = new System.Windows.Forms.Button();
            this.buttonEditManufacturer = new System.Windows.Forms.Button();
            this.buttonDeleteManufacturer = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManufacturer
            // 
            this.dataGridViewManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturer.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewManufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewManufacturer.Name = "dataGridViewManufacturer";
            this.dataGridViewManufacturer.RowHeadersWidth = 51;
            this.dataGridViewManufacturer.Size = new System.Drawing.Size(1035, 394);
            this.dataGridViewManufacturer.TabIndex = 0;
            // 
            // buttonAddManufacturer
            // 
            this.buttonAddManufacturer.Location = new System.Drawing.Point(843, 511);
            this.buttonAddManufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddManufacturer.Name = "buttonAddManufacturer";
            this.buttonAddManufacturer.Size = new System.Drawing.Size(100, 28);
            this.buttonAddManufacturer.TabIndex = 4;
            this.buttonAddManufacturer.Text = "Добавить";
            this.buttonAddManufacturer.UseVisualStyleBackColor = true;
            this.buttonAddManufacturer.Click += new System.EventHandler(this.buttonAddManufacturer_Click);
            // 
            // buttonManufacturerListExit
            // 
            this.buttonManufacturerListExit.Location = new System.Drawing.Point(951, 511);
            this.buttonManufacturerListExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonManufacturerListExit.Name = "buttonManufacturerListExit";
            this.buttonManufacturerListExit.Size = new System.Drawing.Size(100, 28);
            this.buttonManufacturerListExit.TabIndex = 3;
            this.buttonManufacturerListExit.Text = "Выход";
            this.buttonManufacturerListExit.UseVisualStyleBackColor = true;
            this.buttonManufacturerListExit.Click += new System.EventHandler(this.buttonManufacturerListExit_Click);
            // 
            // buttonEditManufacturer
            // 
            this.buttonEditManufacturer.Location = new System.Drawing.Point(711, 511);
            this.buttonEditManufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditManufacturer.Name = "buttonEditManufacturer";
            this.buttonEditManufacturer.Size = new System.Drawing.Size(124, 28);
            this.buttonEditManufacturer.TabIndex = 5;
            this.buttonEditManufacturer.Text = "Редактировать";
            this.buttonEditManufacturer.UseVisualStyleBackColor = true;
            this.buttonEditManufacturer.Click += new System.EventHandler(this.buttonEditManufacturer_Click);
            // 
            // buttonDeleteManufacturer
            // 
            this.buttonDeleteManufacturer.Location = new System.Drawing.Point(596, 511);
            this.buttonDeleteManufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteManufacturer.Name = "buttonDeleteManufacturer";
            this.buttonDeleteManufacturer.Size = new System.Drawing.Size(107, 28);
            this.buttonDeleteManufacturer.TabIndex = 6;
            this.buttonDeleteManufacturer.Text = "Удалить";
            this.buttonDeleteManufacturer.UseVisualStyleBackColor = true;
            this.buttonDeleteManufacturer.Click += new System.EventHandler(this.buttonDeleteManufacturer_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(16, 416);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilter.TabIndex = 7;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // FormManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonDeleteManufacturer);
            this.Controls.Add(this.buttonEditManufacturer);
            this.Controls.Add(this.buttonAddManufacturer);
            this.Controls.Add(this.buttonManufacturerListExit);
            this.Controls.Add(this.dataGridViewManufacturer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormManufacturer";
            this.Text = "Производитель";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManufacturer;
        private System.Windows.Forms.Button buttonAddManufacturer;
        private System.Windows.Forms.Button buttonManufacturerListExit;
        private System.Windows.Forms.Button buttonEditManufacturer;
        private System.Windows.Forms.Button buttonDeleteManufacturer;
        private System.Windows.Forms.TextBox textBoxFilter;
    }
}