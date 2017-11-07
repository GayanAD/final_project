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
using Tulpep.NotificationWindow;
using mycon;
using System.Data.SqlClient;
namespace final_project
{
    public partial class frm_setting : MetroFramework.Forms.MetroForm
    {
        int pw;
        bool Hided;
        public frm_setting()
        {
            InitializeComponent();
            pw = Mpanel.Width;
            Hided = false;
        }
        public void setDataGride2()//to fill datagride
        {
            try
            {
                conDB.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_item_master", conDB.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid2.DataSource = dt;
                conDB.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("can not fill datagride,,check database connection");
            }
        }
        private void frm_order_Load(object sender, EventArgs e)
        {
            Mpanel.Hide();
            Hided = true;
            setDataGride2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string type = comboBox1.SelectedIndex.ToString();
            string un = txt_un.Text;
            string pwd = txt_pwd.Text;
            string cnf = txt_cpwd.Text;
                if (txt_un.Text.Length > 0)
                {
                    errorProvider3.Clear();
                    if (txt_pwd.Text.Length > 0)
                    {
                        errorProvider1.Clear();
                        if (txt_cpwd.Text.Length > 0)
                        {
                            errorProvider1.Clear();
                        }
                        else
                            errorProvider1.SetError(txt_un, "Required");
                    }
                    else
                        errorProvider1.SetError(txt_cpwd, "Requierd");
                }
                else
                    errorProvider3.SetError(txt_un, "Requierd");
                int flag = 0;

                if (pwd == cnf)
                {
                    errorProvider1.Clear();
                    class_user u = new class_user();
                   
                    flag = u.add(un, pwd);
                }
                else
                    errorProvider1.SetError(txt_pwd, "Password not matching");
           

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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txt_siz.Clear();
            txt_mat.Clear();
            txt_clr.Clear();
            txt_cat.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_siz.Text.Length > 0)
            {
                errorProvider1.Clear();
                if (txt_clr.Text.Length > 0)
                {
                    errorProvider3.Clear();
                    if (txt_cat.Text.Length > 0)
                    {
                        errorProvider1.Clear();
                        if (txt_mat.Text.Length > 0)
                        {
                            errorProvider1.Clear();
                            class_user u = new class_user();
                            int flag = 0;
                            flag = u.add(txt_cat.Text, txt_mat.Text, txt_clr.Text, txt_siz.Text);
                            setDataGride2();
                            clear();
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
                        else
                            errorProvider1.SetError(txt_mat, "Required");
                    }
                    else
                        errorProvider1.SetError(txt_cat, "Requierd");
                }
                else
                    errorProvider3.SetError(txt_clr, "Requierd");
            }
            else
                errorProvider1.SetError(txt_siz, "Required");
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_ino.Text = metroGrid2.CurrentRow.Cells["itm_id"].Value.ToString();
            txt_cat.Text = metroGrid2.CurrentRow.Cells["ctgyr"].Value.ToString();
            txt_mat.Text = metroGrid2.CurrentRow.Cells["mtrial"].Value.ToString();
            txt_clr.Text = metroGrid2.CurrentRow.Cells["clr"].Value.ToString();
            txt_siz.Text = metroGrid2.CurrentRow.Cells["size"].Value.ToString();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txt_ino.Text);
            class_user U = new class_user();
            int flag = 0;
           flag= U.update(txt_cat.Text, txt_mat.Text, txt_clr.Text, txt_siz.Text, id);
           setDataGride2();
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

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ino.Text);
            int flag = 0;
            class_user u = new class_user();
         flag=   u.delete(id);
         setDataGride2();
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

        private void tabPage3_MouseClick(object sender, MouseEventArgs e)
        {
            
       
            // Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");*/
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {


                string text = System.IO.File.ReadAllText(@"E:\final_project\logdata\logdata.log");
                string hh = null;
                // Display the file contents to the console. Variable text is a string.
                // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

                // Example #2
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] lines = System.IO.File.ReadAllLines(@"E:\final_project\logdata\logdata.log");

                // Display the file contents by using a foreach loop.
                System.Console.WriteLine("Contents of WriteLines2.txt = ");
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    //  Console.WriteLine("\t" + line);
                    hh += line + "\n";
                }

                MessageBox.Show(hh);

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int ff = 0;
            if (p.Text == cp.Text)
            {

                class_user h = new class_user();
               ff= h.updt_pwd(u.Text, p.Text);
               if (ff > 0)
               {

                   PopupNotifier popup = new Tulpep.NotificationWindow.PopupNotifier();
                   popup.Image = Properties.Resources.Information_Bubble_48;
                   popup.ContentText = "Success";
                   // popup.BodyColor.ToString();
                   popup.Popup();

               }
               else
               {
                   MessageBox.Show("Error ", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);

               }

            }
            else
                MessageBox.Show("Both Password Should be same ", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
        
        
    }
}
