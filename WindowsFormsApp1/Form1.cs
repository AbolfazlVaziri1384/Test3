﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello world";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            xuiButton1.BackgroundColor = Color.Black;
        }

        private void xuiCard1_Click(object sender, EventArgs e)
        {
            xuiCard1.BackColor = Color.Black;
        }

        private void xuiRadio1_Click(object sender, EventArgs e)
        {

        }
    }
}
