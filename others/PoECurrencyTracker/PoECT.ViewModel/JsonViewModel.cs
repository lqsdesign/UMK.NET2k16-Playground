using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoECT.Model;
using System.Net;
using System.Web;
using System.IO;
using System.Collections.Specialized;

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
            string USERNAME = "lqsdesign@gmail.com";
            string PASSWORD = "dasz11dasz11";
            string LOGIN_URL = "https://www.pathofexile.com/login";
            byte[] response;

            WebClient client = new WebClient();
            response = client.DownloadData(LOGIN_URL);

            string viewstate = ExtractViewState(Encoding.ASCII.GetString(response));

            string postData = String.Format
                (
                "hash={0}&login_email={1}&login_password={2}",
                viewstate, USERNAME, PASSWORD);

            client.Headers.Add("Content-Type", "applocation/x-www-form-urlencoded");
            response = client.UploadData(LOGIN_URL, "POST", Encoding.ASCII.GetBytes(postData));
                //WebClient client = new WebClient();

                //_json = client.DownloadString(url);

                return "test";
        }

        private string ExtractViewState(string s)
        {
            string viewStateNameDelimiter = "hash";
            string valueDelimiter = "value=\"";

            int viewStateNamePosition = s.IndexOf(viewStateNameDelimiter);
            int viewStateValuePosition = s.IndexOf(valueDelimiter, viewStateNamePosition);

            int viewStateStartPosition = viewStateValuePosition + valueDelimiter.Length;
            int viewStateEndPosition = s.IndexOf("\"", viewStateStartPosition);

            return HttpUtility.UrlEncodeUnicode
                (
                s.Substring(viewStateStartPosition, viewStateEndPosition - viewStateStartPosition);
                )
        }
    }
}
