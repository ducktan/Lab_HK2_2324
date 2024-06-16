namespace Lab2
{
    partial class Lab2_Bai1
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
            ReadFile = new Button();
            WriteFile = new Button();
            Xoa = new Button();
            Thoat = new Button();
            Textshow = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 0;
            label1.Text = "BÀI 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 63);
            label2.Name = "label2";
            label2.Size = new Size(163, 31);
            label2.TabIndex = 1;
            label2.Text = "Ghi và đọc File";
            // 
            // ReadFile
            // 
            ReadFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadFile.Location = new Point(32, 143);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(194, 64);
            ReadFile.TabIndex = 2;
            ReadFile.Text = "ĐỌC FILE";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // WriteFile
            // 
            WriteFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WriteFile.Location = new Point(32, 224);
            WriteFile.Name = "WriteFile";
            WriteFile.Size = new Size(194, 64);
            WriteFile.TabIndex = 3;
            WriteFile.Text = "GHI FILE";
            WriteFile.UseVisualStyleBackColor = true;
            WriteFile.Click += WriteFile_Click_1;
            // 
            // Xoa
            // 
            Xoa.BackColor = Color.White;
            Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.Location = new Point(32, 308);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(82, 64);
            Xoa.TabIndex = 4;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = false;
            Xoa.Click += Xoa_Click;
            // 
            // Thoat
            // 
            Thoat.BackColor = Color.White;
            Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.Location = new Point(139, 308);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(87, 64);
            Thoat.TabIndex = 5;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // Textshow
            // 
            Textshow.Location = new Point(259, 85);
            Textshow.Multiline = true;
            Textshow.Name = "Textshow";
            Textshow.Size = new Size(518, 287);
            Textshow.TabIndex = 6;
            // 
            // Lab2_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(Textshow);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(WriteFile);
            Controls.Add(ReadFile);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab2_Bai1";
            Text = "Lab2_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ReadFile;
        private Button WriteFile;
        private Button Xoa;
        private Button Thoat;
        private TextBox Textshow;
    }
}