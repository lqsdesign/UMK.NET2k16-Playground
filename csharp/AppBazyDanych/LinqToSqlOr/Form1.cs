using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSqlOr
{
    public partial class Form1 : Form
    {
        AdresyDataContext BazaDanychAdresy = new AdresyDataContext();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = BazaDanychAdresy.Osobies;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listaOsob = BazaDanychAdresy.Osobies;

            var listaOsobPelnoletnich = from osoba in listaOsob
                                        where osoba.Wiek >= 18
                                        select osoba;

            string s = "Lista osob polnoletnich: \n";
            foreach (var osoba in listaOsobPelnoletnich)
                s += osoba.Imie + " " + osoba.Nazwisko + " ( " + osoba.Wiek + " )\n";
            MessageBox.Show(s);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mb = MessageBox.Show("Czy zapisac?","info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

            switch (mb)
            {
                case DialogResult.Yes:
                    BazaDanychAdresy.SubmitChanges();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BazaDanychAdresy.AktualizujWiek();
            
        }
    }
}
