using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_Galutinis_Darbas.Rep
{
    public class PlaceRep
    {
        public JObject Action(string pav, string pav2)
        {
            var client = new RestClient("https://www.mapquestapi.com/directions/v2/route?key=KEY&from=" + pav + "&to=" + pav2 + "&outFormat=json&ambiguities=ignore&routeType=fastest&doReverseGeocode=false&enhancedNarrative=false&avoidTimedConditions=false");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            return json;
        }
    }
}
