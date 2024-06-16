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
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
using System.Reflection.Emit;

namespace Lab5
{
    public partial class Lab5_Bai2 : Form
    {
        public Lab5_Bai2()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Add("Email", 400);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Thời gian", 200);
            listView1.View = View.Details;

            
            var client = new ImapClient();
            client.Connect("127.0.0.1", 143, 0);

            client.Authenticate(mail.Text, pass.Text);

            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);


            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
                ListViewItem name = new ListViewItem(message.Subject);
                ListViewItem.ListViewSubItem from = new
                ListViewItem.ListViewSubItem(name, message.From.ToString());
                name.SubItems.Add(from);
                ListViewItem.ListViewSubItem date = new
                ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                name.SubItems.Add(date);
                listView1.Items.Add(name);
            }
            total.Text = inbox.Count.ToString();
            recent.Text = inbox.Recent.ToString();
        }

    }
}
