using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nugetpackage_turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {

            //Moving to start point
            Turtle.Rotate(270);
            Turtle.PenUp();
            Turtle.Forward(155);

            //underline
            Turtle.Rotate(270);
            Turtle.Forward(10);
            Turtle.Rotate(90);
            Turtle.PenDown();
            Turtle.Backward(310);
            Turtle.Forward(310);
            Turtle.Rotate(90);
            Turtle.PenUp();
            Turtle.Forward(10);
            Turtle.PenDown();
            //N
            Turtle.Forward(100);
            Turtle.Rotate(150);
            Turtle.Forward(115);
            Turtle.Rotate(210);
            Turtle.Forward(100);
            //reseting
            Turtle.Rotate(180);
            Turtle.Forward(100);
            Turtle.Rotate(270);
            Turtle.PenUp();
            Turtle.Forward(15);
            Turtle.PenDown();
            //U
            Turtle.Rotate(270);
            Turtle.Forward(100);
            Turtle.Rotate(180);
            Turtle.Forward(100);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(100);
            //reseting
            Turtle.Rotate(180);
            Turtle.Forward(100);
            Turtle.Rotate(270);
            Turtle.PenUp();
            Turtle.Forward(15);
            Turtle.PenDown();
            //G
            Turtle.Rotate(270);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(50);
            Turtle.Rotate(180);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(100);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(25);
            Turtle.Rotate(180);
            Turtle.Forward(25);
            //reseting
            Turtle.Rotate(90);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.PenUp();
            Turtle.Forward(15);
            Turtle.PenDown();
            //E
            Turtle.Rotate(270);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(50);
            Turtle.Rotate(180);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.Rotate(180);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.Rotate(270);
            Turtle.Forward(50);
            Turtle.PenUp();
            Turtle.Forward(15);
            Turtle.PenDown();
            //T
            Turtle.PenUp();
            Turtle.Forward(25);
            Turtle.PenDown();
            Turtle.Rotate(270);
            Turtle.Forward(100);
            Turtle.Rotate(270);
            Turtle.Forward(25);
            Turtle.Rotate(180);
            Turtle.Forward(50);
            Turtle.Rotate(180);
            Turtle.Forward(25);
            Turtle.Rotate(270);
            Turtle.Forward(100);
        }
    }
}
