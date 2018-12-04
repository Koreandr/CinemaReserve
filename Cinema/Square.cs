using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    class Square : Control
    {
   
        public Color color { get; set; }
        public int Index { get; set; }
        private int w { get; set; }
        private int h { get; set; }
        public Square(Color c, int height, int width)
        {
            this.color = c;
            Height = height - 1;
            Width = width - 1;
            w = width;
            h = height;

            Paint += Square_Paint;
        }

        ~Square()
        {

        }

        private void Square_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(color), 0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0, w, h);
        }
    }
}
