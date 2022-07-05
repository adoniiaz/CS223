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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Propertiess p = new Propertiess();
            p.itemId = int.Parse(txt_ItemId.Text);
            p.datee = dtp_date.Text;
            p.inventnum = int.Parse(txt_InventoryNumber.Text);
            p.objectName = txt_ItemId.Text;
            p.count = int.Parse(txt_count.Text);
            p.price = int.Parse(txt_price.Text);
            p.save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
