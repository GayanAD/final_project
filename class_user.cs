using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mycon;

namespace final_project
{
    class class_user
    {
        conDB g = new conDB();
        public int login(string u, string p)
        {
            int res = 0;
            string un = "", pwd = "";
            string q = "select un,pwd from tbl_login where un='" + u + "' and pwd='" + p + "'";
            conDB.con.Open();
            SqlCommand cmd = new SqlCommand(q, conDB.con);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                un = DR.GetValue(0).ToString();
                pwd = DR.GetValue(1).ToString();

            }



            conDB.con.Close();
            if (un == u && pwd == p)
            {
                res = 1;

            }

            return res;
        }
        public int add(string un, string pwd)
        {
            int res = 0;
            string query = "insert into tbl_login values ('" + un + "','" + pwd + "')";
            conDB.con.Open();
            SqlCommand cmd = new SqlCommand(query, conDB.con);
            res = cmd.ExecuteNonQuery();
            conDB.con.Close();
            return res;
        }
        public int add(string cat, string mat, string clr, string siz)
        {
            int res = 0;
            string query = "insert into tbl_item_master values ('" + cat + "','" + mat + "','" + clr + "','" + siz + "')";
            conDB.con.Open();
            SqlCommand cmd = new SqlCommand(query, conDB.con);
            res = cmd.ExecuteNonQuery();
            conDB.con.Close();
            return res;
        }
        public int update(string ctgry, string mtrial, string clr, string size, int id)
        {
            int res = 0;
            string qr = "update tbl_item_master set ctgyr='" + ctgry + "',mtrial='" + mtrial + "',clr='" + clr + "',size='" + size + "' where itm_id='" + id + "'";
            res = g.execute(qr);
            return res;

        }
        public int delete(int id)
        {
            int res = 0;
            string qry = "DELETE FROM tbl_item_master WHERE itm_id='" + id + "'";
            res = g.execute(qry);
            return res;
        }


        public int updt_pwd(string un,string pwd)
        {
            int flag = 0;
            string q = "update tbl_login set pwd='" + pwd + "' where un='" + un + "'";
            flag = g.execute(q);

            return flag;
        }


    }
    }
