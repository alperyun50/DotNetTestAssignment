using DotNetTestAssignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetTestAssignment.Repositories
{
    public interface IAirportRepository
    {
        AirportDetail GetAirportWithIata(string iata);

        double GetDistanceBetweenTwoAirportsWithIatas(string Airport1, string Airport2);

    }
}
