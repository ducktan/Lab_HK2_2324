namespace Lab4
{
    partial class Lab4_Bai1
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
            url_Textbox = new TextBox();
            GET_button = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // url_Textbox
            // 
            url_Textbox.Location = new Point(12, 63);
            url_Textbox.Name = "url_Textbox";
            url_Textbox.Size = new Size(607, 27);
            url_Textbox.TabIndex = 0;
            url_Textbox.TextChanged += url_Textbox_TextChanged;
            // 
            // GET_button
            // 
            GET_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GET_button.Location = new Point(641, 53);
            GET_button.Name = "GET_button";
            GET_button.Size = new Size(121, 39);
            GET_button.TabIndex = 1;
            GET_button.Text = "GET";
            GET_button.UseVisualStyleBackColor = true;
            GET_button.Click += GET_button_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 114);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(745, 313);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
           
            // 
            // Lab4_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(GET_button);
            Controls.Add(url_Textbox);
            Name = "Lab4_Bai1";
            Text = "Lab4_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox url_Textbox;
        private Button GET_button;
        private RichTextBox richTextBox1;
    }
}