﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DrawIt()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();            
            graphics.DrawEllipse(System.Drawing.Pens.Black, 0, 0, 250, 
                250);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawIt();
        }
    }
}
