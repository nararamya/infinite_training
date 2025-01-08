using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAssessment.Models;


namespace WebApiAssessment.Controllers
{


    public class CountryController : ApiController
    {

        private static List<Country> Countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "Delhi" },
            new Country { ID = 2, CountryName = "Germany", Capital = "Berlin" },
            new Country { ID = 3, CountryName = "France", Capital = "Paris" },
            new Country { ID = 4, CountryName = "Italy", Capital = "Rome" },
            new Country { ID = 5, CountryName = "USA", Capital = "Washington D.C"}
        };
        [HttpGet]
        [Route("All")]
        public HttpResponseMessage GetAllCountries()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Countries);
            return response;
        }
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetCountryById(int ctry_id)
        {
            string cname = Countries.Where(c => c.ID == ctry_id).SingleOrDefault()?.CountryName;
            if (cname == null)
            {
                return NotFound();
            }
            return Ok(cname);
        }
       
        [HttpPost]
        [Route("AllPost")]
        public List<Country> PostAll([FromBody] Country country)
        {
            Countries.Add(country);
            return Countries;
        }
        [HttpPut]
        [Route("Put")]
        public IEnumerable<Country> Put(int ctry_id, [FromUri] Country c)
        {
            Countries[ctry_id - 1] = c;
            return Countries;
        }
        [HttpDelete]
        [Route("Delete")]
        public IEnumerable<Country> Delete(int ctry_id)
        {
            Countries.RemoveAt(ctry_id - 1);
            return Countries;
        }
    }
}