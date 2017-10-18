using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace final_project
{
    public partial class frm_sales_order : MetroFramework.Forms.MetroForm
    {
        public frm_sales_order()
        {
            InitializeComponent();
        }
        public SqlCommand cmd = null;

        private void frm_sales_order_Load(object sender, EventArgs e)
        {

            cmd = new SqlCommand();
            clz_sql.con.Open();
            String cfname;

            cmd.Connection = clz_sql.con;
            cmd.CommandText = "SELECT cfname FROM tbl_customer ";
            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                cfname = (dr.GetString(0));
                cmb_fnme.Items.Add(cfname);

            }
            dr.Close();
            cmd.Dispose();
            clz_sql.con.Close();

        }

        private void btn_srch_Click(object sender, EventArgs e)
        {

        }
    }
}
