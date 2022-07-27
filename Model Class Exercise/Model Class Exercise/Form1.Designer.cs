namespace Model_Class_Exercise
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_credit = new System.Windows.Forms.RadioButton();
            this.rb_paypal = new System.Windows.Forms.RadioButton();
            this.rb_delivery = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_variable = new System.Windows.Forms.RadioButton();
            this.rb_simple = new System.Windows.Forms.RadioButton();
            this.btn_checkbox = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.CheckedListBox();
            this.label_user = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_InventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_ItemId = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.Item_number = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_checkbox);
            this.groupBox1.Controls.Add(this.checkbox);
            this.groupBox1.Controls.Add(this.label_user);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.txt_InventoryNumber);
            this.groupBox1.Controls.Add(this.txt_ItemId);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_count);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.Item_number);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_credit);
            this.groupBox3.Controls.Add(this.rb_paypal);
            this.groupBox3.Controls.Add(this.rb_delivery);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(405, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 97);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rb_credit
            // 
            this.rb_credit.AutoSize = true;
            this.rb_credit.Location = new System.Drawing.Point(130, 42);
            this.rb_credit.Name = "rb_credit";
            this.rb_credit.Size = new System.Drawing.Size(77, 17);
            this.rb_credit.TabIndex = 6;
            this.rb_credit.TabStop = true;
            this.rb_credit.Text = "Credit Card";
            this.rb_credit.UseVisualStyleBackColor = true;
            // 
            // rb_paypal
            // 
            this.rb_paypal.AutoSize = true;
            this.rb_paypal.Location = new System.Drawing.Point(18, 42);
            this.rb_paypal.Name = "rb_paypal";
            this.rb_paypal.Size = new System.Drawing.Size(57, 17);
            this.rb_paypal.TabIndex = 5;
            this.rb_paypal.TabStop = true;
            this.rb_paypal.Text = "Paypal";
            this.rb_paypal.UseVisualStyleBackColor = true;
            // 
            // rb_delivery
            // 
            this.rb_delivery.AutoSize = true;
            this.rb_delivery.Location = new System.Drawing.Point(18, 74);
            this.rb_delivery.Name = "rb_delivery";
            this.rb_delivery.Size = new System.Drawing.Size(80, 17);
            this.rb_delivery.TabIndex = 4;
            this.rb_delivery.TabStop = true;
            this.rb_delivery.Text = "On Delivery";
            this.rb_delivery.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Payment Method";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rb_variable);
            this.groupBox2.Controls.Add(this.rb_simple);
            this.groupBox2.Location = new System.Drawing.Point(396, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 78);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Product Type";
            // 
            // rb_variable
            // 
            this.rb_variable.AutoSize = true;
            this.rb_variable.Location = new System.Drawing.Point(139, 44);
            this.rb_variable.Name = "rb_variable";
            this.rb_variable.Size = new System.Drawing.Size(63, 17);
            this.rb_variable.TabIndex = 1;
            this.rb_variable.TabStop = true;
            this.rb_variable.Text = "Variable";
            this.rb_variable.UseVisualStyleBackColor = true;
            // 
            // rb_simple
            // 
            this.rb_simple.AutoSize = true;
            this.rb_simple.Location = new System.Drawing.Point(9, 44);
            this.rb_simple.Name = "rb_simple";
            this.rb_simple.Size = new System.Drawing.Size(56, 17);
            this.rb_simple.TabIndex = 0;
            this.rb_simple.TabStop = true;
            this.rb_simple.Text = "Simple";
            this.rb_simple.UseVisualStyleBackColor = true;
            // 
            // btn_checkbox
            // 
            this.btn_checkbox.Location = new System.Drawing.Point(423, 140);
            this.btn_checkbox.Name = "btn_checkbox";
            this.btn_checkbox.Size = new System.Drawing.Size(133, 23);
            this.btn_checkbox.TabIndex = 18;
            this.btn_checkbox.Text = "Check";
            this.btn_checkbox.UseVisualStyleBackColor = true;
            this.btn_checkbox.Click += new System.EventHandler(this.btn_checkbox_Click);
            // 
            // checkbox
            // 
            this.checkbox.FormattingEnabled = true;
            this.checkbox.Items.AddRange(new object[] {
            "Is Available",
            "Not Available",
            "Coming Soon",
            "Out of Stock"});
            this.checkbox.Location = new System.Drawing.Point(396, 16);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(200, 109);
            this.checkbox.TabIndex = 17;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_user.Location = new System.Drawing.Point(27, 16);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(64, 25);
            this.label_user.TabIndex = 16;
            this.label_user.Text = "label1";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(229, 333);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(121, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(150, 95);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 13;
            // 
            // txt_InventoryNumber
            // 
            this.txt_InventoryNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_InventoryNumber.Location = new System.Drawing.Point(150, 140);
            this.txt_InventoryNumber.Name = "txt_InventoryNumber";
            this.txt_InventoryNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_InventoryNumber.TabIndex = 12;
            // 
            // txt_ItemId
            // 
            this.txt_ItemId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_ItemId.Location = new System.Drawing.Point(150, 53);
            this.txt_ItemId.Name = "txt_ItemId";
            this.txt_ItemId.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemId.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Name.Location = new System.Drawing.Point(150, 185);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 20);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_count.Location = new System.Drawing.Point(150, 229);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 20);
            this.txt_count.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(70, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(61, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Object Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(72, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(73, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_price.Location = new System.Drawing.Point(150, 280);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 2;
            // 
            // Item_number
            // 
            this.Item_number.AutoSize = true;
            this.Item_number.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Item_number.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Item_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Item_number.Location = new System.Drawing.Point(56, 46);
            this.Item_number.Name = "Item_number";
            this.Item_number.Size = new System.Drawing.Size(72, 27);
            this.Item_number.TabIndex = 1;
            this.Item_number.Text = "Item Id";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(36, 330);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(647, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 240);
            this.dataGridView1.TabIndex = 15;
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_InventoryNumber;
        private System.Windows.Forms.TextBox txt_ItemId;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label Item_number;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.CheckedListBox checkbox;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button btn_checkbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_credit;
        private System.Windows.Forms.RadioButton rb_paypal;
        private System.Windows.Forms.RadioButton rb_delivery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_variable;
        private System.Windows.Forms.RadioButton rb_simple;
    }
}

