using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawEllipce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rcPaint = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            Pen oRedPen = new Pen(Color.Red, 5);
            Brush oYllowBrush = Brushes.Yellow;
            g.Clear(Color.Black);
            g.DrawEllipse(oRedPen, rcPaint);
            g.FillEllipse(oYllowBrush, rcPaint);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
