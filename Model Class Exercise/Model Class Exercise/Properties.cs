using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms ;
using System.Data.SqlClient;

namespace Model_Class_Exercise
{
    internal class Propertiess
    {
        static List<Propertiess> props = new List<Propertiess>();
        Propertiess Findone(string id)
        {
            List<Propertiess> props = new List<Propertiess>();
            return props.Find(a => a.objectName == id);

        }
        public int itemId { get; set; }
        public string datee { get; set; }
        public int inventnum { get; set; }
        public string objectName{ get; set; }

        public int count { get; set; }
        public int price { get; set; }

        public bool isAvailable { get; set; }   

        public void save()
        {
            //props.Add(this);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF; Database= modelclass; Integrated Security= True;");
            SqlCommand cmd = new SqlCommand("insertintoinvent", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itemid", itemId);
        
            cmd.Parameters.AddWithValue("@invnumber", inventnum);
            cmd.Parameters.AddWithValue("@objectname", objectName);
            cmd.Parameters.AddWithValue("@countt", count);
            cmd.Parameters.AddWithValue("@price", price);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
        }
        
        public static List<Propertiess> GetPropertiesses()
        {
            Propertiess p = new Propertiess();
            List<Propertiess> temp = new List<Propertiess>();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FGM4MBF; Database= modelclass; Integrated Security= True;");
            SqlCommand cmd = new SqlCommand("displayall", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            var result=cmd.ExecuteReader();
            while (result.Read())
            {
                p.itemId = (int)result[0];
                p.inventnum= (int)result[1];
                p.objectName = (string)result[2];
                p.count = (int)result[3];
                p.price = (int)result[4];
            }
            temp.Add(p);
            
            return temp;
        }
    }
}
