﻿namespace YilanOyunu
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
            SuspendLayout();
            // 
            // pnlSaha
            // 
            pnlSaha.BackColor = SystemColors.ActiveCaption;
            pnlSaha.Location = new Point(12, 12);
            pnlSaha.Name = "pnlSaha";
            pnlSaha.Size = new Size(500, 500);
            pnlSaha.TabIndex = 0;
            pnlSaha.Paint += pnlSaha_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 524);
            Controls.Add(pnlSaha);
            Name = "Form1";
            Text = "Yılan Oyunu";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSaha;
        private System.Windows.Forms.Timer timer1;
    }
}