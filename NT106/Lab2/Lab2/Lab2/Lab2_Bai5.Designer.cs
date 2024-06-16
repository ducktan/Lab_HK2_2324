namespace Lab2
{
    partial class Lab2_Bai5
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
            listView1 = new ListView();
            TEN_FILE = new ColumnHeader();
            SIZE = new ColumnHeader();
            Extend = new ColumnHeader();
            Date_Modify = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 12;
            label2.Text = "File Explorer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 11;
            label1.Text = "BÀI 5";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { TEN_FILE, SIZE, Extend, Date_Modify });
            listView1.Location = new Point(19, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(787, 339);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(295, 36);
            button1.Name = "button1";
            button1.Size = new Size(142, 45);
            button1.TabIndex = 14;
            button1.Text = "LOAD ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(479, 36);
            button2.Name = "button2";
            button2.Size = new Size(147, 45);
            button2.TabIndex = 15;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(642, 36);
            button3.Name = "button3";
            button3.Size = new Size(164, 45);
            button3.TabIndex = 16;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lab2_Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 461);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab2_Bai5";
            Text = "Lab2_Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader TEN_FILE;
        private ColumnHeader SIZE;
        private ColumnHeader Extend;
        private ColumnHeader Date_Modify;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}