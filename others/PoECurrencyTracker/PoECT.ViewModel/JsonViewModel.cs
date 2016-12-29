using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoECT.Model;
using System.Net;

namespace PoECT.ViewModel
{
    public class JsonViewModel
    {
        public StashJson Json { get; set; }
        public string StringJson {
        get
            {
                return Json.ModelJson;
            }
            set
            {
            }
        }
        public JsonViewModel()
        {
            Json = new StashJson();
            Json.ModelJson = getJson();
        }

        public static string getJson(string _accountName = "lqs", int _tabIndex = 0)
        {
            string _json;
            string url = $"https://www.pathofexile.com/character-window/get-stash-items?league=Breach&tabs=1&tabIndex={_tabIndex}&accountName={_accountName}";

            WebClient wc = new WebClient();
            _json = wc.DownloadString(url);

            return _json;
        }
    }
}
