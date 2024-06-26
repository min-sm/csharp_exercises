﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClosingTest
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        private static int instanceCount = 0;
        private int instanceId;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;

            // Assign a unique identifier to this Form2 instance
            instanceCount++;
            instanceId = instanceCount;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Form2 Instance Id: " + instanceId;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
