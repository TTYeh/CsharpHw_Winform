using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyHomework
{
    public partial class hw13_SmallPrinter : Form
    {
        private Graphics g;
        private Pen p;
        private int x0, y0;

        public hw13_SmallPrinter()
        {
            InitializeComponent();
            this.Load += Hw13_SmallPrinter_Load;
        }

        private void Hw13_SmallPrinter_Load(object sender, EventArgs e)
        {
            labelDispPenWidth.Text = trackBar1.Value.ToString();
            this.g = this.CreateGraphics();
            this.p = new Pen(Color.Black, trackBar1.Value);
        }

        private void hw13_SmallPrinter_MouseDown(object sender, MouseEventArgs e)
        {
            //isDrawing = true;
            this.x0 = e.X;
            this.y0 = e.Y;
        }

        private void hw13_SmallPrinter_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.g.DrawLine(this.p, x0, y0, e.X, e.Y);
                x0 =e.X;
                y0 = e.Y;
            
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.p.Width = trackBar1.Value;
            labelDispPenWidth.Text = trackBar1.Value.ToString();
        }

        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            bool flag = this.colorDialog1.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                this.p.Color = this.colorDialog1.Color;
                labelDispColor.BackColor= this.colorDialog1.Color;
            }
        }

        private void hw13_SmallPrinter_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
