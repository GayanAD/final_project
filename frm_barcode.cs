using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mycon;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
namespace final_project
{
    public partial class frm_barcode : Form
    {
        ReportDocument cr = new ReportDocument();
        public frm_barcode()
        {
            InitializeComponent();
        }

        private void frm_barcode_Load(object sender, EventArgs e)
        {
           // cr.Load(@"E:\final_project\final_project\barcode.rpt");
         cr.Load(@"E:\final_project\final_project\barcode.rpt");
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conDB.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_invoice ", conDB.con);
         //   DataSet ds = new DataSet();
         //   sda.Fill(ds, "tbl_invoice");

            DataTable dt = new DataTable();
            sda.Fill(dt);

            cr.SetDataSource(dt);
            crystalReportViewer1.ReportSource=cr;
            conDB.con.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           // cr.Load(@"E:\final_project\final_project\barcode.rpt");
        }
    }
}
