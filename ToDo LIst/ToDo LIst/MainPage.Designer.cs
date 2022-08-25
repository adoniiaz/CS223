namespace ToDo_LIst
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crudToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crudToolStripMenuItem
            // 
            this.crudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewToolStripMenuItem,
            this.updateExistingToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.crudToolStripMenuItem.Name = "crudToolStripMenuItem";
            this.crudToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.crudToolStripMenuItem.Text = "crud";
            // 
            // insertNewToolStripMenuItem
            // 
            this.insertNewToolStripMenuItem.Name = "insertNewToolStripMenuItem";
            this.insertNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertNewToolStripMenuItem.Text = "Insert new";
            this.insertNewToolStripMenuItem.Click += new System.EventHandler(this.insertNewToolStripMenuItem_Click);
            // 
            // updateExistingToolStripMenuItem
            // 
            this.updateExistingToolStripMenuItem.Name = "updateExistingToolStripMenuItem";
            this.updateExistingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateExistingToolStripMenuItem.Text = "Display";
            this.updateExistingToolStripMenuItem.Click += new System.EventHandler(this.updateExistingToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}