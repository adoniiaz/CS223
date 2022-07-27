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

namespace Model_Class_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Propertiess.GetPropertiesses();




        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            login log = new login();
            log.Show();
        }

        private void btn_checkbox_Click(object sender, EventArgs e)
        {
            string message = " ";
            foreach (var item in checkbox.SelectedItems) {
                message += checkbox.Text;
            }
            MessageBox.Show(message);
        }
    }
        
    }
