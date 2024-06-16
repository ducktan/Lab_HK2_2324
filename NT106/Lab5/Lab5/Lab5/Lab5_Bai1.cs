using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Lab5
{
    public partial class Lab5_Bai1 : Form
    {
        public Lab5_Bai1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailFrom = fromBox.Text.ToString().Trim();
                string mailTo = toBox.Text.ToString().Trim();   
                string passM = Pass.Text.ToString().Trim();

                var basicCredential = new NetworkCredential(mailFrom, passM);
                using (MailMessage mailMessage = new MailMessage())
                {
                    MailAddress fromAdd = new MailAddress(mailFrom);
                    smtpClient.UseDefaultCredentials = false; 
                    smtpClient.Credentials = basicCredential;

                    mailMessage.From = fromAdd;
                    mailMessage.Subject = Sub.Text.ToString().Trim(); 

                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = Body.Text.ToString(); 
                    mailMessage.To.Add(mailTo);
                    try
                    {
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Send mail successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }
    }
}
