using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintAnnaK12D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 850;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY= y - cY;

            if(index==3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if(index==4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if(index==5)
            {
                g.DrawLine(p,cX,cY,x,y);
            }

        }


        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }


        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

      

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }


        private void pic_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }


        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void validate(Bitmap bm, Stack<Point>sp,int x,int y,Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx== old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}