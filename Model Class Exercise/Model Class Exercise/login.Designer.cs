namespace Model_Class_Exercise
{
    partial class login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_maintxt = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.checkbox_show = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Model_Class_Exercise.Properties.Resources._360_F_119115529_mEnw3lGpLdlDkfLgRcVSbFRuVl6sMDty;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_maintxt
            // 
            this.lbl_maintxt.AutoSize = true;
            this.lbl_maintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_maintxt.Location = new System.Drawing.Point(271, 111);
            this.lbl_maintxt.Name = "lbl_maintxt";
            this.lbl_maintxt.Size = new System.Drawing.Size(145, 31);
            this.lbl_maintxt.TabIndex = 1;
            this.lbl_maintxt.Text = "User Login";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(277, 322);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_user.Location = new System.Drawing.Point(269, 162);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(181, 35);
            this.txt_user.TabIndex = 3;
            this.txt_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_password.Location = new System.Drawing.Point(269, 218);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(181, 35);
            this.txt_password.TabIndex = 4;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_user.Location = new System.Drawing.Point(129, 171);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(123, 26);
            this.lbl_user.TabIndex = 5;
            this.lbl_user.Text = "User Name";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_pass.Location = new System.Drawing.Point(129, 227);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(108, 26);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Password";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(461, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // checkbox_show
            // 
            this.checkbox_show.AutoSize = true;
            this.checkbox_show.Location = new System.Drawing.Point(442, 271);
            this.checkbox_show.Name = "checkbox_show";
            this.checkbox_show.Size = new System.Drawing.Size(101, 17);
            this.checkbox_show.TabIndex = 9;
            this.checkbox_show.Text = "Show password";
            this.checkbox_show.UseVisualStyleBackColor = true;
            this.checkbox_show.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkbox_show);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_maintxt);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_maintxt;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox checkbox_show;
    }
}