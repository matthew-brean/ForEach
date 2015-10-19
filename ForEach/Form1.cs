/*
Created by: Matthew Brean
Created on: 2015-10-19
Created for: ICS3U
Daily Assignment: Unit #3-12
This program shows you how to use foreach command.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in this.Controls)
            {
                aControl.Text = "hi";
            }
        }
    }
}
