using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyC_sharp002
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int vx, vy;


        public Form1()
        {
            InitializeComponent();
            vx = rand.Next(-20, 21);
            vy = rand.Next(-20, 21);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + vx;
            label1.Top = label1.Top + vy;
            Point mpos = PointToClient(MousePosition);
            label2.Left = mpos.X - 12;
            label2.Top = mpos.Y - 5;
            if (label1.Left <= 0 || label1.Right >= ClientSize.Width)
            {
                vx = -vx;
            }
            if (label1.Top <= 0 || label1.Bottom >= ClientSize.Height)
            {
                vy = -vy;
            }
            if (mpos.X > label1.Left && mpos.X < label1.Right && mpos.Y < label1.Bottom
                && mpos.Y > label1.Top)
            {
                label1.Visible = false;
            }



        }


    }

}

