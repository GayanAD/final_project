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
using mycon;
using Tulpep.NotificationWindow;
namespace final_project
{
    public partial class frm_sales_order : MetroFramework.Forms.MetroForm
    {
          int pw;
        bool Hided;
        
         
        public frm_sales_order()
        {
            InitializeComponent();
            pw = Mpanel.Width;
            Hided = false;
        }
        public SqlCommand cmd = null;
      
        public void load()
        {
            try
            {
                conDB.con.Open();
                //int oid = Convert.ToInt32(txt_oid.Text);
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_item_master ", conDB.con);
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
        public void loadmetro2()
        {
            try
            {
                conDB.con.Open();
                int oid = Convert.ToInt32(txt_oid.Text);
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM tbl_order_detail where oid='"+oid+"' ", conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid2.DataSource = dt;
                metroGrid2.Refresh();

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

        private void frm_sales_order_Load(object sender, EventArgs e)
        {
            Mpanel.Hide();
            Hided = true;
            load();
            try
            {
                DateTime dta = DateTime.Today;
                textBox1.Text = dta.ToString();
                cmd = new SqlCommand();
                conDB.con.Open();
                String cfname;

                cmd.Connection = conDB.con;
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
        public string SQL_quary;
        private void Load_USERS()
        {
            try
            {
                SqlDataAdapter DAP;
                DataTable user = new DataTable();
                conDB.con.Open();
                DAP = new SqlDataAdapter(SQL_quary, conDB.con);
                DAP.Fill(user);
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
       
        private void btn_srch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_fnme.Text.Length > 0)
                {
                    errorProvider1.Clear();
                    if (txt_dsno.Text.Length > 0)
                    {
                        if (txt_qty.Text.Length > 0)
                        {
                            errorProvider2.Clear();
                            int flag = 0;

                            DateTime dtnow = DateTime.Today;
                            int qty = 0;
                            int ino = Convert.ToInt16(txt_ino.Text);
                            int oid = Convert.ToInt32(txt_oid.Text);
                            qty = Convert.ToInt32(txt_qty.Text);

                            Class_sales cs = new Class_sales();

                            flag = cs.add(ino, oid, qty, txt_dsno.Text);


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
                            clear();
                        }
                        else errorProvider3.SetError(txt_qty, "Quantity Required");
                    }
                    else errorProvider2.SetError(txt_dsno, "Please enter design no");
                }
                else errorProvider1.SetError(cmb_fnme, "Please select customer");



                loadmetro2();

             //  load();
                
               
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
     /*   public void chk()
        {
            int id = Convert.ToInt32(txt_cid.Text);
            try
            {

                DateTime dtnow = DateTime.Today;
                string dt = dte1.Value.ToString();
                int result = 0;
                clz_sql.con.Open();

                string qury = "INSERT INTO tbl_sales_order VALUES ('" + id + "','" + dtnow + "','" + dt + "')";
                SqlCommand cmd = new SqlCommand(qury, clz_sql.con);
                result = cmd.ExecuteNonQuery();

                cmd.Dispose();
                clz_sql.con.Close();



            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        private void txt_cid_TextChanged(object sender, EventArgs e)
        {
          
        }
        
        public void ld()
        {
           // chk();
            DateTime dtnow = DateTime.Today;
           ;
            int cid = Convert.ToInt32(txt_cid.Text);
            Class_sales cs = new Class_sales();
            cs.add(dtnow, cid);
            try
            {


                conDB.con.Open();

                string qury = "SELECT OrderID from tbl_Orders where cid='" + cid + "'  ";
                SqlCommand cmd = new SqlCommand(qury, conDB.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_oid.Text = dr.GetValue(0).ToString();

                }
                cmd.Dispose();
                dr.Dispose();
                cmd.Dispose();
                conDB.con.Close();
                Class_sales ss = new Class_sales();
                int a=Convert.ToInt32(txt_oid.Text.ToString());
                
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Databasse Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     public   DateTime dtnow = DateTime.Today;
   
        private void cmb_fnme_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                conDB.con.Open();
                string aa = cmb_fnme.SelectedItem.ToString();
                string query = "SELECT cus_ID from tbl_customer where cfname='" + aa + "'  ";
                SqlCommand cmd = new SqlCommand(query, conDB.con);
                SqlDataReader dr = cmd.ExecuteReader();
                int cid = 0;
                while (dr.Read())
                {
                    cid = Convert.ToInt32(dr.GetValue(0));
              //txt_cid.Text = dr.GetValue(0).ToString();

                }
                txt_cid.Text = cid.ToString();
                cmd.Dispose();
                dr.Dispose();

                conDB.con.Close();
                Class_sales ss = new Class_sales();
               
               
                ld();

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

        private void cmb_fnme_SelectedValueChanged(object sender, EventArgs e)
        {
            



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try{
               
                 DialogResult dr = MessageBox.Show(this, "Do you really want to update?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (dr == DialogResult.Yes)
                 {

                   
                     int id = Convert.ToInt32(txt_iuno.Text);
                     int qty = 0;

                   
                     qty = Convert.ToInt32(txt_uqty.Text);

                    
                     Class_sales ss = new Class_sales();
                     int flag = ss.update(qty,txt_udno.Text, id);
                     if (flag > 0)
                     {


                         MessageBox.Show(this, "Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         clear();
                         loadmetro2();
                      
                     }
                     else
                         MessageBox.Show(this, "Data not updated ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
             catch (SqlException)
             {
                 MessageBox.Show("Datbase error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
             }
             catch (Exception)
             {
                 MessageBox.Show(this, "Error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_oid_TextChanged(object sender, EventArgs e)
        {
          
        }
        public void clear()
        {
            txt_ino.Clear();
            txt_dsno.Clear();
            txt_qty.Clear();
           
        }
        private void btn_clr_Click(object sender, EventArgs e)
        {
          //  int b = Convert.ToInt32(txt_itemno.Text);
            txt_ino.Clear();
            txt_dsno.Clear();
            txt_qty.Clear();
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           try
            {
               
                DialogResult dr = MessageBox.Show(this, "Do you really want to remove ? ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                int ino = Convert.ToInt32(txt_iuno.Text);
                if (dr == DialogResult.Yes)
                {

                    Class_sales bkk = new Class_sales();
                    int flag = bkk.delete(ino);
                    if (flag > 0)
                    {


                        MessageBox.Show(this, "Row deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadmetro2();

                       
                    }
                    else
                        MessageBox.Show(this, "Data not deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Datbse error ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

              
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ino.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
           // txt_qty.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            frm_sales_order fs = new frm_sales_order();
            fs.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            frm_purchase fp = new frm_purchase();
            fp.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            frm_stock_manage sk = new frm_stock_manage();
            sk.Show();*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            frm_setting_log fs = new frm_setting_log();
            fs.Show();*/
        }

        private void button11_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            frm_invoice fi = new frm_invoice();
            fi.Show();*/
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_iuno.Text = metroGrid2.CurrentRow.Cells[0].Value.ToString();
            txt_uqty.Text = metroGrid2.CurrentRow.Cells[2].Value.ToString();
            txt_udno.Text = metroGrid2.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
