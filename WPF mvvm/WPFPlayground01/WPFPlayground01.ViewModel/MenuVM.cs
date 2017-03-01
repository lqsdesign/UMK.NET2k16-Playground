using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPlayground01.Model;

namespace WPFPlayground01.ViewModel
{
    public class MenuVM
    {
        public List<Meal> MenuList { get; set; }

        public MenuVM()
        {
            var menu = new Menu();
            MenuList = menu.MenuList;
        }

        public void UpdateList(List<Meal> _list)
        {
            MenuList = _list;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Meal meal in MenuList)
            {
                result += meal.Name + " - " + meal.Price + Environment.NewLine;
            }
            return result;
        }
    }
}
