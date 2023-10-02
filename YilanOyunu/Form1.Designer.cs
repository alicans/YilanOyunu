namespace YilanOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSaha = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            lblPuan = new Label();
            btnYeniOyun = new Button();
            lblEnYuksek = new Label();
            SuspendLayout();
            // 
            // pnlSaha
            // 
            pnlSaha.BackColor = Color.LimeGreen;
            pnlSaha.Location = new Point(12, 34);
            pnlSaha.Name = "pnlSaha";
            pnlSaha.Size = new Size(450, 450);
            pnlSaha.TabIndex = 0;
            pnlSaha.Paint += pnlSaha_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblPuan
            // 
            lblPuan.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuan.Location = new Point(8, 3);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(369, 24);
            lblPuan.TabIndex = 1;
            lblPuan.Text = "Puan: 00000";
            lblPuan.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(12, 7);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(99, 23);
            btnYeniOyun.TabIndex = 2;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // lblEnYuksek
            // 
            lblEnYuksek.AutoSize = true;
            lblEnYuksek.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnYuksek.Location = new Point(272, 2);
            lblEnYuksek.Name = "lblEnYuksek";
            lblEnYuksek.Size = new Size(194, 28);
            lblEnYuksek.TabIndex = 3;
            lblEnYuksek.Text = "EnYük. : 00000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 495);
            Controls.Add(lblEnYuksek);
            Controls.Add(btnYeniOyun);
            Controls.Add(lblPuan);
            Controls.Add(pnlSaha);
            Name = "Form1";
            Text = "Yılan Oyunu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSaha;
        private System.Windows.Forms.Timer timer1;
        private Label lblPuan;
        private Button btnYeniOyun;
        private Label lblEnYuksek;
    }
}