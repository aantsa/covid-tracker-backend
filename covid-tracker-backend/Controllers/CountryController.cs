using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace star_wars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();


        [HttpGet]
        public async Task<string> GetCountries()
        {
            try
            {
                var baseUrl = "https://raw.githubusercontent.com/M-Media-Group/country-json/master/src/countries-master.json";
                HttpResponseMessage response = await client.GetAsync(baseUrl);
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                return ex.Message;
            }
        }

        [Route("{country}")]
        [HttpGet]
        public async Task<string>GetCountry(string country)
        {
            try
            {
                UriBuilder baseUri = new UriBuilder("https://covid-api.mmediagroup.fr/v1/cases");
                string queryToAppend = "country=" + country;
                baseUri.Query = queryToAppend;

                HttpResponseMessage response = await client.GetAsync(baseUri.ToString());
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                return ex.Message;
            }
        }

    }
}