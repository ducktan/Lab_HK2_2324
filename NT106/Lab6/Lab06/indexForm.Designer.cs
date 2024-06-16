namespace Lab06
{
    partial class indexForm
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.joinPort = new System.Windows.Forms.TextBox();
            this.joinIP = new System.Windows.Forms.TextBox();
            this.joinUsername = new System.Windows.Forms.TextBox();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.White;
            this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClient.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Black;
            this.btnClient.Location = new System.Drawing.Point(515, 215);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(265, 49);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Tham gia 1 ván";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.White;
            this.btnServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnServer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.Black;
            this.btnServer.Location = new System.Drawing.Point(515, 146);
            this.btnServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(265, 43);
            this.btnServer.TabIndex = 5;
            this.btnServer.Text = "Tạo 1 ván mới";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // joinPort
            // 
            this.joinPort.BackColor = System.Drawing.Color.White;
            this.joinPort.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinPort.ForeColor = System.Drawing.Color.Black;
            this.joinPort.Location = new System.Drawing.Point(225, 215);
            this.joinPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joinPort.MaxLength = 5;
            this.joinPort.Name = "joinPort";
            this.joinPort.Size = new System.Drawing.Size(208, 31);
            this.joinPort.TabIndex = 2;
            this.joinPort.Text = "65535";
            this.joinPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinIP
            // 
            this.joinIP.BackColor = System.Drawing.Color.White;
            this.joinIP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinIP.ForeColor = System.Drawing.Color.Black;
            this.joinIP.Location = new System.Drawing.Point(225, 158);
            this.joinIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joinIP.Name = "joinIP";
            this.joinIP.Size = new System.Drawing.Size(208, 31);
            this.joinIP.TabIndex = 1;
            this.joinIP.Text = "localhost";
            this.joinIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinUsername
            // 
            this.joinUsername.BackColor = System.Drawing.Color.White;
            this.joinUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinUsername.ForeColor = System.Drawing.Color.Black;
            this.joinUsername.Location = new System.Drawing.Point(225, 110);
            this.joinUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joinUsername.Name = "joinUsername";
            this.joinUsername.Size = new System.Drawing.Size(208, 31);
            this.joinUsername.TabIndex = 0;
            this.joinUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hostPort
            // 
            this.hostPort.BackColor = System.Drawing.Color.White;
            this.hostPort.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostPort.ForeColor = System.Drawing.Color.Black;
            this.hostPort.Location = new System.Drawing.Point(225, 273);
            this.hostPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hostPort.MaxLength = 5;
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(208, 31);
            this.hostPort.TabIndex = 4;
            this.hostPort.Text = "65535";
            this.hostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "GUESS NUMBER";
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.joinUsername);
            this.Controls.Add(this.joinIP);
            this.Controls.Add(this.joinPort);
            this.Controls.Add(this.btnServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "indexForm";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.TextBox joinPort;
        private System.Windows.Forms.TextBox joinIP;
        private System.Windows.Forms.TextBox joinUsername;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}