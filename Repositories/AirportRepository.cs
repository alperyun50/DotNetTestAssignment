using DotNetTestAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetTestAssignment.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly DbContexts _dbContexts;

        public AirportRepository(DbContexts dbContexts)
        {
            _dbContexts = dbContexts;
        }


        public AirportDetail GetAirportWithIata(string iata)
        {
            var result =  _dbContexts.AirportDetails.Where(x => x.Iata == iata).FirstOrDefault();

            return result;
           
        }


        public double GetDistanceBetweenTwoAirportsWithIatas(string airport1, string airport2)
        {
            AirportDetail firstAirport =  GetAirportWithIata(airport1);
            AirportDetail secondAirport = GetAirportWithIata(airport2);
       
            double totalDistance =  CalculateDistanceInMile(firstAirport.Location, secondAirport.Location);

            return totalDistance;
        }


        private double CalculateDistanceInMile(Location first, Location second)
        {
            double R = 3958.8; // Earth's radius in miles

            double dLat = ToRadians(second.lat - first.lat);
            double dLon = ToRadians(second.lon - first.lon);
            double lat1 = ToRadians(first.lat);
            double lat2 = ToRadians(second.lat);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = R * c;

            return distance;
        }

        private double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

    }
}
