﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "HELLO GITHUP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int so1 = int.Parse(textBox1.Text);
            int so2 = int.Parse(textBox2.Text);
            int c = so1 + so2;
                
=======
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
>>>>>>> Tinhtoan
        }
    }
}
