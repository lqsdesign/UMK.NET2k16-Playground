using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; ++i)
            {
                listBox1.Items.Add("Lista 1, element: " + i.ToString());
                listBox2.Items.Add("Lista 2, element: " + i.ToString());
            }
        }

        public ListBox lbSource = null;

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            ListBox lbSender = sender as ListBox;
            lbSender.DoDragDrop(lbSender.SelectedItem, DragDropEffects.Move | DragDropEffects.Copy);
            lbSource = lbSender;
        }

        
        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 9) e.Effect = DragDropEffects.Copy; //wcisniety ctrl = 9
            else e.Effect = DragDropEffects.Move;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            ListBox lbSender2 = sender as ListBox;
            lbSender2.Items.Add(lbSource.SelectedItem);
            if (e.Effect == DragDropEffects.Move) lbSource.Items.Remove(lbSource.SelectedItem);
        }
    }
}
