namespace Model_Class_Exercise
{
    partial class Panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_add = new System.Windows.Forms.Label();
            this.lbl_edit = new System.Windows.Forms.Label();
            this.lbl_display = new System.Windows.Forms.Label();
            this.indicator = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(228, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 398);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.indicator);
            this.panel2.Controls.Add(this.lbl_display);
            this.panel2.Controls.Add(this.lbl_edit);
            this.panel2.Controls.Add(this.lbl_add);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 398);
            this.panel2.TabIndex = 1;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_add.Location = new System.Drawing.Point(43, 60);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(54, 25);
            this.lbl_add.TabIndex = 0;
            this.lbl_add.Text = "ADD";
            this.lbl_add.Click += new System.EventHandler(this.lbl_add_Click);
            // 
            // lbl_edit
            // 
            this.lbl_edit.AutoSize = true;
            this.lbl_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_edit.Location = new System.Drawing.Point(43, 117);
            this.lbl_edit.Name = "lbl_edit";
            this.lbl_edit.Size = new System.Drawing.Size(45, 25);
            this.lbl_edit.TabIndex = 3;
            this.lbl_edit.Text = "Edit";
            this.lbl_edit.Click += new System.EventHandler(this.lbl_edit_Click);
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_display.Location = new System.Drawing.Point(43, 178);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(76, 25);
            this.lbl_display.TabIndex = 4;
            this.lbl_display.Text = "Display";
            this.lbl_display.Click += new System.EventHandler(this.lbl_display_Click);
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.indicator.Location = new System.Drawing.Point(27, 60);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 29);
            this.indicator.TabIndex = 0;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Panel";
            this.Text = "Panel";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Label lbl_edit;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Panel indicator;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}