using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventApplicationCore.Interface;
using EventApplicationCore.Model;


namespace EventApplicationCore.Controllers
{
    [Route("api/[controller]")]
    public class CityAPIController : Controller
    {

        private ICity _ICity;

        public CityAPIController(ICity ICity)
        {
            _ICity = ICity;
        }

        // POST api/values
        [HttpPost]
        public List<City> Post(string id)
        {
            try
            {
                var listofState = _ICity.ListofCity(Convert.ToInt32(id));
                return listofState;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
