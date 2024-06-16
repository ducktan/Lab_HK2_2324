namespace Lab5
{
    partial class Lab5_Bai1
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
            fromBox = new RichTextBox();
            toBox = new RichTextBox();
            Pass = new RichTextBox();
            label3 = new Label();
            Send = new Button();
            label4 = new Label();
            Sub = new RichTextBox();
            label5 = new Label();
            Body = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 86);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // fromBox
            // 
            fromBox.Location = new Point(178, 28);
            fromBox.Name = "fromBox";
            fromBox.Size = new Size(327, 27);
            fromBox.TabIndex = 2;
            fromBox.Text = "";
            // 
            // toBox
            // 
            toBox.Location = new Point(178, 87);
            toBox.Name = "toBox";
            toBox.Size = new Size(327, 27);
            toBox.TabIndex = 3;
            toBox.Text = "";
            // 
            // Pass
            // 
            Pass.Location = new Point(610, 25);
            Pass.Name = "Pass";
            Pass.Size = new Size(237, 27);
            Pass.TabIndex = 5;
            Pass.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 24);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // Send
            // 
            Send.Location = new Point(12, 24);
            Send.Name = "Send";
            Send.Size = new Size(67, 88);
            Send.TabIndex = 6;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 156);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 7;
            label4.Text = "Subject:";
            label4.Click += label4_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(178, 157);
            Sub.Name = "Sub";
            Sub.Size = new Size(672, 27);
            Sub.TabIndex = 8;
            Sub.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 202);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 9;
            label5.Text = "Body:";
            // 
            // Body
            // 
            Body.Location = new Point(74, 247);
            Body.Name = "Body";
            Body.Size = new Size(776, 174);
            Body.TabIndex = 10;
            Body.Text = "";
            // 
            // Lab5_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 450);
            Controls.Add(Body);
            Controls.Add(label5);
            Controls.Add(Sub);
            Controls.Add(label4);
            Controls.Add(Send);
            Controls.Add(Pass);
            Controls.Add(label3);
            Controls.Add(toBox);
            Controls.Add(fromBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab5_Bai1";
            Text = "Lab5_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox fromBox;
        private RichTextBox toBox;
        private RichTextBox Pass;
        private Label label3;
        private Button Send;
        private Label label4;
        private RichTextBox Sub;
        private Label label5;
        private RichTextBox Body;
    }
}