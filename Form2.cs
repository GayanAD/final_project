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

namespace final_project
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        int pw;
        bool Hided;
        public Form2()
        {
            InitializeComponent();
            pw = Mpanel.Width;
            Hided = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            setDataGride();

        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {
            setDataGride2();

        }
            private void setDataGride2()//to fill datagride
        {
            try
            {
                conDB.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_supplier", conDB.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid2.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("can not fill datagride,,check database connection");
            }
        }
       
         
        public void setDataGride()//to fill datagride
        {
            try
            {
                conDB.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_customer", conDB.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid1.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("check database connection");
            }
        }
        private void txt_cemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Mpanel.Hide();
            Hided = true;
           setDataGride();
           setDataGride2();
        }
        public void toClearTextField_sup()
        {
            txt_sid.Clear();
            txt_sfnme.Clear();
            txt_c_nme.Clear();
            txt_sadd1.Clear();
            txt_sadd2.Clear();
            txt_sadd3.Clear();
            txt_smno.Clear();
            txt_semail.Clear();

        }
        private void button11_Click(object sender, EventArgs e)
        {
            Mpanel.Show();
            if (Hided) button11.Text = "_\n_\n_";
            else button11.Text = "_\n_\n_";
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
            try
            {
                if (txt_cfnme.Text.Length > 0)
                {
                    errorProvider1.Clear();
                    if (txt_cmnme.Text.Length > 0)
                    {
                        if (txt_clnme.Text.Length > 0)
                        {
                            errorProvider3.Clear();
                            if (txt_add1.Text.Length > 0)
                            {
                                errorProvider4.Clear();
                                if (txt_add2.Text.Length > 0)
                                {
                                    errorProvider5.Clear();
                                    if (txt_add3.Text.Length > 0)
                                    {
                                        errorProvider6.Clear();
                                        if (txt_cmno.Text.Length != 10)
                                        {
                                            errorProvider7.Clear();
                                            if (txt_cemail.Text.Length > 0)
                                            {
                                                errorProvider8.Clear();
                                            }
                                            else
                                                errorProvider8.SetError(txt_cemail, "You should fiil  required data");
                                        }
                                        else errorProvider7.SetError(txt_cmno, "You should fiil  required data");
                                    }
                                    else errorProvider6.SetError(txt_add3, "You should fiil  required data");
                                }
                                else errorProvider5.SetError(txt_add2, "You should fiil  required data");

                            }
                            else errorProvider4.SetError(txt_add1, "You should fiil  required data");
                        }
                        else errorProvider3.SetError(txt_clnme, "You should fiil  required data");
                    }
                    else errorProvider2.SetError(txt_cmnme, "You should fiil  required data");
                }
                else errorProvider1.SetError(txt_cfnme, "You should fiil  required data");

                int flag = 0;
                int mno = Convert.ToInt32(txt_cmno.Text);
                class_customer ss = new class_customer();
                flag = ss.add(txt_cfnme.Text, txt_cmnme.Text, txt_clnme.Text, txt_add1.Text, txt_add2.Text, txt_add3.Text, mno, txt_cemail.Text);

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

                setDataGride();
           }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
                toClearText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int id = Convert.ToInt32(txt_cid.Text);
                int mno = Convert.ToInt32(txt_cmno.Text);
                class_customer ss = new class_customer();
                flag = ss.update(txt_cfnme.Text, txt_cmnme.Text, txt_clnme.Text, txt_add1.Text, txt_add2.Text, txt_add3.Text, mno, txt_cemail.Text, id);

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
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            toClearText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int id = Convert.ToInt32(txt_cid.Text);
                class_customer cs = new class_customer();
                flag = cs.delete(id);

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

                setDataGride2();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            toClearText();
        }

        private void txt_srchid_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conDB.con.Open();
                string query = "select * from tbl_customer where cus_ID = '" + txt_srchid.Text + "'";

                SqlDataAdapter dap = new SqlDataAdapter(query, conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid1.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void txt_srchnme_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conDB.con.Open();
                string query = "select * from tbl_customer where cfname like '%" + txt_srchnme.Text + "%'";

                SqlDataAdapter dap = new SqlDataAdapter(query, conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid1.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public void toClearText()
        {
            txt_cid.Clear();
            txt_cfnme.Clear();
            txt_cmnme.Clear();
            txt_clnme.Clear();
            txt_add1.Clear();
            txt_add2.Clear();
            txt_add3.Clear();
            txt_cmno.Clear();
            txt_cemail.Clear();

        }
      
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_cid.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
                txt_cfnme.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
                txt_cmnme.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
                txt_clnme.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                txt_add1.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
                txt_add2.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
                txt_add3.Text = metroGrid1.CurrentRow.Cells[6].Value.ToString();
                txt_cmno.Text = metroGrid1.CurrentRow.Cells[7].Value.ToString();
                txt_cemail.Text = metroGrid1.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             try
            {
                if (txt_sfnme.Text.Length > 0)
                {
                    errorProvider1.Clear();

                    errorProvider3.Clear();
                    if (txt_sadd1.Text.Length > 0)
                    {
                        errorProvider4.Clear();
                        if (txt_sadd2.Text.Length > 0)
                        {
                            errorProvider5.Clear();
                            if (txt_sadd3.Text.Length > 0)
                            {
                                errorProvider6.Clear();
                                if (txt_smno.Text.Length!= 0)
                                {
                                    errorProvider7.Clear();
                                    if (txt_semail.Text.Length > 0)
                                    {
                                        errorProvider8.Clear();
                                        if (txt_c_nme.Text.Length > 0)
                                        {
                                            errorProvider2.Clear();
                                        }
                                        else
                                            errorProvider2.SetError(txt_c_nme, "You should fiil  required data");
                                    }
                                    else
                                        errorProvider8.SetError(txt_semail, "You should fiil  required data");
                                }
                                else errorProvider7.SetError(txt_smno, "You should fiil  required data");
                            }
                            else errorProvider6.SetError(txt_sadd3, "You should fiil  required data");
                        }
                        else errorProvider5.SetError(txt_sadd2, "You should fiil  required data");

                    }
                    else errorProvider4.SetError(txt_sadd1, "You should fiil  required data");

                }
                else errorProvider1.SetError(txt_sfnme, "You should fiil  required data");

                int flag = 0;
                int mno = Convert.ToInt32(txt_smno.Text);

                class_supplier ss = new class_supplier();

                flag = ss.add(txt_sfnme.Text, txt_sadd1.Text, txt_sadd2.Text, txt_sadd3.Text, mno, txt_semail.Text, txt_c_nme.Text);


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

                setDataGride2();
            }
            catch (Exception)
            {
            }
             toClearTextField_sup();
            }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int id = Convert.ToInt32(txt_sid.Text);
                int mno = Convert.ToInt32(txt_smno.Text);
                class_supplier ss = new class_supplier();
                flag = ss.update(txt_sfnme.Text,  txt_sadd1.Text, txt_sadd2.Text, txt_sadd3.Text, mno, txt_semail.Text,txt_c_nme.Text, id);

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

               setDataGride2();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            toClearTextField_sup();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int id = Convert.ToInt32(txt_sid.Text);
                class_supplier cs = new class_supplier();
                flag = cs.delete(id);

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

                setDataGride2();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            toClearTextField_sup();
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             txt_sid.Text = metroGrid2.CurrentRow.Cells["sup_ID"].Value.ToString();
            txt_sfnme.Text = metroGrid2.CurrentRow.Cells["sname"].Value.ToString();
            txt_sadd1.Text = metroGrid2.CurrentRow.Cells["saddress1"].Value.ToString();
            txt_sadd2.Text = metroGrid2.CurrentRow.Cells["saddress2"].Value.ToString();
            txt_sadd3.Text = metroGrid2.CurrentRow.Cells["saddress3"].Value.ToString();
            txt_smno.Text = metroGrid2.CurrentRow.Cells["smobile_no"].Value.ToString();
            txt_semail.Text = metroGrid2.CurrentRow.Cells["semail"].Value.ToString();
            txt_c_nme.Text = metroGrid2.CurrentRow.Cells["company_name"].Value.ToString();
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {
            setDataGride2();
        }

        private void txt_srchid2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                conDB.con.Open();
                string query = "select * from tbl_supplier where sup_ID = '" + txt_srchid2.Text + "'";

                SqlDataAdapter dap = new SqlDataAdapter(query, conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid2.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void txt_srchnme2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conDB.con.Open();
                string query = "select * from tbl_supplier where sname like '%" + txt_srchnme2.Text + "%'";

                SqlDataAdapter dap = new SqlDataAdapter(query, conDB.con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                metroGrid2.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        }
    }
