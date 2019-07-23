namespace Client
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.textMsg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btSend = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.listOnline = new System.Windows.Forms.ListBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textConnect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textMsg
            // 
            this.textMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMsg.ForeColor = System.Drawing.Color.Black;
            this.textMsg.Location = new System.Drawing.Point(78, 406);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(405, 19);
            this.textMsg.TabIndex = 1;
            this.textMsg.TextChanged += new System.EventHandler(this.textMsg_TextChanged);
            this.textMsg.Enter += new System.EventHandler(this.textMsg_Enter);
            this.textMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMsg_KeyPress);
            this.textMsg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textMsg_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(765, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 452);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(-2, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 6);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 6);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 448);
            this.panel4.TabIndex = 4;
            // 
            // btSend
            // 
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.btSend.Location = new System.Drawing.Point(486, 400);
            this.btSend.Margin = new System.Windows.Forms.Padding(0);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(64, 25);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel5.Location = new System.Drawing.Point(77, 422);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 1);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "List Online";
            // 
            // textStatus
            // 
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Location = new System.Drawing.Point(59, 55);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(371, 292);
            this.textStatus.TabIndex = 11;
            this.textStatus.TextChanged += new System.EventHandler(this.textStatus_TextChanged);
            // 
            // listOnline
            // 
            this.listOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOnline.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOnline.FormattingEnabled = true;
            this.listOnline.ItemHeight = 16;
            this.listOnline.Location = new System.Drawing.Point(608, 80);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(120, 192);
            this.listOnline.TabIndex = 13;
            // 
            // textDate
            // 
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(659, 420);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(105, 14);
            this.textDate.TabIndex = 14;
            this.textDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textTime
            // 
            this.textTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTime.Location = new System.Drawing.Point(659, 400);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(105, 14);
            this.textTime.TabIndex = 14;
            this.textTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.Location = new System.Drawing.Point(454, 43);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(29, 29);
            this.btClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btClear.TabIndex = 12;
            this.btClear.TabStop = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(739, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Client.Properties.Resources.khung_hien_thi_thong_tin;
            this.pictureBox4.Location = new System.Drawing.Point(598, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 237);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // textConnect
            // 
            this.textConnect.AutoSize = true;
            this.textConnect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConnect.Location = new System.Drawing.Point(89, 29);
            this.textConnect.Name = "textConnect";
            this.textConnect.Size = new System.Drawing.Size(61, 16);
            this.textConnect.TabIndex = 9;
            this.textConnect.Text = "List Online";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(770, 448);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.listOnline);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.PictureBox btClear;
        private System.Windows.Forms.ListBox listOnline;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Label textConnect;
    }
}