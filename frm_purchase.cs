using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using mycon;
using MetroFramework.Forms;
using Tulpep.NotificationWindow;
namespace final_project
{
    public partial class frm_purchase : MetroFramework.Forms.MetroForm
    {
        int pw;
        bool Hided;
        public frm_purchase()
        {
            InitializeComponent();
            pw = Mpanel.Width;
            Hided = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void ld()
        {
            try
            {

                cmd = new SqlCommand();
                conDB.con.Open();
                int cid = 0;

                cmd.Connection = conDB.con;
                cmd.CommandText = "SELECT sup_ID FROM tbl_supplier ";
                SqlDataReader dr;

                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    cid = Convert.ToInt32(dr.GetValue(0));

                    cmb_sid.Items.Add(cid);
                }
                //.Text = cid.ToString();

                dr.Close();


                cmd.Dispose();
                conDB.con.Close();
            }
            catch (Exception)
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int pid = Convert.ToInt32(txt_pid.Text);
           // DateTime dt = DateTime.Today;
           int sid = Convert.ToInt32(cmb_sid.Text);
            int qty = Convert.ToInt32(txt_Qty.Text);
            double up = Convert.ToDouble(txt_UP.Text);
            String iname = txt_iname.Text;
            String des = txt_Descrip.Text;
             //txt_Date.Text=dt.ToString();

            Class_purchase a = new Class_purchase();
            a.add(iname, qty, des, up, txt_Date.Text);
            conDB.con.Open();

            string qury = "SELECT max(pino) from tbl_purchase_item";
            SqlCommand cmd = new SqlCommand(qury, conDB.con);
            SqlDataReader dr = cmd.ExecuteReader();
            int pino = 0;
            while (dr.Read())
            {
               // txt_oid.Text = dr.GetValue(0).ToString();
                pino = dr.GetInt32(0);

            }
            cmd.Dispose();
            dr.Dispose();
            cmd.Dispose();
            conDB.con.Close();
            int flag = 0;
        flag=    a.add(sid, pino, qty, txt_Date.Text);

        if (flag > 0)
        {
            // MessageBox.Show(this, "Row added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopupNotifier popup = new Tulpep.NotificationWindow.PopupNotifier();
            popup.Image = Properties.Resources.Information_Bubble_48;
            popup.ContentText = "Success";
            // popup.BodyColor.ToString();
            popup.Popup();


        }
        else

            MessageBox.Show(this, "Data not added ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lddata();
           
            
            
        }
        public void lddata()
        {
            conDB.con.Open();
            int id = Convert.ToInt32(cmb_sid.SelectedItem.ToString());
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_supply where sup_ID='" + id + "' ", conDB.con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            metroGrid2.DataSource = dt;
            metroGrid2.Refresh();

            conDB.con.Close();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
           
           
        }
       public SqlCommand cmd; 
        private void frm_purchase_Load(object sender, EventArgs e)
        {
            Mpanel.Hide();
            Hided = true;
            try
            {
                DateTime dta = DateTime.Today;
                txt_Date.Text = dta.ToString();
                ld();
               
            }
            catch (Exception)
            {
            }

        }

        private void cmb_pino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
          
                conDB.con.Open();
                int sid = 0, qty = 0;
                int oid = Convert.ToInt32(cmb_pino.SelectedItem.ToString());
               
                string query = "SELECT sup_ID,qty from tbl_supply where pino='" + oid + "'  ";
                SqlCommand cmd = new SqlCommand(query, conDB.con);
                SqlDataReader drr = cmd.ExecuteReader();
                
                while (drr.Read())
                {
                   
                    sid = Convert.ToInt32(drr.GetValue(0));
                    qty = Convert.ToInt32(drr.GetValue(1));
                   
                   // sid = drr.GetInt32(0);
                    //qty = drr.GetInt32(0);

                }
                txt_sid.Text = sid.ToString();
                txt_rqty.Text = qty.ToString();
                cmd.Dispose();
                drr.Dispose();

                conDB.con.Close();
           }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(txt_sid.Text);
            int pino = Convert.ToInt32(cmb_pino.Text);
            int qty = Convert.ToInt32(ret_qty.Text);
            class_p_return p = new class_p_return();
            int flag = 0;
            p.add(sid, pino, qty,txt_res.Text);
            
         flag=   p.update(qty, pino);
            if (flag > 0)
            {
                // MessageBox.Show(this, "Row added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopupNotifier popup = new Tulpep.NotificationWindow.PopupNotifier();
                popup.Image = Properties.Resources.Information_Bubble_48;
                popup.ContentText = "Success";
                // popup.BodyColor.ToString();
                popup.Popup();


            }
            else

                MessageBox.Show(this, "Data not added ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conDB.con.Open();
            int id = Convert.ToInt32(txt_sid.Text);
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_rt where pino='" + pino + "' ", conDB.con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            metroGrid1.DataSource = dt;
            metroGrid1.Refresh();

            conDB.con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            cmd = new SqlCommand();
            conDB.con.Open();
            int cid = 0;

            cmd.Connection = conDB.con;
            cmd.CommandText = "SELECT pino FROM tbl_purchase_item ";
            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                cid = Convert.ToInt32(dr.GetValue(0));

                cmb_pino.Items.Add(cid);
            }
            //.Text = cid.ToString();

            dr.Close();


            cmd.Dispose();
            conDB.con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mpanel.Show();
            if (Hided) button1.Text = "_\n_\n_";
            else button1.Text = "_\n_\n_";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                Mpanel.Width = Mpanel.Width + 20;
                if (Mpanel.Width >= pw)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                Mpanel.Width = Mpanel.Width - 20;
                if (Mpanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
