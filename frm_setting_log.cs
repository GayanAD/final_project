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
using mycon;
using System.Data.SqlClient;

namespace final_project
{
    public partial class frm_setting_log : MetroFramework.Forms.MetroForm
    {
        public frm_setting_log()
        {
            InitializeComponent();
        }

        private void frm_setting_log_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string un="", pwd="";

            string ff = "select un,pwd from tbl_login where un='" + txt_un.Text + "' and pwd='" + txt_pwd.Text + "'";

            conDB.con.Open();

            SqlCommand cmd = new SqlCommand(ff, conDB.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                un = dr.GetValue(0).ToString();
                pwd = dr.GetValue(1).ToString();



            }

           

            conDB.con.Close();

            if (un == txt_un.Text && pwd == txt_pwd.Text)
            {
                frm_setting kk = new frm_setting();
                kk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access Revoked", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
               
        }
    }
}
