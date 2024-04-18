using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.LavenderBlush);

            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            Pen whitePen = new Pen(Color.White);
            
           
            //Pen whitePen = new Pen(Color.White, 5);
            //SolidBrush whiteBrush = new SolidBrush(Color.White);
            //SolidBrush greenBrush = new SolidBrush(Color.Green);
            //Font drawFont = new Font("Arial", 25, FontStyle.Bold);
        }
    }
}
