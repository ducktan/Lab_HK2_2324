namespace Lab3_Client
{
    partial class Lab3_Bai1_C
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
            label2 = new Label();
            IP = new TextBox();
            Port = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            Send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 0;
            label1.Text = "BÀI 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 1;
            label2.Text = "IP remote host";
            // 
            // IP
            // 
            IP.Location = new Point(20, 119);
            IP.Name = "IP";
            IP.Size = new Size(377, 27);
            IP.TabIndex = 2;
            // 
            // Port
            // 
            Port.Location = new Point(499, 119);
            Port.Name = "Port";
            Port.Size = new Size(250, 27);
            Port.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(499, 75);
            label3.Name = "label3";
            label3.Size = new Size(55, 31);
            label3.TabIndex = 3;
            label3.Text = "Port";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 208);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(729, 143);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 5;
            label4.Text = "Message";
            // 
            // Send
            // 
            Send.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send.Location = new Point(27, 388);
            Send.Name = "Send";
            Send.Size = new Size(162, 37);
            Send.TabIndex = 7;
            Send.Text = "SEND";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Lab3_Bai1_C
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Send);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(Port);
            Controls.Add(label3);
            Controls.Add(IP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab3_Bai1_C";
            Text = "Lab3_Bai1_C";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IP;
        private TextBox Port;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button Send;
    }
}