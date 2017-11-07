using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycon;
using System.Data.SqlClient;

namespace final_project
{
    class class_invoice
    {
        public SqlCommand cmd;
        conDB g = new conDB();
        public int add(int cid,int oid, string dt, double stot)
        {
            int res=0;
            string qry = "insert into tbl_invoice values('"+cid+"','" + oid + "','" + dt + "','" + stot + "')";
            res = g.execute(qry);
            return res;
        }
        
    }
}
