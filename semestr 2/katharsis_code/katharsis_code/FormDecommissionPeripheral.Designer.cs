namespace katharsis_code
{
    partial class FormDecommissionPeripheral
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
            this.comboBox_repsonPerson3 = new System.Windows.Forms.ComboBox();
            this.comboBox_repsonPerson1 = new System.Windows.Forms.ComboBox();
            this.comboBox_repsonPerson2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_decommissionPeriphAgree = new System.Windows.Forms.Button();
            this.button_deccommissionPeriphExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_repsonPerson3
            // 
            this.comboBox_repsonPerson3.FormattingEnabled = true;
            this.comboBox_repsonPerson3.Location = new System.Drawing.Point(12, 178);
            this.comboBox_repsonPerson3.Name = "comboBox_repsonPerson3";
            this.comboBox_repsonPerson3.Size = new System.Drawing.Size(253, 21);
            this.comboBox_repsonPerson3.TabIndex = 0;
            // 
            // comboBox_repsonPerson1
            // 
            this.comboBox_repsonPerson1.FormattingEnabled = true;
            this.comboBox_repsonPerson1.Location = new System.Drawing.Point(12, 74);
            this.comboBox_repsonPerson1.Name = "comboBox_repsonPerson1";
            this.comboBox_repsonPerson1.Size = new System.Drawing.Size(253, 21);
            this.comboBox_repsonPerson1.TabIndex = 1;
            // 
            // comboBox_repsonPerson2
            // 
            this.comboBox_repsonPerson2.FormattingEnabled = true;
            this.comboBox_repsonPerson2.Location = new System.Drawing.Point(12, 124);
            this.comboBox_repsonPerson2.Name = "comboBox_repsonPerson2";
            this.comboBox_repsonPerson2.Size = new System.Drawing.Size(253, 21);
            this.comboBox_repsonPerson2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберете трех ответственных лиц \r\nдля списания периферии";
            // 
            // button_decommissionPeriphAgree
            // 
            this.button_decommissionPeriphAgree.Location = new System.Drawing.Point(120, 254);
            this.button_decommissionPeriphAgree.Name = "button_decommissionPeriphAgree";
            this.button_decommissionPeriphAgree.Size = new System.Drawing.Size(75, 23);
            this.button_decommissionPeriphAgree.TabIndex = 4;
            this.button_decommissionPeriphAgree.Text = "Списать";
            this.button_decommissionPeriphAgree.UseVisualStyleBackColor = true;
            this.button_decommissionPeriphAgree.Click += new System.EventHandler(this.button_decommissionPeriphAgree_Click);
            // 
            // button_deccommissionPeriphExit
            // 
            this.button_deccommissionPeriphExit.Location = new System.Drawing.Point(201, 254);
            this.button_deccommissionPeriphExit.Name = "button_deccommissionPeriphExit";
            this.button_deccommissionPeriphExit.Size = new System.Drawing.Size(75, 23);
            this.button_deccommissionPeriphExit.TabIndex = 5;
            this.button_deccommissionPeriphExit.Text = "Отмена";
            this.button_deccommissionPeriphExit.UseVisualStyleBackColor = true;
            this.button_deccommissionPeriphExit.Click += new System.EventHandler(this.button_deccommissionPeriphExit_Click);
            // 
            // FormDecommissionPeripheral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 289);
            this.Controls.Add(this.button_deccommissionPeriphExit);
            this.Controls.Add(this.button_decommissionPeriphAgree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_repsonPerson2);
            this.Controls.Add(this.comboBox_repsonPerson1);
            this.Controls.Add(this.comboBox_repsonPerson3);
            this.Name = "FormDecommissionPeripheral";
            this.Text = "Списание периферии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_repsonPerson3;
        private System.Windows.Forms.ComboBox comboBox_repsonPerson1;
        private System.Windows.Forms.ComboBox comboBox_repsonPerson2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_decommissionPeriphAgree;
        private System.Windows.Forms.Button button_deccommissionPeriphExit;
    }
}