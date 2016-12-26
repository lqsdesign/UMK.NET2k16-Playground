using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBazyDanych
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\AppBazyDanych\AppBazyDanych\Adresy.mdf;Integrated Security=True";
        static DataContext bazyDanychAdresy = new DataContext(connectionString);
        static Table<Osoba> listaOsob = bazyDanychAdresy.GetTable<Osoba>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listaOsobPelnoletnich = from osoba in listaOsob
                                        where osoba.Wiek >= 18
                                        select osoba;
            string s = "Lista osob polnoletnich: \n";
            foreach (var osoba in listaOsobPelnoletnich)
                s += osoba.Imie + " " + osoba.Nazwisko + " ( " + osoba.Wiek + " )\n";
            MessageBox.Show(s);
        }
    }
}
