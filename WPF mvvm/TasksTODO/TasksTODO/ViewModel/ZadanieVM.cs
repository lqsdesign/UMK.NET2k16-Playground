using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PSPiZK;

namespace TasksTODO.ViewModel
{
    public class ZadanieVM : INotifyPropertyChanged
    {
        private Model.Zadanie model;

        public string Opis
        {
            get
            {
                return model.Opis;
            }
        }

        public Model.PriorytetZadania Priorytet
        {
            get
            {
                return model.Priorytet;
            }
        }

        public DateTime DataUtworzenia
        {
            get
            {
                return model.DataUtworzenia;
            }
        }

        public DateTime PlanowanaDataRealizacji
        {
            get
            {
                return model.PlanowanaDataRealizacji;
            }
        }

        public bool CzyZrealizowano
        {
            get
            {
                return model.CzyZrealizowane;
            }
        }

        public bool CzyZadanieNiezrealizowanePoPrzekroczonymTerminie
        {
            get
            {
                return !CzyZrealizowano && (DateTime.Now > PlanowanaDataRealizacji);
            }
        }


        public ZadanieVM(Model.Zadanie zadanie)
        {
            this.model = zadanie;
        }

        public ZadanieVM(string opis, DateTime dataUtworzenia, DateTime planowanaDataRealizacji, Model.PriorytetZadania priorytet, bool czyZrealizowane)
        {
            this.model = new Model.Zadanie(opis, dataUtworzenia, planowanaDataRealizacji, priorytet, czyZrealizowane);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string propertyName, string czyTermin)
        {
            if (PropertyChanged != null)
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName));
        }

        private ICommand oznaczJakoZrealizowane = null;

        public ICommand OznaczJakoZrealizowane
        {
            get
            {
                if (oznaczJakoZrealizowane == null)
                    oznaczJakoZrealizowane = new MvvmCommand(
                        o =>
                        {
                            model.CzyZrealizowane = true;
                            onPropertyChanged(
                                nameof(CzyZrealizowano), 
                                nameof(CzyZadanieNiezrealizowanePoPrzekroczonymTerminie));
                        },
                        o =>
                        {
                            return !model.CzyZrealizowane;
                        }
                        );
                return oznaczJakoZrealizowane;
            }
        }

        private ICommand oznaczJakoNieZrealizowane = null;

        public ICommand OznaczJakoNieZrealizowane
        {
            get
            {
                if (oznaczJakoNieZrealizowane == null)
                    oznaczJakoNieZrealizowane = new MvvmCommand(
                        o =>
                        {
                            model.CzyZrealizowane = false;
                            onPropertyChanged(
                                nameof(CzyZrealizowano),
                                nameof(CzyZadanieNiezrealizowanePoPrzekroczonymTerminie));
                        },
                        o =>
                        {
                            return model.CzyZrealizowane;
                        }
                        );
                return oznaczJakoNieZrealizowane;
            }
        }

        public Model.Zadanie PobierzZadanie()
        {
            return model;
        }
    }
}
