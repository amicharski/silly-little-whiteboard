using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silly_little_whiteboard
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton p = (ToolStripButton)sender;
                pen.Color = p.BackColor;
                pen.Width = float.Parse(penSize.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid Input", "Pen Size");
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x!=-1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            try
            {
                pen.Color = Color.White;
                pen.Width = float.Parse(eraserSize.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid Input", "Eraser Size");
            }
        }

        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            canvas.Size = new Size(this.Size.Width - 19, this.Size.Height - 74);
        }

        private void eraserSize_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
