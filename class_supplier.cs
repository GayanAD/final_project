using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycon;
using System.Data.SqlClient;

namespace final_project
{
    class class_supplier
    {
        
        public SqlCommand cmd;
        conDB g = new conDB();
        public int add(string snme,string add1,string add2,string add3,int mno,string email,string cname)
        {
            int res = 0;
            string qr = "INSERT INTO tbl_supplier VALUES ('" + snme + "','" + add1 + "','" + add2 + "','" + add3 + "','" + mno + "','" + email + "','"+cname+"')";
          res=  g.execute(qr);
            return res;

        }
        public int update(string snme, string add1, string add2, string add3, int mno, string email,string cname,int id)
        {
            int res = 0;
            string qr = "update tbl_supplier set sname='" + snme + "',saddress1='" + add1 + "',saddress2='" + add2 + "',saddress3='" + add3 + "',smobile_no='" + mno + "',semail='" + email + "',company_name='"+cname+"' where sup_ID='"+id+"'";
            res = g.execute(qr);
            return res;

        }
        public int delete(int id)
        {
            int res = 0;
            string qry = "DELETE FROM tbl_supplier WHERE sup_ID='"+id+"'";
           res = g.execute(qry);
            return res;
        }
        public int execute(string a)
        {
            int res = 0;
            SqlCommand cmd = new SqlCommand(a, conDB.con);
            conDB.con.Open();
            res = cmd.ExecuteNonQuery();
            conDB.con.Close();
            return res;
        }

    }
}
