namespace silly_little_whiteboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.paintbrush = new System.Windows.Forms.ToolStripButton();
            this.eraser = new System.Windows.Forms.ToolStripButton();
            this.black = new System.Windows.Forms.ToolStripButton();
            this.red = new System.Windows.Forms.ToolStripButton();
            this.yellow = new System.Windows.Forms.ToolStripButton();
            this.green = new System.Windows.Forms.ToolStripButton();
            this.blue = new System.Windows.Forms.ToolStripButton();
            this.canvas = new System.Windows.Forms.Panel();
            this.eraserSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.penSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintbrush,
            this.eraser,
            this.black,
            this.red,
            this.yellow,
            this.green,
            this.blue});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // paintbrush
            // 
            this.paintbrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paintbrush.Image = ((System.Drawing.Image)(resources.GetObject("paintbrush.Image")));
            this.paintbrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paintbrush.Name = "paintbrush";
            this.paintbrush.Size = new System.Drawing.Size(29, 28);
            this.paintbrush.Text = "toolStripButton1";
            // 
            // eraser
            // 
            this.eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(29, 28);
            this.eraser.Text = "toolStripButton2";
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(29, 28);
            this.black.Text = "toolStripButton1";
            this.black.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(29, 28);
            this.red.Text = "toolStripButton2";
            this.red.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Gold;
            this.yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(29, 28);
            this.yellow.Text = "toolStripButton3";
            this.yellow.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(29, 28);
            this.green.Text = "toolStripButton4";
            this.green.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(29, 28);
            this.blue.Text = "toolStripButton5";
            this.blue.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // canvas
            // 
            this.canvas.AutoSize = true;
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 31);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 419);
            this.canvas.TabIndex = 1;
            this.canvas.SizeChanged += new System.EventHandler(this.canvas_SizeChanged);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // eraserSize
            // 
            this.eraserSize.Location = new System.Drawing.Point(320, 5);
            this.eraserSize.Name = "eraserSize";
            this.eraserSize.Size = new System.Drawing.Size(48, 22);
            this.eraserSize.TabIndex = 2;
            this.eraserSize.Text = "20";
            this.eraserSize.TextChanged += new System.EventHandler(this.eraserSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eraser Size";
            // 
            // penSize
            // 
            this.penSize.Location = new System.Drawing.Point(472, 4);
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(48, 22);
            this.penSize.TabIndex = 4;
            this.penSize.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pen Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.penSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eraserSize);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "silly little whiteboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton paintbrush;
        private System.Windows.Forms.ToolStripButton eraser;
        private System.Windows.Forms.ToolStripButton black;
        private System.Windows.Forms.ToolStripButton red;
        private System.Windows.Forms.ToolStripButton yellow;
        private System.Windows.Forms.ToolStripButton green;
        private System.Windows.Forms.ToolStripButton blue;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TextBox eraserSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox penSize;
        private System.Windows.Forms.Label label2;
    }
}

