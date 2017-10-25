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
    public partial class frm_supplier : MetroFramework.Forms.MetroForm
    {
        public frm_supplier()
        {
            InitializeComponent();
        }
        public SqlCommand cmd = null;
        private void frm_supplier_Load(object sender, EventArgs e)
        {
            setDataGride();
        }
       

        private void setDataGride()//to fill datagride
        {
            try
            {
                clz_sql.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_supplier", clz_sql.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid1.DataSource = dt;
                clz_sql.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("can not fill datagride,,check database connection");
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
                cmd.CommandText = "INSERT INTO tbl_supplier VALUSE ('" + txt_sfnme.Text + "','" + txt_sadd1.Text + "','" + txt_sadd2.Text + "','" + txt_sadd3.Text + "','" + txt_smno.Text + "','" + txt_semail.Text + "','" + txt_c_nme.Text + "')";
                MessageBox.Show("Data Inserted");
                clz_sql.con.Close();
                metroGrid1.Refresh();
                toClearTextField();
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
                cmd.CommandText = "UPDATE tbl_supplier(sname,saddress1,saddress2,saddress3,smobile_no,semail,company_name) VALUSE ('" + txt_sfnme + "','" + txt_sadd1.Text + "','" + txt_sadd2.Text + "','" + txt_sadd3.Text+ "','" + txt_smno.Text + "','" + txt_semail.Text + "','" + txt_c_nme.Text + "')WHERE sup_ID='" + txt_sid.Text+ "'";
                MessageBox.Show("Data Updated");
                clz_sql.con.Close();
                metroGrid1.Refresh();
                toClearTextField();

            }
            catch (Exception e)
            {
                MessageBox.Show("Update Error");
            }
        }
        private void getValueFromDataGride()//get selected data
        {

            txt_sid.Text = metroGrid1.CurrentRow.Cells["sup_ID"].Value.ToString();
            txt_sfnme.Text = metroGrid1.CurrentRow.Cells["sname"].Value.ToString();
            txt_sadd1.Text = metroGrid1.CurrentRow.Cells["saddress1"].Value.ToString();
            txt_sadd2.Text = metroGrid1.CurrentRow.Cells["saddress2"].Value.ToString();
            txt_sadd3.Text = metroGrid1.CurrentRow.Cells["saddress3"].Value.ToString();
            txt_smno.Text = metroGrid1.CurrentRow.Cells["smobile_no"].Value.ToString();
            txt_semail.Text = metroGrid1.CurrentRow.Cells["semail"].Value.ToString();
            txt_c_nme.Text = metroGrid1.CurrentRow.Cells["company_name"].Value.ToString();

        }

        private void toClearTextField()
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
        private void deleteData()//to delete button
        {
            string sid = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                cmd = new SqlCommand();
                clz_sql.con.Open();
                cmd.Connection = clz_sql.con;
                cmd.CommandText = "DELETE FROM tbl_supplier WHERE sup_ID=@sid";
                MessageBox.Show("Selected Record is Deleted");
                clz_sql.con.Close();
                metroGrid1.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error, Can not delete selected record");
            }
        }
        private void searchSupplier() //to search button
        {
            try 
            {
                clz_sql.con.Open();
                int sid = Convert.ToInt32(txt_srchid.Text);
                string sname = txt_srchnme.Text;
                if (sid != null && sname != null)
                {
                    SqlDataAdapter dap = new SqlDataAdapter("SELECT *FROM tbl_supplier WHERE sup_ID LIKE '%" + sid + "%' AND sname LIKE '%" + sname + "%'", clz_sql.con);
                    DataTable dt = new DataTable();
                    dap.Fill(dt);
                    metroGrid1.DataSource = dt;
                    metroGrid1.Refresh();
                }

                if(metroGrid1.DataSource==null)
                {
                 MessageBox.Show("Not Found Data");
                }
                clz_sql.con.Close();
            }
            catch(Exception e)
            {
            MessageBox.Show("Error,can not find");
            }
        
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            setData();
            toClearTextField();
            
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updateData();
            toClearTextField();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //???????
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            searchSupplier();
            txt_srchid.Clear();
            txt_srchnme.Clear();
        }

        private void txt_sid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
