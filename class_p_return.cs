using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycon;
using System.Data.SqlClient;
namespace final_project
{
    class class_p_return
    {

        public SqlCommand cmd;
        conDB g = new conDB();
        public int add(int sup_id, int pino, int qty, string res)
        {
            int result = 0;


            string qury = "INSERT INTO tbl_rt VALUES ('" + sup_id + "','" +pino + "','" + qty + "','" + res + "')";
            result = g.execute(qury);
            return result;
        }
        public int update( int qty,int pino)
        {
            int result = 0;


            string qury = "update tbl_purchase_item set qty='"+qty+"' where pino='"+pino+"'";
            string q = "update tbl_row_items set qty='" + qty + "' where pino='" + pino + "'";
            result = g.execute(qury);
            g.execute(q);
            return result;
        }
    }
}
