using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;

namespace final_project
{
    public partial class frm_email : Form
    {
        public frm_email()
        {
            InitializeComponent();
        }

        private void frm_email_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  try
          //  {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("hasanidivangani@gmail.com", "hdkprkmkkds25");
                MailMessage ms = new MailMessage();
                ms.To.Add(txt_to.Text);
                ms.From = new MailAddress("ashanpromod11@gmail.com");
                ms.Subject = txt_sub.Text;
                ms.Body = txt_msg.Text;
               // Attachment at = new Attachment(txt_attach.Text);
              //  ms.Attachments.Add(at);
                client.Send(ms);
                MessageBox.Show("Sucesssfully send message");

            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
