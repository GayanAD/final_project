using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycon;
using System.Data.SqlClient;

namespace final_project
{
    class Class_product
    {
        public SqlCommand cmd;
        //conDB g = new conDB();
        
        public int add( int oid, double tot,string pnme,int fqty)
        {
            int result = 0;
          
           
            string qury = "INSERT INTO tbl_finish_output VALUES ('" + oid + "','" + tot + "','"+pnme+"','"+fqty+"')";
            conDB.con.Open();
            cmd = new SqlCommand(qury, conDB.con);
            result = cmd.ExecuteNonQuery();
            conDB.con.Close();
            return result;
        }
        public int update(int qty, int rino)
        {
            int result = 0;


            string qury = "UPDATE tbl_row_items set qty='" + qty + "' where row_ino='" +rino + "'";
            conDB.con.Open();
            cmd = new SqlCommand(qury, conDB.con);
            result = cmd.ExecuteNonQuery();
            conDB.con.Close();
            return result;
        }
        public int add(int rino, int fid,int qty)
        {
            int result = 0;


            string qury = "INSERT INTO tbl_manufacture VALUES ('" + rino + "','" + fid + "','"+qty+"')";
            conDB.con.Open();
            cmd = new SqlCommand(qury, conDB.con);
            result = cmd.ExecuteNonQuery();
            conDB.con.Close();
            return result;
        }
       
       
    }
}
