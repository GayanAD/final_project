using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace final_project
{
    class clz_sql
    {
       public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-SQIVGEC;Initial Catalog=finalproject;Integrated Security=True");
    }
}