namespace Lab4
{
    partial class Lab4_Bai3
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
            url_textBox = new TextBox();
            locationDown = new TextBox();
            downBut = new Button();
            WebContent = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // url_textBox
            // 
            url_textBox.Location = new Point(15, 17);
            url_textBox.Name = "url_textBox";
            url_textBox.Size = new Size(626, 27);
            url_textBox.TabIndex = 1;
            // 
            // locationDown
            // 
            locationDown.Location = new Point(15, 65);
            locationDown.Name = "locationDown";
            locationDown.Size = new Size(626, 27);
            locationDown.TabIndex = 2;
            // 
            // downBut
            // 
            downBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downBut.Location = new Point(663, 18);
            downBut.Name = "downBut";
            downBut.Size = new Size(110, 74);
            downBut.TabIndex = 3;
            downBut.Text = "DOWNLOAD";
            downBut.UseVisualStyleBackColor = true;
            downBut.Click += downBut_Click;
            // 
            // WebContent
            // 
            WebContent.Location = new Point(20, 120);
            WebContent.Name = "WebContent";
            WebContent.Size = new Size(747, 304);
            WebContent.TabIndex = 4;
            WebContent.Text = "";
            // 
            // Lab4_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WebContent);
            Controls.Add(downBut);
            Controls.Add(locationDown);
            Controls.Add(url_textBox);
            Controls.Add(label1);
            Name = "Lab4_Bai3";
            Text = "Lab4_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox url_textBox;
        private TextBox locationDown;
        private Button downBut;
        private RichTextBox WebContent;
    }
}