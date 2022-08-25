using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ToDo_LIst
{
    public partial class Form1 : Form
    {
        string connection = "Server=DESKTOP-FGM4MBF;Database=doing; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor=Color.Transparent; 
            chk_showpassword.Parent = pictureBox2;  
            chk_showpassword.BackColor = Color.Transparent;
            label4.Parent = pictureBox2;
            label4.BackColor = Color.Transparent;
            this.AcceptButton = btn_login;
            this.txt_password.UseSystemPasswordChar = true;
        }

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
           if(chk_showpassword.Checked)
            {
                this.txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF;Database=doing;Integrated Security=True");
            string usename = txt_username.Text;
            string password = txt_password.Text;
            try
            {
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select username,passwordd from users where username='" + txt_username.Text + "'and passwordd='" + txt_password.Text + "'", con);
                DataTable ds = new DataTable();
                cmd.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    usename = txt_username.Text;
                    password = txt_password.Text;
                    MainPage screen = new MainPage();
                    this.Hide();
                    screen.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Login Details!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Login Failed!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
            finally
            {
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
