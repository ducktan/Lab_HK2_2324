﻿namespace Lab3_Client
{
    partial class Lab3_Bai3_C
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
            Send = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Send
            // 
            Send.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send.Location = new Point(32, 376);
            Send.Name = "Send";
            Send.Size = new Size(162, 37);
            Send.TabIndex = 15;
            Send.Text = "SEND";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 113);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(729, 242);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 69);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 13;
            label4.Text = "Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 8;
            label1.Text = "BÀI 3";
            // 
            // Lab3_Bai3_C
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Send);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Lab3_Bai3_C";
            Text = "Lab3_Bai3_C";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Send;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
    }
}