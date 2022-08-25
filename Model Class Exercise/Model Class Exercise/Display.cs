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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=Propertiess.GetPropertiesses();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }
    }
}
