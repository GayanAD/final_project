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
using Tulpep.NotificationWindow;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Imaging;
using System.IO;
namespace final_project
{
    public partial class frm_product : MetroFramework.Forms.MetroForm
    {
        int pw;
        bool Hided;
        public frm_product()
        {
            InitializeComponent();
            pw = Mpanel.Width;
            Hided = false;
        }
        public void load()
        {
            try
            {
                conDB.con.Open();
                //int oid = Convert.ToInt32(txt_oid.Text);
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_row_items ", conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid1.DataSource = dt;
                metroGrid1.Refresh();

                conDB.con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Data not added ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void load_pid()
        {
            try
            {
                conDB.con.Open();
                cmd = new SqlCommand();
                int pid = 0;

                cmd.Connection = conDB.con;
                cmd.CommandText = "SELECT f_ID FROM tbl_finish_output ";
                SqlDataReader dr;

                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    pid = Convert.ToInt32(dr.GetValue(0));
                    cmb_rpid.Items.Add(pid);
                    
                }

                dr.Close();


                cmd.Dispose();
                conDB.con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SqlCommand cmd;
        private void frm_product_Load(object sender, EventArgs e)
        {
            Mpanel.Hide();
            Hided = true;
            try
            {
                DateTime dt = DateTime.Today;
                txt_date.Text = dt.ToString();
                cmd = new SqlCommand();
                conDB.con.Open();
                int cid=0;

                cmd.Connection = conDB.con;
                cmd.CommandText = "SELECT OrderID FROM tbl_Orders ";
                SqlDataReader dr;

                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    cid = Convert.ToInt32(dr.GetValue(0));
                    cmb_oid.Items.Add(cid);
                    cmb_ioid.Items.Add(cid);

                }
              
                dr.Close();


                cmd.Dispose();
                conDB.con.Close();
                load();
                load_pid();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_oid.Text.Length > 0)
                {
                    errorProvider1.Clear();
                    if (txt_pnme.Text.Length > 0)
                    {
                        errorProvider3.Clear();
                        if (txt_qty.Text.Length > 0)
                        {
                            errorProvider2.Clear();
                            if (txt_fqty.Text.Length > 0)
                            {
                                errorProvider1.Clear();
                                int flag = 0;

                                DateTime dtnow = DateTime.Today;
                                int qty = 0;
                                int ino = Convert.ToInt32(txt_rino.Text);
                                int tot = Convert.ToInt16(txt_tot.Text);
                                int oid = Convert.ToInt32(cmb_oid.Text);
                                qty = Convert.ToInt32(txt_qty.Text);
                                int fqty = Convert.ToInt32(txt_fqty.Text);
                                Class_product PP = new Class_product();
                                flag = PP.add(oid, tot, txt_pnme.Text, fqty);
                                // cmd = new SqlCommand();
                                conDB.con.Open();
                                int fid = 0;

                                cmd.Connection = conDB.con;
                                cmd.CommandText = "SELECT max(f_ID) FROM tbl_finish_output ";
                                SqlDataReader dr;

                                dr = cmd.ExecuteReader();

                                while (dr.Read())
                                {
                                    fid = Convert.ToInt32(dr.GetValue(0).ToString());

                                }

                                dr.Close();

                                cmd.Dispose();
                                conDB.con.Close();
                                PP.update(qty, ino);
                                PP.add(ino, fid, qty);

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
                            }
                            else errorProvider1.SetError(txt_fqty, "Enter quantity");

                           
                        }
                        else errorProvider3.SetError(txt_qty, "Quantity Required");
                    }
                    else errorProvider2.SetError(txt_pnme, "Please enter design no");
                }
                else errorProvider1.SetError(cmb_oid, "Please select customer");



              


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

        private void cmb_oid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                conDB.con.Open();
                int oid=Convert.ToInt32(cmb_oid.SelectedIndex.ToString());
               
                string query = "SELECT cid from tbl_Orders where OrderID='" + oid + "'  ";
                SqlCommand cmd = new SqlCommand(query, conDB.con);
                SqlDataReader dr = cmd.ExecuteReader();
                int cid = 0;
                while (dr.Read())
                {
                    cid = Convert.ToInt32(dr.GetValue(0).ToString());
            

                }
                txt_cid.Text = cid.ToString();
                cmd.Dispose();
                dr.Dispose();

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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_rino.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(txt_qty.Text);
            int rino = Convert.ToInt32(txt_rino.Text);
            double up = 0;
            try
            {

                cmd = new SqlCommand();
                conDB.con.Open();
               

                cmd.Connection = conDB.con;
                cmd.CommandText = "SELECT up FROM tbl_row_items where row_ino='"+rino+"' ";
                SqlDataReader dr;

                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    up = Convert.ToDouble(dr.GetValue(0));
                   


                }
                double tot = up * qty;
                txt_tot.Text = tot.ToString();
                dr.Close();


                cmd.Dispose();
                conDB.con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_ioid_SelectedIndexChanged(object sender, EventArgs e)
        {

           try
           {
            int oid = Convert.ToInt32(cmb_ioid.SelectedIndex.ToString());
            conDB.con.Open();
            int cid = 0;
            string q = "select cid from tbl_Orders where OrderId='" + oid + "'";
            SqlCommand cad = new SqlCommand(q, conDB.con);
            SqlDataReader dar = cad.ExecuteReader();
            while (dar.Read())
            {
                //cid = dar.GetInt32(0);
                // cid = dar.GetInt32(0);
                cid = Convert.ToInt32(dar.GetValue(0).ToString());


            }
            txt_icid.Text = cid.ToString();
            cad.Dispose();
            dar.Dispose();
            conDB.con.Close();
                conDB.con.Open();
              

                string query = "select cfname,cmname,clname,cmobile_no,cemail from tbl_customer c inner join tbl_Orders s on c.cus_ID=s.cid where OrderId ='" + oid + "'  ";
                SqlCommand cmd = new SqlCommand(query, conDB.con);
                SqlDataReader dr = cmd.ExecuteReader();
                string cfn = null,cmn=null,cln=null,email=null;
                int cmno = 0;
                while (dr.Read())
                {
                    cfn = dr.GetValue(0).ToString();
                    cmn = dr.GetValue(1).ToString();
                    cln = dr.GetValue(2).ToString();
                  cmno = Convert.ToInt32(dr.GetValue(3));
                    email = dr.GetValue(4).ToString();



                }
                txt_cfn.Text = cfn;
                txt_mn.Text = cmn;
                txt_cln.Text = cln;
                txt_cemail.Text = email;
               txt_cmno.Text = cmno.ToString();
                cmd.Dispose();
                dr.Dispose();

                conDB.con.Close();
                

                conDB.con.Open();
               
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_finish_output where OrderID='" + oid + "'  ", conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid1.DataSource = dt;
                metroGrid1.Refresh();

                conDB.con.Close();
                conDB.con.Open();
               
                double tot = 0;
                string qu = "select sum(tot) from tbl_finish_output where OrderId='" + oid + "'";
                SqlCommand caaad = new SqlCommand(qu, conDB.con);
                //SqlDataAdapter matti = new SqlDataAdapter(qu, conDB.con);

                SqlDataReader drr = caaad.ExecuteReader();

                while (drr.Read())
                {
                    tot = drr.GetDouble(0);
                }
                txt_stot.Text = tot.ToString();
                caaad.Dispose();
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
        public double stotal = 0;
        private void txt_tr_TextChanged(object sender, EventArgs e)
        {
            stotal = Convert.ToDouble(txt_stot.Text);
            int tr = Convert.ToInt32(txt_tr.Text);
            double ta = 0;
            ta = (tr * stotal) / 100;
            txt_ta.Text = ta.ToString();

        }

        private void txt_dr_TextChanged(object sender, EventArgs e)
        {
            stotal = Convert.ToDouble(txt_stot.Text);
            int dr = Convert.ToInt32(txt_tr.Text);
            double da = 0;
            da = (dr * stotal) / 100;
            txt_da.Text = da.ToString();
        }

        private void txt_da_TextChanged(object sender, EventArgs e)
        {
            stotal = Convert.ToDouble(txt_stot.Text);
            double da = 0,ta=0,oth=0;
            da = Convert.ToDouble(txt_da.Text);
            ta = Convert.ToDouble(txt_ta.Text);
            oth = Convert.ToDouble(txt_o.Text);
            double ctot = ((stotal + oth) * 10) / 100;
            double nt = ((stotal + ta + oth + ctot) - da);
            txt_nt.Text = nt.ToString();

        }

        private void txt_stot_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int cid = Convert.ToInt32(txt_icid.Text);
                int oid = Convert.ToInt32(cmb_ioid.SelectedIndex.ToString());
                string dt = txt_date.Text;
                double st = Convert.ToDouble(txt_nt.Text);
                    
                class_invoice inv = new class_invoice();
              flag=  inv.add(cid,oid,dt,st);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double nt = Convert.ToDouble(txt_nt.Text);
            double tp = Convert.ToDouble(txt_tp.Text);
            double bal = 0;
            if (txt_tp.Text.Length > 0)
            {
                bal = nt - tp;
                txt_bal.Text = bal.ToString();
            }
            else
                txt_nt.Text = nt.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // try
         //  {
               conDB.con.Open();
               int oid = Convert.ToInt32(txt_roid.Text);
               int pid = Convert.ToInt32(cmb_rpid.SelectedIndex.ToString());
               int cid = Convert.ToInt32(txt_rcid.Text);

               int qty = Convert.ToInt32(txt_rqty.Text);
               string q = "select fqty from tbl_finish_output where f_ID = '" + pid + "'  ";
               SqlCommand cd = new SqlCommand(q, conDB.con);
               SqlDataReader drr = cd.ExecuteReader();
               int qtyo = 0;
               while (drr.Read())
               {
                  // qtyo = Convert.ToInt32(drr.GetValue(0).ToString());
                   qtyo = drr.GetInt32(0);

               }
             //  txt_rcid.Text = cid.ToString();
               cd.Dispose();
               drr.Dispose();

               conDB.con.Close();
               if (qty > qtyo)
               {
                   MessageBox.Show("Invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                int flag = 0;
               
                
                class_s_return s = new class_s_return();
               
                    flag = s.add(cid, oid, pid, qty, txt_reson.Text);
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
                    //int oid = Convert.ToInt32(txt_oid.Text);
                    SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_cus_rt where cus_ID='" + cid + "' ", conDB.con);
                    DataTable dt = new DataTable();
                    dap.Fill(dt);
                    metroGrid3.DataSource = dt;
                    metroGrid3.Refresh();

                    conDB.con.Close();
                }             

          /*  }
            catch (Exception)
            {
            }*/
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txt_rpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_rpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conDB.con.Open();
                int pid = Convert.ToInt32(cmb_rpid.SelectedIndex.ToString());

                string query = "select OrderID from tbl_finish_output where f_ID='" + pid + "'  ";
                SqlCommand cmd = new SqlCommand(query, conDB.con);
                SqlDataReader dr = cmd.ExecuteReader();
                int oid = 0;
                while (dr.Read())
                {
                    oid = Convert.ToInt32(dr.GetValue(0).ToString());


                }
                txt_roid.Text = oid.ToString();
                cmd.Dispose();
                dr.Dispose();

                conDB.con.Close();
                conDB.con.Open();
               // int pid = Convert.ToInt32(cmb_rpid.SelectedIndex.ToString());

                string q = "select cid from tbl_Orders where OrderID = (select OrderID from tbl_finish_output where f_ID = '" + pid + "')  ";
                SqlCommand cd = new SqlCommand(q, conDB.con);
                SqlDataReader drr = cd.ExecuteReader();
                int cid = 0;
                while (drr.Read())
                {
                    cid = Convert.ToInt32(drr.GetValue(0).ToString());


                }
                txt_rcid.Text = cid.ToString();
                cd.Dispose();
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

        private void txt_rqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            frm_email fe = new frm_email();
            fe.ShowDialog();
        }
      //  ReportDocument cr = new ReportDocument();
        private void button18_Click(object sender, EventArgs e)
        {
            
        }
    }
}
