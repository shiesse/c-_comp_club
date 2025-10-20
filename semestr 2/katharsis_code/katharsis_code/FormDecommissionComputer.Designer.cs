namespace katharsis_code
{
    partial class FormDecommissionComputer
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
            this.button_deccommissionCompExit = new System.Windows.Forms.Button();
            this.button_decommissionCompAgree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_repsonPerson2 = new System.Windows.Forms.ComboBox();
            this.comboBox_repsonPerson1 = new System.Windows.Forms.ComboBox();
            this.comboBox_repsonPerson3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_deccommissionCompExit
            // 
            this.button_deccommissionCompExit.Location = new System.Drawing.Point(212, 255);
            this.button_deccommissionCompExit.Name = "button_deccommissionCompExit";
            this.button_deccommissionCompExit.Size = new System.Drawing.Size(75, 23);
            this.button_deccommissionCompExit.TabIndex = 11;
            this.button_deccommissionCompExit.Text = "Отмена";
            this.button_deccommissionCompExit.UseVisualStyleBackColor = true;
            this.button_deccommissionCompExit.Click += new System.EventHandler(this.button_deccommissionCompExit_Click);
            // 
            // button_decommissionCompAgree
            // 
            this.button_decommissionCompAgree.Location = new System.Drawing.Point(131, 255);
            this.button_decommissionCompAgree.Name = "button_decommissionCompAgree";
            this.button_decommissionCompAgree.Size = new System.Drawing.Size(75, 23);
            this.button_decommissionCompAgree.TabIndex = 10;
            this.button_decommissionCompAgree.Text = "Списать";
            this.button_decommissionCompAgree.UseVisualStyleBackColor = true;
            this.button_decommissionCompAgree.Click += new System.EventHandler(this.button_decommissionCompAgree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберете трех ответственных лиц \r\nдля списания компьютера";
            // 
            // comboBox_repsonPerson2
            // 
            this.comboBox_repsonPerson2.FormattingEnabled = true;
            this.comboBox_repsonPerson2.Location = new System.Drawing.Point(23, 125);
            this.comboBox_repsonPerson2.Name = "comboBox_repsonPerson2";
            this.comboBox_repsonPerson2.Size = new System.Drawing.Size(253, 21);
            this.comboBox_repsonPerson2.TabIndex = 8;
            // 
            // comboBox_repsonPerson1
            // 
            this.comboBox_repsonPerson1.FormattingEnabled = true;
            this.comboBox_repsonPerson1.Location = new System.Drawing.Point(23, 75);
            this.comboBox_repsonPerson1.Name = "comboBox_repsonPerson1";
            this.comboBox_repsonPerson1.Size = new System.Drawing.Size(253, 21);
            this.comboBox_repsonPerson1.TabIndex = 7;
            // 
            // comboBox_repsonPerson3
            // 
            this.comboBox_repsonPerson3.FormattingEnabled = true;
            this.comboBox_repsonPerson3.Location = new System.Drawing.Point(23, 179);
            this.comboBox_repsonPerson3.Name = "comboBox_repsonPerson3";
            this.comboBox_repsonPerson3.Size = new System.Drawing.Size(253, 21);
            this.comboBox_repsonPerson3.TabIndex = 6;
            // 
            // FormDecommissionComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 301);
            this.Controls.Add(this.button_deccommissionCompExit);
            this.Controls.Add(this.button_decommissionCompAgree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_repsonPerson2);
            this.Controls.Add(this.comboBox_repsonPerson1);
            this.Controls.Add(this.comboBox_repsonPerson3);
            this.Name = "FormDecommissionComputer";
            this.Text = "Списание компьютера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_deccommissionCompExit;
        private System.Windows.Forms.Button button_decommissionCompAgree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_repsonPerson2;
        private System.Windows.Forms.ComboBox comboBox_repsonPerson1;
        private System.Windows.Forms.ComboBox comboBox_repsonPerson3;
    }
}