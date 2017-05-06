using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApp2.Models.InputModels.Home;

namespace WebApp2.Controllers
{
    /// <summary>
    /// To jest kontroler Home do testów
    /// </summary>
    public class HomeController : ApiController
    {
        /// <summary>
        /// Pobierz dane
        /// </summary>
        /// <returns></returns>
        public async Task<IHttpActionResult> Get()
        {
            return Ok("Wszystko ok");
        }
        /// <summary>
        /// Pobierz dane dla Id
        /// </summary>
        /// <param name="id">Identyfikator</param>
        /// <returns></returns>
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok($"Wszystko ok {id}");
        }
        /// <summary>
        /// Wyślij dane o modelu
        /// </summary>
        /// <param name="model">Model wejściowy</param>
        /// <returns></returns>
        public async Task<IHttpActionResult> Post(HomeInputModel model)
        {
            string outputString = $"{model.Id} : {model.Name}";

            return Ok(outputString);
        }
    }
}
