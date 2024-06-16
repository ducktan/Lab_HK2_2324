namespace Lab3_Client
{
    partial class Lab3_Bai4_C
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            CBut = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 9;
            label1.Text = "BÀI 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 339);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 12;
            label3.Text = "Your name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(646, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 391);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(646, 27);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 387);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 14;
            label2.Text = "Message:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 451);
            button1.Name = "button1";
            button1.Size = new Size(152, 43);
            button1.TabIndex = 16;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = true;
            // 
            // CBut
            // 
            CBut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBut.Location = new Point(213, 451);
            CBut.Name = "CBut";
            CBut.Size = new Size(152, 43);
            CBut.TabIndex = 18;
            CBut.Text = "CONNECT";
            CBut.UseVisualStyleBackColor = true;
            CBut.Click += CBut_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(744, 287);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "";
            // 
            // Lab3_Bai4_C
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(richTextBox1);
            Controls.Add(CBut);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Lab3_Bai4_C";
            Text = "Lab3_Bai4_C";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button Send;
        private Button button1;
        private Button CBut;
        private RichTextBox richTextBox1;
    }
}