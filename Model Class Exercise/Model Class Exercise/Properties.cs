using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms ;

namespace Model_Class_Exercise
{
    internal class Propertiess
    {
        public int itemId { get; set; }
        public string datee { get; set; }
        public int inventnum { get; set; }
        public string objectName{ get; set; }
        public int count { get; set; }
        public int price { get; set; }

        public void save()
        {
            MessageBox.Show("Successfuly Saved");
        }


    }
}
