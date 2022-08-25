using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Class_Exercise
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            lbl_maintxt.Parent = pictureBox1;
            lbl_maintxt.BackColor = Color.Transparent;
            lbl_user.Parent = pictureBox1;
            lbl_user.BackColor = Color.Transparent;
            lbl_pass.Parent= pictureBox1;
            lbl_pass.BackColor = Color.Transparent;
            checkbox_show.Parent = pictureBox1;
            checkbox_show.BackColor = Color.Transparent;
            this.AcceptButton = btn_login;
            this.txt_password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=txt_user.Text;
            string password = txt_password.Text;
            if (username != "admin" || password != "admin")
            {
                MessageBox.Show("Wrong Username or Password");
            }
            else
            {
                Form1 screen = new Form1();
                this.Hide();
                screen.Show();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_show.Checked)
            {
                this.txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                this.txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
