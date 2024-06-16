namespace Lab2
{
    partial class Lab2_Bai3
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
            Thoat = new Button();
            Xoa = new Button();
            ReadFile = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            richTextBox_result = new RichTextBox();
            SuspendLayout();
            // 
            // Thoat
            // 
            Thoat.BackColor = Color.White;
            Thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.ForeColor = Color.Black;
            Thoat.Location = new Point(28, 364);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(194, 64);
            Thoat.TabIndex = 12;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // Xoa
            // 
            Xoa.BackColor = Color.White;
            Xoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.ForeColor = Color.Black;
            Xoa.Location = new Point(28, 294);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(194, 64);
            Xoa.TabIndex = 11;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = false;
            Xoa.Click += Xoa_Click;
            // 
            // ReadFile
            // 
            ReadFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadFile.ForeColor = Color.Black;
            ReadFile.Location = new Point(28, 134);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(194, 64);
            ReadFile.TabIndex = 9;
            ReadFile.Text = "XỬ LÝ FILE";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 8;
            label2.Text = "Tính toán biểu thức";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 50);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 7;
            label1.Text = "BÀI 3";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(28, 214);
            button1.Name = "button1";
            button1.Size = new Size(194, 64);
            button1.TabIndex = 14;
            button1.Text = "XEM FILE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox_result
            // 
            richTextBox_result.Location = new Point(263, 134);
            richTextBox_result.Name = "richTextBox_result";
            richTextBox_result.ReadOnly = true;
            richTextBox_result.Size = new Size(503, 294);
            richTextBox_result.TabIndex = 15;
            richTextBox_result.Text = "";
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_result);
            Controls.Add(button1);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(ReadFile);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "Lab2_Bai3";
            Text = "Lab1_Bai3";
            Load += Lab2_Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Thoat;
        private Button Xoa;
        private Button ReadFile;
        private Label label2;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox_result;
    }
}