﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoClothes
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Products().ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new OrdersInvoices().ShowDialog();
        }


        private void куриериToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void служителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            new Employees().ShowDialog();

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            new Deliveries().ShowDialog();

        }
    }
}
