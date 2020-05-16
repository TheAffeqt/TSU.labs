﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form2 : Form
    {
        Answer answer = new Answer();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = answer.Question();
        }
    }

    public class Answer
    {
        Random rnd = new Random();
        double fiftyCent = 0.5d;
        
        public string Question()
        {
            double num = rnd.NextDouble();
            
            if (num < fiftyCent)
            {
                return "Yes!!!";
            }
            return "No!!!";
        }
    }


}
