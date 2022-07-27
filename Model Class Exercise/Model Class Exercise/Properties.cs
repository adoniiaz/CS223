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
        static List<Propertiess> props = new List<Propertiess>();
        public int itemId { get; set; }
        public string datee { get; set; }
        public int inventnum { get; set; }
        public string objectName{ get; set; }

        public int count { get; set; }
        public int price { get; set; }

        public bool isAvailable { get; set; }   

        public void save()
        {
            props.Add(this);
        }
        
        public static List<Propertiess> GetPropertiesses()
        {
            return props;
        }
    }
}
