using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    using Model;
    using Kolory_WPF.Properties;

    public static class DAL
    {
        public static void ZapiszModel(Kolor kolor)
        {
            Settings.Default.R = kolor.R;
            Settings.Default.G = kolor.G;
            Settings.Default.B = kolor.B;
            Settings.Default.Save(); //to nie jest najbardziej optymalne rozwiązanie!
        }

        public static Kolor CzytajModel()
        {
            return new Kolor()
            {
                R = Settings.Default.R,
                G = Settings.Default.G,
                B = Settings.Default.B
            };
        }
    }
}
