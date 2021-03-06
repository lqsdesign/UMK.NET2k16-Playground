﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicznyPrzycisk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button przycisk1 = new Button();


                Text = e.X.ToString() + ", " + e.Y.ToString();
                
                przycisk1.Text = "Label";
                przycisk1.Left = e.X;
                przycisk1.Top = e.Y;
                przycisk1.Width = 100;
                przycisk1.Height = 50;
                przycisk1.Parent = this;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    przycisk1.Text = "Lewy";
                    break;
                case MouseButtons.Right:
                    przycisk1.Text = "Prawy";
                    break;
                case MouseButtons.Middle:
                    przycisk1.Text = "Rolka";
                    break;
                default:
                    break;
            }

            przycisk1.Click += Przycisk1_Click;
           
        }

        private void Przycisk1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Klikniety";
        }
    }
}
