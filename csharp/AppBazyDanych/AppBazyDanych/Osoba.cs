using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace AppBazyDanych
{
    [Table(Name = "Osoby")]
    public class Osoba
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)]
        public int Id { get; set; }
        [Column(CanBeNull = false)]
        public string Imie { get; set; }
        [Column(CanBeNull = false)]
        public string Nazwisko { get; set; }
        [Column(CanBeNull = false)]
        public string Email { get; set; }
        [Column(Name = "NrTel")]
        public int? NumerTelefonu { get; set; }
        [Column(CanBeNull = false)]
        public int Wiek { get; set; }
    }
}
