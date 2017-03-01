using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFPlayground01.Model
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
