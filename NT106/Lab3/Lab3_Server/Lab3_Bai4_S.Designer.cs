namespace Lab3_Server
{
    partial class Lab3_Bai4_S
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
            label4 = new Label();
            btn_Listen = new Button();
            lv_Message = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 25;
            label1.Text = "BÀI 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 85);
            label4.Name = "label4";
            label4.Size = new Size(188, 31);
            label4.TabIndex = 26;
            label4.Text = "Receive Message";
            // 
            // btn_Listen
            // 
            btn_Listen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(595, 85);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(162, 37);
            btn_Listen.TabIndex = 27;
            btn_Listen.Text = "LISTEN";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(51, 131);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(707, 287);
            lv_Message.TabIndex = 28;
            lv_Message.Text = "";
            // 
            // Lab3_Bai4_S
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv_Message);
            Controls.Add(btn_Listen);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Lab3_Bai4_S";
            Text = "Lab3_Bai4_S";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button btn_Listen;
        private RichTextBox lv_Message;
    }
}