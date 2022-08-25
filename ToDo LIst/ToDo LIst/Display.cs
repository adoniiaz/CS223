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
    public partial class Display : Form
    {
        public Display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF;Database=doing;Integrated Security=True");
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from users", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "Data");
           
            dataGridView1.DataSource = ds.Tables["Data"].DefaultView;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
