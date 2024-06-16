namespace Lab3_Server
{
    partial class Lab3_Bai1_S
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
            Port = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            Listen = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Port
            // 
            Port.Location = new Point(32, 106);
            Port.Name = "Port";
            Port.Size = new Size(250, 27);
            Port.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 72);
            label3.Name = "label3";
            label3.Size = new Size(55, 31);
            label3.TabIndex = 11;
            label3.Text = "Port";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 217);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(713, 199);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 170);
            label4.Name = "label4";
            label4.Size = new Size(188, 31);
            label4.TabIndex = 13;
            label4.Text = "Receive Message";
            label4.Click += label4_Click;
            // 
            // Listen
            // 
            Listen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Listen.Location = new Point(588, 106);
            Listen.Name = "Listen";
            Listen.Size = new Size(162, 37);
            Listen.TabIndex = 15;
            Listen.Text = "LISTEN";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 8;
            label1.Text = "BÀI 1";
            // 
            // Lab3_Bai1_S
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Listen);
            Controls.Add(label4);
            Controls.Add(Port);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Lab3_Bai1_S";
            Text = "Lab3_Bai1_S";
            Load += Lab3_Bai1_S_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Port;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button Listen;
        private Label label1;
    }
}