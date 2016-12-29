using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;

namespace PoECT.Model
{
    public class DBconnector
    {
        public DBDataContext BazaDanych { get; set; }
        public DBconnector()
        {
            this.BazaDanych = new DBDataContext();
        }

    }
}
