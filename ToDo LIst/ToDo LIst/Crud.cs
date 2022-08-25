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
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF;Database=doing;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from users where username='" + txt_username.Text + "'",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
            }
            catch
            {
                MessageBox.Show("Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF;Database=doing;Integrated Security=True");
                string username=txt_username.Text;
                string fname=txt_fname.Text;
                string lname = txt_lname.Text;
                string password = txt_password.Text;
                string action = txt_action.Text;
                con.Open();
                
                SqlCommand cmd = new SqlCommand("select * from ",con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);
                cmd.Parameters.AddWithValue("passwrodd", password);
                cmd.Parameters.AddWithValue("actionn", action);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully"); 
                con.Close();
            
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF;Database=doing;Integrated Security=True ");
            
            SqlCommand ds = new SqlCommand("Select username,fname,lname,actionn from users where username='" + txt_username + "'",con);
            ds.CommandType = CommandType.Text;
            con.Open();
            var result= ds.ExecuteReader();
            if (result.Read())
            {
                while (result.Read())
                {
                    txt_username.Text = result[0].ToString();
                    txt_fname.Text = result[1].ToString();
                    txt_lname.Text = result[2].ToString();
                    txt_action.Text = result[3].ToString();


                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
