using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace _4_Galutinis_Darbas.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PathController : ControllerBase
    {
        // GET: api/Path
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Path/5
        public JObject Get(string pav, string pav2)
        {
            var client = new RestClient("https://www.mapquestapi.com/directions/v2/route?key=KEY&from=" + pav + "&to=" + pav2 + "&outFormat=json&ambiguities=ignore&routeType=fastest&doReverseGeocode=false&enhancedNarrative=false&avoidTimedConditions=false");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            return json;
        }

        // POST: api/Path
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Path/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
