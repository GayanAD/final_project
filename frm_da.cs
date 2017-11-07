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
    public partial class frm_da : MetroFramework.Forms.MetroForm
    {
        public frm_da()
        {
            InitializeComponent();
        }

        private void frm_da_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            timer1.Start();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Pink;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Orange;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightPink;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.YellowGreen;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumVioletRed;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumOrchid;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Brown;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            button5.BackColor = Color.RosyBrown;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkOrchid;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Purple;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightSkyBlue;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            frm_sales_order fc = new frm_sales_order();
            fc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_purchase fp = new frm_purchase();
            fp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_product fp = new frm_product();
            fp.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_setting_log j = new frm_setting_log(); j.ShowDialog();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.ShowDialog();
            this.Hide();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timer1.Stop();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_report fr = new frm_report();
            fr.ShowDialog();
            this.Hide();
        }
    }
}
