using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int pw;
        bool Hided;

        public Form1()
        {
            InitializeComponent();
            pw = Mpanel.Width;
            Hided = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hided) button1.Text = "_\n_\n_";
            else button1.Text = "_\n_\n_";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided) {
                Mpanel.Width = Mpanel.Width + 20;
                if (Mpanel.Width >= pw)
                { 
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }else{
                Mpanel.Width = Mpanel.Width -20;
                if(Mpanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                this.Refresh();
                }
            }
        }
    }
}
