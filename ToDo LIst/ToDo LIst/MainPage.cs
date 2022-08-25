using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_LIst
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void insertNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crud screen = new Crud();
            this.Hide();
            screen.Show();
        }

        private void updateExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display screen = new Display();
            this.Hide();
            screen.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crud screen = new Crud();
            this.Hide();
            screen.Show();
        }
    }
}
