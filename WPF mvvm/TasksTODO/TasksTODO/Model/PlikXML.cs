using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//DAL
namespace TasksTODO.Model
{
    public static class PlikXML
    {
        private static readonly IFormatProvider formatProvider = System.Globalization.CultureInfo.InvariantCulture;

        public static void Zapisz(string sciezkaPliku, Zadania zadania)
        {
            try
            {
                XDocument xml = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Data zapisania: " + DateTime.Now.ToBinary()),
                    new XElement("Zadania",
                        from Zadanie zadanie in zadania
                        select new XElement("Zadanie",
                            new XElement("Opis", zadanie.Opis),
                            new XElement("DataUtworzenia", zadanie.DataUtworzenia),
                            new XElement("PlanowanaDataRealizacji", zadanie.PlanowanaDataRealizacji),
                            new XElement("Priorytet", zadanie.Priorytet),
                            new XElement("CzyZrealizowane", zadanie.CzyZrealizowane)
                        )
                        )
                    );
                xml.Save(sciezkaPliku);
            }
            catch(Exception exc)
            {
                throw new Exception("Error przy zapisie danych do pliku XML", exc);
            }
        }
    }
}
