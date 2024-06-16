namespace Lab5
{
    partial class Lab5_Bai2
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
            label1 = new Label();
            mail = new RichTextBox();
            pass = new RichTextBox();
            label2 = new Label();
            login = new Button();
            label3 = new Label();
            total = new RichTextBox();
            recent = new RichTextBox();
            label4 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // mail
            // 
            mail.Location = new Point(177, 27);
            mail.Name = "mail";
            mail.Size = new Size(397, 30);
            mail.TabIndex = 1;
            mail.Text = "";
            // 
            // pass
            // 
            pass.Location = new Point(177, 85);
            pass.Name = "pass";
            pass.Size = new Size(397, 30);
            pass.TabIndex = 3;
            pass.Text = "";
            pass.TextChanged += richTextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 87);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // login
            // 
            login.Location = new Point(652, 27);
            login.Name = "login";
            login.Size = new Size(92, 88);
            login.TabIndex = 4;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 171);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 5;
            label3.Text = "Total";
            // 
            // total
            // 
            total.Location = new Point(116, 169);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(131, 30);
            total.TabIndex = 6;
            total.Text = "";
            // 
            // recent
            // 
            recent.Location = new Point(443, 169);
            recent.Name = "recent";
            recent.ReadOnly = true;
            recent.Size = new Size(131, 30);
            recent.TabIndex = 8;
            recent.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(352, 171);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 7;
            label4.Text = "Recent";
            // 
            // listView1
            // 
            listView1.Location = new Point(32, 216);
            listView1.Name = "listView1";
            listView1.Size = new Size(712, 254);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Lab5_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(listView1);
            Controls.Add(recent);
            Controls.Add(label4);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(login);
            Controls.Add(pass);
            Controls.Add(label2);
            Controls.Add(mail);
            Controls.Add(label1);
            Name = "Lab5_Bai2";
            Text = "Lab5_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox mail;
        private RichTextBox pass;
        private Label label2;
        private Button login;
        private Label label3;
        private RichTextBox total;
        private RichTextBox recent;
        private Label label4;
        private ListView listView1;
    }
}