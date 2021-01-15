using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace star_wars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();


        [HttpGet]
        public async Task<string> GetCountries(string uri)
        {
            try
            {
                var baseUrl = "https://covid-api.mmediagroup.fr/v1/cases/";
                HttpResponseMessage response = await client.GetAsync(baseUrl);
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                return ex.Message;
            }
        }

    }
}