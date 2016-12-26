using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        KsiazkiLinqDataContext BazaKsiazki = new KsiazkiLinqDataContext();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = BazaKsiazki.Ksiazkis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var search = BazaKsiazki.Ksiazkis.Where(x => x.rokWydania.Year == int.Parse(textBox1.Text));
            dataGridView1.DataSource = search;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            var Max = BazaKsiazki.Ksiazkis.OrderBy(x => x.sprzedanych);

            dataGridView1.DataSource = Max.Last();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            var Min = BazaKsiazki.Ksiazkis.OrderBy(x => x.sprzedanych);
            dataGridView1.DataSource = Min;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BazaKsiazki.ZwiekszSprzedane10();
        }
    }
}
