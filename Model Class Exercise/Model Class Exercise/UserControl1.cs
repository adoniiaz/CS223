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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string _productname;

        public string productName
        {
            get { return _productname; }
            set { _productname = value; label2.Text = value; }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
