using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMUSAGE2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fRAM = pRAM.NextValue();
            metroProgressBarRAM.Value = (int)fRAM;
            lblRAM.Text = (" " + fRAM + " %");
            notifyIcon1.Text = (" " + fRAM + " %");

            Graphics canvas;
            Bitmap iconBitmap = new Bitmap(16, 16);
            canvas = Graphics.FromImage(iconBitmap);
            canvas.DrawString(
                "" + fRAM,
                new Font("Calibri", 8, FontStyle.Bold),
                new SolidBrush(Color.FromArgb(255, 234, 45)),
                new RectangleF(0, 3, 16, 13)
            );

            notifyIcon1.Icon = Icon.FromHandle(iconBitmap.GetHicon());
        }
    }
}