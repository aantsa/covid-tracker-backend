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

    }
}