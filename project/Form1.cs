using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.Aqua);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Clip = new Rectangle(new Point(this.Width / 4, this.Height / 4), new Size(this.Width / 2, this.Height / 2));
            Cursor.Hide();
        }
          Graphics g;
          Pen pen;

        int ticks = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"{e.X}:{e.Y}:{ticks}";
            g.DrawRectangle(pen, e.X, e.Y,1,1);
            ticks = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text =$"uncalled{ticks}";
            ticks++;
        }
    }
}
