using DotNetTestAssignment.Models;
using DotNetTestAssignment.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetTestAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportController : ControllerBase
    {
        private readonly IAirportRepository _airportRepository;
        
      
        public AirportController(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }



        [HttpGet("{Airport1}/{Airport2}", Name = "GetDistanceBetweenTwoAirportsWithIatas")]
        public ActionResult<double> GetDistanceBetweenTwoAirportsWithIatas(string Airport1, string Airport2)
        {
            try
            {
                var distance = _airportRepository.GetDistanceBetweenTwoAirportsWithIatas(Airport1, Airport2);

                return Ok(distance);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}
