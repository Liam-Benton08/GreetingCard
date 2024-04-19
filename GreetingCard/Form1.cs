using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        int frontWord = 340;
        int backWord = 650;
        int balloon = 50;
        int line1 = 165;
        int line2 = 300;
        int heartp1 = 125;
        int heartp2 = 163;
        int heartp3 = 100;
        int heartp4 = 140;
        int heartp5 = 200;
        int time = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.LavenderBlush);

            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            Pen pinkPen = new Pen(Color.Pink, 5);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White, 5);
            SolidBrush redBrush = new SolidBrush(Color.Tomato);
            Pen redPen = new Pen(Color.Tomato,7);
            Pen blackPen = new Pen(Color.Black, 2);
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);

            g.DrawString("Happy Valentines Day!", drawFont, pinkBrush, 152, 340);
            g.FillEllipse(pinkBrush, 500, 50, 100, 115);
            g.DrawLine(blackPen, 550, 165, 550, 300);
            g.FillEllipse(pinkBrush, 150, 50, 100, 115);
            g.DrawLine(blackPen, 200, 165, 200, 300);

            g.FillEllipse(redBrush, 344, 125, 61, 57);
            g.FillEllipse(redBrush, 360, 163, 30, 30);
            g.DrawEllipse(redPen, 325, 100, 50, 50);
            g.DrawEllipse(redPen, 375, 100, 50, 50);
            g.DrawLine(redPen, 330, 140, 377, 200);
            g.DrawLine(redPen, 420, 140, 373, 200);
            g.FillEllipse(redBrush, 325, 100, 50, 50);
            g.FillEllipse(redBrush, 375, 100, 50, 50);
            

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int frontWord = 340;
            int backWord = 700;
            int balloon = 50;
            int line1 = 165;
            int line2 = 300;
            int heartp1 = 125;
            int heartp2 = 163;
            int heartp3 = 100;
            int heartp4 = 140;
            int heartp5 = 200;
            int arrow = 0;
            int time = 150;

            Graphics g = this.CreateGraphics();

            g.Clear(Color.Purple);

            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            Pen pinkPen = new Pen(Color.Pink, 7);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White, 7);
            SolidBrush redBrush = new SolidBrush(Color.Tomato);
            Pen redPen = new Pen(Color.Tomato, 7);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen blackPen2 = new Pen(Color.Black, 5);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            Font bigFont = new Font("Arial", 60, FontStyle.Bold);

            while (time >= 0)
            {
                g.DrawString("Happy Valentines Day!", drawFont, redBrush, 152, frontWord);
                g.FillEllipse(redBrush, 500, balloon, 100, 115);
                g.DrawLine(blackPen, 550, line1, 550, line2);
                g.FillEllipse(redBrush, 150, balloon, 100, 115);
                g.DrawLine(blackPen, 200, line1, 200, line2);

                g.FillEllipse(pinkBrush, 344, heartp1, 61, 57);
                g.FillEllipse(pinkBrush, 360, heartp2, 30, 30);
                g.DrawEllipse(pinkPen, 325, heartp3, 50, 50);
                g.DrawEllipse(pinkPen, 375, heartp3, 50, 50);
                g.DrawLine(pinkPen, 330, heartp4, 377, heartp5);
                g.DrawLine(pinkPen, 420, heartp4, 373, heartp5);
                g.FillEllipse(pinkBrush, 325, heartp3, 50, 50);
                g.FillEllipse(pinkBrush, 375, heartp3, 50, 50);

                Thread.Sleep(07);
                g.Clear(Color.Purple);

                frontWord = frontWord + 2;
                balloon = balloon - 2;
                line1 = line1 - 2;
                line2 = line2 - 2;
                heartp1 = heartp1 - 2;
                heartp2 = heartp2 - 2;
                heartp3 = heartp3 - 2;
                heartp4 = heartp4 - 2;
                heartp5 = heartp5 - 2;

                time--;
            }

            time = 330;

            while (time >= 0)
            {
                g.DrawString("I had to ask cupid for a map...           Because I just keep getting lost in your eyes.", bigFont, whiteBrush, backWord, 160);

                Thread.Sleep(10);
                g.Clear(Color.Purple);

                backWord = backWord - 11;

                time--;
            }

            time = 40;

            while (time >= 0)
            {
                g.DrawEllipse(blackPen2, 500, 155, 130, 130);
                g.FillEllipse(yellowBrush, 500, 155, 130, 130);
                g.FillEllipse(blackBrush, 520, 185, 35, 35);
                g.FillEllipse(blackBrush, 575, 185, 35, 35);
                g.DrawLine(blackPen2, 220, 220, 300, 220);

                time--;
            }
            


        }
    }
}
