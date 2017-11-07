using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mycon;
using System.Data.SqlClient;

namespace final_project
{  
    
    class class_customer
    {
        public SqlCommand cmd;
        conDB g = new conDB();
        public int add(string fnme,string mnme,string lnme,string add1,string add2,string add3,int mno,string email)
        {
            int res = 0;
            string qr = "INSERT INTO tbl_customer VALUES ('" + fnme + "','" + mnme + "','" + lnme + "','" + add1 + "','" + add2 + "','" + add3 + "','" + mno + "','" + email + "')";
          res=  g.execute(qr);
            return res;

        }
        public int update(string fnme, string mnme, string lnme, string add1, string add2, string add3, int mno, string email,int id)
        {
            int res = 0;
            string qr = "update tbl_customer set cfname='" + fnme + "',cmname='" + mnme + "',clname='" + lnme + "',caddress1='" + add1 + "',caddress2='" + add2 + "',caddress3='" + add3 + "',cmobile_no='" + mno + "',cemail='" + email + "' where cus_ID='"+id+"'";
            res = g.execute(qr);
            return res;

        }
        public int delete(int id)
        {
            int res = 0;
            string qry = "DELETE FROM tbl_customer WHERE cus_ID='"+id+"'";
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
