﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fractalDepth = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.penColor = new System.Windows.Forms.Button();
            this.penSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.fractals = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fractalDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fractals)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "pictureBox1";
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 542);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDraw
            // 
            this.panelDraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDraw.Location = new System.Drawing.Point(351, 12);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(469, 428);
            this.panelDraw.TabIndex = 1;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hide/Show Canvas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Set Array Properties";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(334, 7);
            this.trackBar1.MaximumSize = new System.Drawing.Size(104, 15);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 15);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(274, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Array Size";
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(334, 50);
            this.trackBar2.MaximumSize = new System.Drawing.Size(104, 15);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 15);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Value = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fractalDepth);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.penColor);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.penSize);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 77);
            this.panel1.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(98, 41);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "Snowflake";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fractal Depth (Snowflake)";
            // 
            // fractalDepth
            // 
            this.fractalDepth.AutoSize = false;
            this.fractalDepth.LargeChange = 1;
            this.fractalDepth.Location = new System.Drawing.Point(93, 7);
            this.fractalDepth.Maximum = 5;
            this.fractalDepth.Minimum = 1;
            this.fractalDepth.Name = "fractalDepth";
            this.fractalDepth.Size = new System.Drawing.Size(104, 15);
            this.fractalDepth.TabIndex = 13;
            this.fractalDepth.Value = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(633, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pen/Fractal Color";
            // 
            // penColor
            // 
            this.penColor.BackColor = System.Drawing.Color.Black;
            this.penColor.Location = new System.Drawing.Point(635, 7);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(104, 15);
            this.penColor.TabIndex = 11;
            this.penColor.UseVisualStyleBackColor = false;
            this.penColor.Click += new System.EventHandler(this.penColor_Click);
            // 
            // penSize
            // 
            this.penSize.AutoSize = false;
            this.penSize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.penSize.LargeChange = 1;
            this.penSize.Location = new System.Drawing.Point(525, 7);
            this.penSize.Minimum = 1;
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(104, 15);
            this.penSize.TabIndex = 9;
            this.penSize.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(525, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pen Size";
            // 
            // fractals
            // 
            this.fractals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fractals.Location = new System.Drawing.Point(12, 12);
            this.fractals.Name = "fractals";
            this.fractals.Size = new System.Drawing.Size(269, 272);
            this.fractals.TabIndex = 13;
            this.fractals.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Fern";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fractals);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint, Arrays and Fractals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fractalDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fractals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar penSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button penColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox fractals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar fractalDepth;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button4;
    }
}

