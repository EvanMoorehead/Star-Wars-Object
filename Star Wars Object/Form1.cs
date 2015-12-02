using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars_Object
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Xwing(0, 0, 30, 30);
        }

        public void Xwing(float x, float y, float width, float height)
        {
            Pen exPen = new Pen(Color.White);

            float scale = width / 100;
            float scaley = height / 100;

            g.DrawRectangle(exPen, 0 + x, 0 + y, scale, scale);
            //Front
            g.DrawLine(exPen, 0 * scale + x, 75 * scaley + y, 70 * scale + x, 50 * scaley + y);
            g.DrawLine(exPen, 0 * scale + x, 75 * scaley + y, 70 * scale + x, 100 * scaley + y);

            //Wings
            g.DrawLine(exPen, 70 * scale + x, 100 * scaley + y, 90 * scale + x, 150 * scaley + y);
            g.DrawLine(exPen, 70 * scale + x, 50 * scaley + y, 120 * scale + x, 20 * scaley + y);

            g.DrawLine(exPen, 70 * scale + x, 100 * scaley + y, 120 * scale + x, 130 * scaley + y);
            g.DrawLine(exPen, 70 * scale + x, 50 * scaley + y, 90 * scale + x, 0 * scaley + y);

            //Back
            g.DrawLine(exPen, 70 * scale + x, 100 * scaley + y, 130 * scale + x, 100 * scaley + y);
            g.DrawLine(exPen, 70 * scale + x, 50 * scaley + y, 130 * scale + x, 50 * scaley + y);

            g.DrawArc(exPen, 100 * scale + x, 50 * scaley + y, 50 * scale, 50 * scaley, 270, 180);

        }
    }
}
