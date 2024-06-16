namespace Lab2
{
    partial class Lab2_Bai2
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
            label2 = new Label();
            label3 = new Label();
            ReadFile = new Button();
            label1 = new Label();
            FileName = new TextBox();
            URL = new TextBox();
            label4 = new Label();
            lineNum = new TextBox();
            label5 = new Label();
            wordNum = new TextBox();
            label6 = new Label();
            charNum = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 69);
            label2.Name = "label2";
            label2.Size = new Size(224, 31);
            label2.TabIndex = 3;
            label2.Text = "Đọc thông tin file txt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 28);
            label3.Name = "label3";
            label3.Size = new Size(93, 41);
            label3.TabIndex = 2;
            label3.Text = "BÀI 2";
            // 
            // ReadFile
            // 
            ReadFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadFile.Location = new Point(503, 28);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(147, 53);
            ReadFile.TabIndex = 4;
            ReadFile.Text = "ĐỌC FILE";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 118);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 5;
            label1.Text = "Tên file:";
            // 
            // FileName
            // 
            FileName.Location = new Point(140, 122);
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Size = new Size(197, 27);
            FileName.TabIndex = 6;
            // 
            // URL
            // 
            URL.Location = new Point(408, 124);
            URL.Name = "URL";
            URL.ReadOnly = true;
            URL.Size = new Size(356, 27);
            URL.TabIndex = 8;
            URL.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(347, 120);
            label4.Name = "label4";
            label4.Size = new Size(60, 31);
            label4.TabIndex = 7;
            label4.Text = "URL:";
            // 
            // lineNum
            // 
            lineNum.Location = new Point(140, 176);
            lineNum.Name = "lineNum";
            lineNum.ReadOnly = true;
            lineNum.Size = new Size(132, 27);
            lineNum.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 172);
            label5.Name = "label5";
            label5.Size = new Size(104, 31);
            label5.TabIndex = 9;
            label5.Text = "Số dòng:";
            // 
            // wordNum
            // 
            wordNum.Location = new Point(389, 176);
            wordNum.Name = "wordNum";
            wordNum.ReadOnly = true;
            wordNum.Size = new Size(98, 27);
            wordNum.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(302, 176);
            label6.Name = "label6";
            label6.Size = new Size(72, 31);
            label6.TabIndex = 11;
            label6.Text = "Số từ:";
            // 
            // charNum
            // 
            charNum.Location = new Point(628, 182);
            charNum.Name = "charNum";
            charNum.ReadOnly = true;
            charNum.Size = new Size(136, 27);
            charNum.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(522, 176);
            label7.Name = "label7";
            label7.Size = new Size(100, 31);
            label7.TabIndex = 13;
            label7.Text = "Số ký tự:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 226);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(736, 212);
            textBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(656, 28);
            button1.Name = "button1";
            button1.Size = new Size(108, 53);
            button1.TabIndex = 16;
            button1.Text = "THOÁT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lab2_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(charNum);
            Controls.Add(label7);
            Controls.Add(wordNum);
            Controls.Add(label6);
            Controls.Add(lineNum);
            Controls.Add(label5);
            Controls.Add(URL);
            Controls.Add(label4);
            Controls.Add(FileName);
            Controls.Add(label1);
            Controls.Add(ReadFile);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Lab2_Bai2";
            Text = "Lab2_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button ReadFile;
        private Label label1;
        private TextBox FileName;
        private TextBox URL;
        private Label label4;
        private TextBox lineNum;
        private Label label5;
        private TextBox wordNum;
        private Label label6;
        private TextBox charNum;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
    }
}