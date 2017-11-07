using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mycon;
namespace final_project
{
    class Class_sales
    {
        public SqlCommand cmd;
        conDB g = new conDB();
        public int add(int itm_id,int oid,int qty,string dno)
        {
            int result = 0;
          

            string qury = "INSERT INTO tbl_order_detail VALUES ('"+itm_id+"','"+oid+"','" + qty+ "','"+dno+"')";
            result = g.execute(qury);
            return result;
        }
      

        public int add( DateTime odt,int cid)
        {
            int result = 0;


            string qury = "INSERT INTO tbl_Orders VALUES ('" + odt + "','" + cid + "')";
            result = g.execute(qury);

            return result;
        }

        public int update(int qty,  String dno, int id)
        {
            {
                int result = 0;

                string qury = "UPDATE  tbl_order_detail SET qty='" + qty + "',des_no='" + dno + "'WHERE itm_id= '" + id + "'";
             
                
                result = g.execute(qury);
                return result;
            }

        }
        public int delete(int id)
        {
            int result = 0;

            string q = "DELETE FROM tbl_order_detail WHERE itm_id='" + id + "'";
         
            result = g.execute(q);

            return result;
        }
    }
}
