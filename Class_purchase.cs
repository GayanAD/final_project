using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mycon;

namespace final_project
{
    class Class_purchase
    {
        public SqlCommand cmd;
        conDB g = new conDB();

        public int add(String iname, int qty, String descrpt, double up,String date)
        {
            int result = 0;
          
     
           string qury = "INSERT INTO tbl_purchase_item VALUES ('" + iname + "','" + qty + "','" + descrpt + "','" + up + "')";
          // string uu = "INSERT INTO tbl_supply VALUES ('" + qty + "','" + date + "')";
            
         result=   g.execute(qury);
       //  g.execute(uu);
            return result;
        }
          public int add(int sid, int pino, int qty,String date)
        {
            int result = 0;
          
     
           string qury = "INSERT INTO tbl_supply VALUES ('" + sid + "','" + pino + "','" + qty + "','" + date + "')";
          // string uu = "INSERT INTO tbl_supply VALUES ('" + qty + "','" + date + "')";
            
         result=   g.execute(qury);
       //  g.execute(uu);
            return result;
        }

       

    /*    public int update(int qty, String cat, String desc, double up, double tot, int id)
        {
            {
                int result = 0;
               

                string qury = "UPDATE  tbl_row_items SET qty='" + qty + "',category='" + cat + "',descrpt='" + desc + "',up='" + up + "',total='" + tot + "'WHERE pino= '" + id + "'";
                string b = "UPDATE  tbl_supply SET qty='" + qty + "' where pino='" + id + "'";
                string c = "update   tbl_stocks set qty='"+qty+"' from tbl_stocks t1 inner join tbl_supply t2 on t1.stock_ID=t2.stock_ID where t2.pino='"+id+"'";
            
                result = g.execute(qury);
                g.execute(b);


               

                return result;
            }
        */
        
    
     /*   public int delete(int id)
        {
            int result = 0;
            

            string qury = "DELETE FROM tbl_row_items WHERE pino='" + id + "'";
            string a = "delete from tbl_supply where pino='" + id + "'";
            string b="delete t2 from tbl_stocks t1  inner join tbl_supply t2 on t1.stock_ID=t2.stock_ID where t2.pino='"+id+"'";


            result = g.execute(b);
            g.execute(qury);
            g.execute(a);

           

            return result;
       }  */

}
}
