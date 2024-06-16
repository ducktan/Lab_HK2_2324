namespace Lab5
{
    partial class Lab5_Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            total = new RichTextBox();
            label3 = new Label();
            login = new Button();
            pass = new RichTextBox();
            label2 = new Label();
            mail = new RichTextBox();
            label1 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(108, 185);
            listView1.Name = "listView1";
            listView1.Size = new Size(882, 254);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // total
            // 
            total.Location = new Point(108, 136);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(882, 30);
            total.TabIndex = 16;
            total.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 15;
            label3.Text = "Subject";
            // 
            // login
            // 
            login.Location = new Point(108, 455);
            login.Name = "login";
            login.Size = new Size(112, 55);
            login.TabIndex = 14;
            login.Text = "SEND";
            login.UseVisualStyleBackColor = true;
            // 
            // pass
            // 
            pass.Location = new Point(199, 81);
            pass.Name = "pass";
            pass.Size = new Size(397, 30);
            pass.TabIndex = 13;
            pass.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 81);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 12;
            label2.Text = "To";
            // 
            // mail
            // 
            mail.Location = new Point(199, 27);
            mail.Name = "mail";
            mail.Size = new Size(397, 30);
            mail.TabIndex = 11;
            mail.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 10;
            label1.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(628, 29);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 20;
            label5.Text = "Password";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(739, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(251, 30);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 22;
            label4.Text = "Body";
            // 
            // Lab5_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 522);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(login);
            Controls.Add(pass);
            Controls.Add(label2);
            Controls.Add(mail);
            Controls.Add(label1);
            Name = "Lab5_Bai3";
            Text = "Lab5_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private RichTextBox total;
        private Label label3;
        private Button login;
        private RichTextBox pass;
        private Label label2;
        private RichTextBox mail;
        private Label label1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}