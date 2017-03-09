using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksTODO.Model
{
    public class Zadania : IEnumerable<Zadanie>
    {
        private List<Zadanie> listaZadan = new List<Zadanie>();
        //CRUD
        public void DodajZadanie(Zadanie zadanie)
        {
            listaZadan.Add(zadanie);
        }
        public bool UsunZadanie(Zadanie zadanie)
        {
            return listaZadan.Remove(zadanie);
        }

        

        public int LiczbaZadan
        {
            get
            {
                return listaZadan.Count();
            }
        }

        //indekser
        public Zadanie this[int indeks]
        {
            get
                {
                return listaZadan[indeks];
            }
        }

        //Ienumerable
        public IEnumerator<Zadanie> GetEnumerator()
        {
            return listaZadan.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }

    }
}
