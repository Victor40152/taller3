﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            double area;
            area = Math.PI * (double.Parse(txtradio.Text) * double.Parse(txtradio.Text));
            lbltotal1.Text = area.ToString();

        }
    }
}
