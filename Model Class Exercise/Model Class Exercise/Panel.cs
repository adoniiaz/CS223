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
    public partial class Panel : Form
    {
        public Panel()
        {
            
            InitializeComponent();
        }

        private void lbl_add_Click(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Red;
            //indicator.Top = 27;
        }

        private void lbl_edit_Click(object sender, EventArgs e)
        { 
            panel1.BackColor = Color.Blue;
            //indicator.Top = 14;
        }

        private void lbl_display_Click(object sender, EventArgs e)
        {

            panel1.BackColor = Color.Pink;
            //indicator.Top = 1;
        }
    }
}
