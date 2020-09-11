using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class citiesController : ApiController
    {
        private string[] cities = new string[] { "antalya", "adana", "mersin", "istanbul" };
        public string[] Get()
        {
            return cities;
        }
        public string Get(int id)
        {
            return cities[id];
        }
    }
}
