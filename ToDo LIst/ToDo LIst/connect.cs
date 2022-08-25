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
    public partial class connect : Form
    {
        public connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF;Database=doing;Integrated Security=True");
                con.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
