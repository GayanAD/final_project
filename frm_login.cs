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
namespace final_project
{
    public partial class frm_login : MetroFramework.Forms.MetroForm
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();

          // LOGDATA y = new LOGDATA();
          //  y.readdata();
            


        }


        private void button1_Click(object sender, EventArgs e)
        {
            int fg = 0;
            class_user h = new class_user();
            fg=h.login(txt_un.Text, txt_pwd.Text);

            if (fg == 1)
            {
                frm_da hd = new frm_da();
                hd.ShowDialog();
                LOGDATA hhh = new LOGDATA();
                hhh.logsave(txt_un.Text);

                this.Hide();
            }
            else
            {

                MessageBox.Show("invalid pwd");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }
    }
}
