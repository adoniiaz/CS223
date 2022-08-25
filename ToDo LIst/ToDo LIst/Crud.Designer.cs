namespace ToDo_LIst
{
    partial class Crud
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_action = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_action = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(228, 89);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(142, 20);
            this.txt_username.TabIndex = 0;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_username.Location = new System.Drawing.Point(86, 89);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(102, 25);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_action.Location = new System.Drawing.Point(125, 342);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(67, 25);
            this.lbl_action.TabIndex = 2;
            this.lbl_action.Text = "Action";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Password.Location = new System.Drawing.Point(94, 283);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(98, 25);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_lname.Location = new System.Drawing.Point(86, 218);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(106, 25);
            this.lbl_lname.TabIndex = 4;
            this.lbl_lname.Text = "Last Name";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_fname.Location = new System.Drawing.Point(86, 154);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(106, 25);
            this.lbl_fname.TabIndex = 5;
            this.lbl_fname.Text = "First Name";
            // 
            // txt_action
            // 
            this.txt_action.Location = new System.Drawing.Point(228, 347);
            this.txt_action.Name = "txt_action";
            this.txt_action.Size = new System.Drawing.Size(142, 20);
            this.txt_action.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(228, 283);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(142, 20);
            this.txt_password.TabIndex = 7;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(228, 218);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(142, 20);
            this.txt_lname.TabIndex = 8;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(228, 154);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(142, 20);
            this.txt_fname.TabIndex = 9;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(228, 406);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(497, 406);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(363, 406);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(627, 406);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 23);
            this.btn_Display.TabIndex = 13;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_action);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_action);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Name = "Crud";
            this.Text = "Crud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_action;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Display;
    }
}