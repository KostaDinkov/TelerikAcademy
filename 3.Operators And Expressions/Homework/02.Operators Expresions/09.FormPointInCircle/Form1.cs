using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09.FormPointInCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Red, 5);

            Rectangle myRectangle = new Rectangle(20, 20, 250, 200);

            graphicsObj.DrawRectangle(myPen, myRectangle);
        }
    }
}
