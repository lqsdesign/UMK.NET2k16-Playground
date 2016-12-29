using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PoECT.Model;

namespace PoECT.ViewModel
{
    public class DatabaseViewModel
    {
        DBconnector database = new DBconnector();
        public Object CurrencyInfo
        {
            get
            {
                return database.BazaDanych.Currency_infos;
            }
        }
    }
}
