﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace computerGraphics
{
    public partial class FormSintezAnaliz : Form
    {
        Thread th;
        public FormSintezAnaliz()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(goback);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void goback(object obj)
        {
            Application.Run(new Form3ComputerGraphics());
        }
    }
}
