using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycon;
using System.Data.SqlClient;

namespace final_project
{
    class class_s_return
    {
        public SqlCommand cmd;
        conDB g = new conDB();
        public int add(int cus_id, int oid,int fid, int qty, string res)
        {
            int result = 0;


            string qury = "INSERT INTO tbl_cus_rt VALUES ('" + cus_id + "','" + oid + "','"+fid+"','" + qty + "','" + res + "')";
            result = g.execute(qury);
            return result;
        }
    }
}
