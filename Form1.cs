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
    public partial class frm_customer : MetroFramework.Forms.MetroForm
    {
        public frm_customer()
        {
            InitializeComponent();
        }
        public SqlCommand cmd = null;

        private void Form1_Load(object sender, EventArgs e)
        {   
            setDataGride();
        }

        private void setDataGride()//to fill datagride
        {
            try
            {
                clz_sql.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_customer", clz_sql.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid1.DataSource = dt;
                clz_sql.con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("check database connection");
            }
        }
        private void setData()//to save button
        {
            try
            {
                cmd = new SqlCommand();
                clz_sql.con.Open();
              

                //pass data to database
                cmd.Connection = clz_sql.con;
                cmd.CommandText = "INSERT INTO tbl_customer VALUSE ('" + txt_cid.Text + "','" + txt_cfnme.Text + "','" + txt_mnme.Text + "','" + txt_lnme.Text + "','" + txt_add1.Text + "','" + txt_add2.Text + "','" + txt_add3.Text + "','" + txt_cmno.Text + "','" + txt_cemail.Text + "')";
                MessageBox.Show("Data Inserted");
                clz_sql.con.Close();
                setDataGride();
                toClearText(); 
            }
            catch (Exception e)
            {
                MessageBox.Show("inserted error");
            }
        }
        private void updateData()//to edit button
        {
            try
            {
                cmd = new SqlCommand();
                clz_sql.con.Open();
                cmd.Connection = clz_sql.con;
                cmd.CommandText = "UPDATE tbl_customer(cfname,cmname,clname,caddress1,caddress2,caddress3,cmobile_no,cemail) VALUSE ('" + txt_cfnme.Text + "','" + txt_mnme.Text + "','" + txt_lnme.Text + "','" + txt_add1.Text + "','" + txt_add2.Text + "','" + txt_add3.Text + "','" + txt_cmno.Text + "','" + txt_cemail.Text + "')WHERE cus_ID='" + txt_cid.Text + "'";
                MessageBox.Show("Data Updated");
                clz_sql.con.Close();
                setDataGride();
                toClearText();

            }
            catch (Exception e)
            {
                MessageBox.Show("Update Error");
            }
        }
        private void getValueFromDataGride()//get selected data
        {
            
            txt_cid.Text = metroGrid1.CurrentRow.Cells["cus_ID"].Value.ToString();
            txt_cfnme.Text = metroGrid1.CurrentRow.Cells["cfname"].Value.ToString();
            txt_mnme.Text = metroGrid1.CurrentRow.Cells["cmname"].Value.ToString();
            txt_lnme.Text = metroGrid1.CurrentRow.Cells["clname"].Value.ToString();
            txt_add1.Text = metroGrid1.CurrentRow.Cells["caddress1"].Value.ToString();
            txt_add2.Text = metroGrid1.CurrentRow.Cells["caddress2"].Value.ToString();
            txt_add3.Text = metroGrid1.CurrentRow.Cells["caddress3"].Value.ToString();
            txt_cmno.Text = metroGrid1.CurrentRow.Cells["cmobile_no"].Value.ToString();
            txt_cemail.Text = metroGrid1.CurrentRow.Cells["cemail"].Value.ToString();
        }

        private void toClearText()
        {
            txt_cid.Clear();
            txt_cfnme.Clear();
            txt_mnme.Clear();
            txt_lnme.Clear();
            txt_add1.Clear();
            txt_add2.Clear();
            txt_add3.Clear();
            txt_cmno.Clear();
            txt_cemail.Clear();
            
         }
        private void deleteData()
        {
            string cid = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                cmd = new SqlCommand();
                clz_sql.con.Open();
                cmd.Connection = clz_sql.con;
                cmd.CommandText = "DELETE FROM tbl_customer WHERE cus_ID=@cid";
                MessageBox.Show("Selected Record is Deleted");
                clz_sql.con.Close();
                setDataGride();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error, Can not delete selected record");
            }
        }
        private void searchCustomer() //to search button
        {
            try
            {
                clz_sql.con.Open();
                int cid = Convert.ToInt32(txt_srchid.Text);
                string cname = txt_srchnme.Text;
                if (cid != null && cname != null)
                {
                    SqlDataAdapter dap = new SqlDataAdapter("SELECT *FROM tbl_customer WHERE sup_ID LIKE '%" + cid + "%' AND sname LIKE '%" + cname + "%'", clz_sql.con);
                    DataTable dt = new DataTable();
                    dap.Fill(dt);
                    metroGrid1.DataSource = dt;
                    metroGrid1.Refresh();
                }

                if (metroGrid1.DataSource == null)
                {
                    MessageBox.Show("Not Found Data");
                }
                clz_sql.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error,can not find");
            }
        
        }
        private void htmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txt_cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            setData();
            toClearText();
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getValueFromDataGride();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updateData();
            toClearText();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //?????????????????????????????????????????
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            searchCustomer();
            txt_srchid.Clear();
            txt_srchnme.Clear();
        }
    }
}
