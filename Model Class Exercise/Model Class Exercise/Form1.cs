using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Model_Class_Exercise
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent(); 
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            Propertiess p = new Propertiess();
            Regex reg = new Regex("^[0-9]{4}$");
            bool result = reg.IsMatch(txt_ItemId.Text);
            if (result)
            {
                p.itemId = int.Parse(txt_ItemId.Text);
            }
            else
            {
                MessageBox.Show("Invalid Item ID");
            }
            p.datee = dtp_date.Text;
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                errorProvider_name.SetError(txt_Name, "Name is required");
            }
            else
            {
                p.objectName = txt_Name.Text;
            }
            
           
            try
            {
                p.inventnum = int.Parse(txt_InventoryNumber.Text);
                p.count = int.Parse(txt_count.Text);
            }
            catch(Exception t)
            {
                MessageBox.Show("Error: " + t.Message);
            }
            p.price = int.Parse(txt_price.Text);
            p.save();
            




        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF; Database= modelclass; Integrated Security= True;");
            SqlCommand cmd = new SqlCommand("deletefrominvent", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itemid", txt_search.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            con.Close();
        }

        private void btn_checkbox_Click(object sender, EventArgs e)
        {
            string message = " ";
            foreach (var item in checkbox.SelectedItems) {
                message += checkbox.Text;
            }
            MessageBox.Show(message);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            Display displ= new Display();
            this.Hide();
            displ.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF; Database= modelclass; Integrated Security= True;");
            try
            {
                con.Open();
                SqlCommand updating = new SqlCommand("updatinvent", con);
                updating.CommandType = CommandType.StoredProcedure;
                updating.Parameters.AddWithValue("itemid", txt_ItemId.Text);
                updating.Parameters.AddWithValue("invnumber", txt_InventoryNumber.Text);
                updating.Parameters.AddWithValue("objectname", txt_Name.Text);
                updating.Parameters.AddWithValue("countt", txt_count.Text);
                updating.Parameters.AddWithValue("price", txt_price.Text);
                updating.ExecuteNonQuery();
                MessageBox.Show("Edited Successfully");
                
            }
            catch
            {
                MessageBox.Show("Process Failed");
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF; Database= modelclass; Integrated Security= True;");
            int itemid = int.Parse(txt_search.Text);
            SqlCommand cmd = new SqlCommand("displaybyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itemid", itemid);
            con.Open();
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                txt_ItemId.Text = result[0].ToString();
                txt_InventoryNumber.Text = result[1].ToString();
                txt_Name.Text = result[2].ToString();
                txt_count.Text = result[3].ToString();
                txt_price.Text = result[4].ToString();
            }
            con.Close();
        }
    }
        
    }
