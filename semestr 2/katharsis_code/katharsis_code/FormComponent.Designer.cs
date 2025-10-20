
namespace katharsis_code
{
    partial class FormComponent
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
            this.buttonEditComponent = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.buttonComponentListExit = new System.Windows.Forms.Button();
            this.dataGridViewComponent = new System.Windows.Forms.DataGridView();
            this.buttonDeleteComponent = new System.Windows.Forms.Button();
            this.textBoxNameFilter = new System.Windows.Forms.TextBox();
            this.comboBoxComponentType = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxComputer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditComponent
            // 
            this.buttonEditComponent.Location = new System.Drawing.Point(711, 511);
            this.buttonEditComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditComponent.Name = "buttonEditComponent";
            this.buttonEditComponent.Size = new System.Drawing.Size(124, 28);
            this.buttonEditComponent.TabIndex = 7;
            this.buttonEditComponent.Text = "Редактировать";
            this.buttonEditComponent.UseVisualStyleBackColor = true;
            this.buttonEditComponent.Click += new System.EventHandler(this.buttonEditComponent_Click);
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(843, 511);
            this.buttonAddComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(100, 28);
            this.buttonAddComponent.TabIndex = 6;
            this.buttonAddComponent.Text = "Добавить";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.buttonAddComponent_Click);
            // 
            // buttonComponentListExit
            // 
            this.buttonComponentListExit.Location = new System.Drawing.Point(951, 511);
            this.buttonComponentListExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComponentListExit.Name = "buttonComponentListExit";
            this.buttonComponentListExit.Size = new System.Drawing.Size(100, 28);
            this.buttonComponentListExit.TabIndex = 5;
            this.buttonComponentListExit.Text = "Выход";
            this.buttonComponentListExit.UseVisualStyleBackColor = true;
            this.buttonComponentListExit.Click += new System.EventHandler(this.buttonComponentListExit_Click);
            // 
            // dataGridViewComponent
            // 
            this.dataGridViewComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponent.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewComponent.Name = "dataGridViewComponent";
            this.dataGridViewComponent.RowHeadersWidth = 51;
            this.dataGridViewComponent.Size = new System.Drawing.Size(1035, 383);
            this.dataGridViewComponent.TabIndex = 4;
            // 
            // buttonDeleteComponent
            // 
            this.buttonDeleteComponent.Location = new System.Drawing.Point(605, 511);
            this.buttonDeleteComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteComponent.Name = "buttonDeleteComponent";
            this.buttonDeleteComponent.Size = new System.Drawing.Size(97, 28);
            this.buttonDeleteComponent.TabIndex = 8;
            this.buttonDeleteComponent.Text = "Удалить";
            this.buttonDeleteComponent.UseVisualStyleBackColor = true;
            this.buttonDeleteComponent.Click += new System.EventHandler(this.buttonDeleteComponent_Click);
            // 
            // textBoxNameFilter
            // 
            this.textBoxNameFilter.Location = new System.Drawing.Point(16, 405);
            this.textBoxNameFilter.Name = "textBoxNameFilter";
            this.textBoxNameFilter.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameFilter.TabIndex = 9;
            this.textBoxNameFilter.TextChanged += new System.EventHandler(this.textBoxNameFilter_TextChanged);
            // 
            // comboBoxComponentType
            // 
            this.comboBoxComponentType.FormattingEnabled = true;
            this.comboBoxComponentType.Location = new System.Drawing.Point(122, 405);
            this.comboBoxComponentType.Name = "comboBoxComponentType";
            this.comboBoxComponentType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxComponentType.TabIndex = 10;
            this.comboBoxComponentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(249, 405);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxManufacturer.TabIndex = 11;
            this.comboBoxManufacturer.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxComputer
            // 
            this.comboBoxComputer.FormattingEnabled = true;
            this.comboBoxComputer.Location = new System.Drawing.Point(376, 405);
            this.comboBoxComputer.Name = "comboBoxComputer";
            this.comboBoxComputer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxComputer.TabIndex = 12;
            this.comboBoxComputer.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBoxComputer);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxComponentType);
            this.Controls.Add(this.textBoxNameFilter);
            this.Controls.Add(this.buttonDeleteComponent);
            this.Controls.Add(this.buttonEditComponent);
            this.Controls.Add(this.buttonAddComponent);
            this.Controls.Add(this.buttonComponentListExit);
            this.Controls.Add(this.dataGridViewComponent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComponent";
            this.Text = "Компоненты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditComponent;
        private System.Windows.Forms.Button buttonAddComponent;
        private System.Windows.Forms.Button buttonComponentListExit;
        private System.Windows.Forms.DataGridView dataGridViewComponent;
        private System.Windows.Forms.Button buttonDeleteComponent;
        private System.Windows.Forms.TextBox textBoxNameFilter;
        private System.Windows.Forms.ComboBox comboBoxComponentType;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.ComboBox comboBoxComputer;
    }
}