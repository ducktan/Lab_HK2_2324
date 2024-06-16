namespace Lab2
{
    partial class Lab2_Bai4
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
            label1 = new Label();
            Xoa = new Button();
            Thoat = new Button();
            groupBox1 = new GroupBox();
            textBox_dVan = new TextBox();
            textBox_dToan = new TextBox();
            textBox_sdt = new TextBox();
            textBox_hoTen = new TextBox();
            textBox_MSSV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button_add = new Button();
            button_save = new Button();
            richTextBox_result = new RichTextBox();
            button_cal = new Button();
            button_output = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(111, 19);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 10;
            label2.Text = "Binary Formatter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 9;
            label1.Text = "BÀI 4";
            // 
            // Xoa
            // 
            Xoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.Location = new Point(530, 25);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(107, 56);
            Xoa.TabIndex = 14;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Thoat
            // 
            Thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.Location = new Point(657, 25);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(115, 56);
            Thoat.TabIndex = 15;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_dVan);
            groupBox1.Controls.Add(textBox_dToan);
            groupBox1.Controls.Add(textBox_sdt);
            groupBox1.Controls.Add(textBox_hoTen);
            groupBox1.Controls.Add(textBox_MSSV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 295);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // textBox_dVan
            // 
            textBox_dVan.Location = new Point(144, 254);
            textBox_dVan.Name = "textBox_dVan";
            textBox_dVan.Size = new Size(175, 27);
            textBox_dVan.TabIndex = 25;
            // 
            // textBox_dToan
            // 
            textBox_dToan.Location = new Point(144, 197);
            textBox_dToan.Name = "textBox_dToan";
            textBox_dToan.Size = new Size(175, 27);
            textBox_dToan.TabIndex = 24;
            // 
            // textBox_sdt
            // 
            textBox_sdt.Location = new Point(144, 148);
            textBox_sdt.Name = "textBox_sdt";
            textBox_sdt.Size = new Size(175, 27);
            textBox_sdt.TabIndex = 23;
            // 
            // textBox_hoTen
            // 
            textBox_hoTen.Location = new Point(144, 100);
            textBox_hoTen.Name = "textBox_hoTen";
            textBox_hoTen.Size = new Size(175, 27);
            textBox_hoTen.TabIndex = 22;
            // 
            // textBox_MSSV
            // 
            textBox_MSSV.Location = new Point(144, 55);
            textBox_MSSV.Name = "textBox_MSSV";
            textBox_MSSV.Size = new Size(175, 27);
            textBox_MSSV.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 254);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 21;
            label7.Text = "Điểm Văn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 197);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 20;
            label6.Text = "Điểm Toán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 148);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 19;
            label5.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 18;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 17;
            label3.Text = "MSSV";
            // 
            // button_add
            // 
            button_add.Location = new Point(11, 377);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 17;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(237, 377);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 18;
            button_save.Text = "Lưu";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // richTextBox_result
            // 
            richTextBox_result.Location = new Point(370, 109);
            richTextBox_result.Name = "richTextBox_result";
            richTextBox_result.Size = new Size(402, 239);
            richTextBox_result.TabIndex = 19;
            richTextBox_result.Text = "";
            // 
            // button_cal
            // 
            button_cal.Location = new Point(370, 377);
            button_cal.Name = "button_cal";
            button_cal.Size = new Size(94, 29);
            button_cal.TabIndex = 20;
            button_cal.Text = "Tính điểm";
            button_cal.UseVisualStyleBackColor = true;
            button_cal.Click += button_cal_Click;
            // 
            // button_output
            // 
            button_output.Location = new Point(559, 377);
            button_output.Name = "button_output";
            button_output.Size = new Size(94, 29);
            button_output.TabIndex = 21;
            button_output.Text = "Xuất";
            button_output.UseVisualStyleBackColor = true;
            button_output.Click += button_output_Click;
            // 
            // Lab2_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(button_output);
            Controls.Add(button_cal);
            Controls.Add(richTextBox_result);
            Controls.Add(button_save);
            Controls.Add(button_add);
            Controls.Add(groupBox1);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab2_Bai4";
            Text = "Lab2_Bai4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button Xoa;
        private Button Thoat;
        private GroupBox groupBox1;
        private TextBox textBox_dVan;
        private TextBox textBox_dToan;
        private TextBox textBox_sdt;
        private TextBox textBox_hoTen;
        private TextBox textBox_MSSV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button_add;
        private Button button_save;
        private RichTextBox richTextBox_result;
        private Button button_cal;
        private Button button_output;
    }
}