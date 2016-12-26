using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsystentZakupow
{
    public partial class Form1 : Form
    {
        private Model.Sumator model = new Model.Sumator(0, 200);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal kwota = decimal.Parse(textBox1.Text);
                model.DodajKwote(kwota);
                label3.Text = model.Suma.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) e.IsInputKey = true; //nie dziala, sprawdzic
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1_Click(sender, EventArgs.Empty);
                textBox1.Text = "";
            }
        }
    }
}
