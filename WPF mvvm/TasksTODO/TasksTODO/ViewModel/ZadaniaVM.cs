using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksTODO.Model;

namespace TasksTODO.ViewModel
{
    public class ZadaniaVM
    {
        private Model.Zadania model;
        private string sciezkaPlikuXML = "zadania.xml";

        public ObservableCollection<Zadanie> ListaZadan { get; } = new ObservableCollection<Zadanie>();

        public ZadaniaVM()
        {
            //if (System.IO.File.Exists(sciezkaPlikuXML))
            //model = Model.PlikXML.Czytaj(sciezkaPlikuXML);
            model = new Model.Zadania();

            kopiujZadaniaZModelu();
        }

        private void kopiujZadaniaZModelu()
        {
            ListaZadan.Clear();
            foreach (Model.Zadanie zadanie in model)
            {
                ListaZadan.Add(new ZadanieVM(zadanie));
            }
        }

        private void synchronizacjaModelu(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Zadanie noweZadanie = (Zadanie)e.NewItems[0]; //dodaje tylko jeden
                    if (noweZadanie != null) model.DodajZadanie(noweZadanie(noweZadanie.p))
            }
        }
    }
}
