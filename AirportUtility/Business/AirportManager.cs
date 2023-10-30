using AirportUtility.Contract.IBusiness;
using AirportUtility.Contract.IData;
using AirportUtility.Models;
using System.Net.WebSockets;

namespace AirportUtility.Business
{
    public class AirportManager : IAirportManager
    {
        private IAirportData _airportData;
        public AirportManager(IAirportData airportData) { 
        _airportData = airportData;
        }
        public IList<AirportDetails> GetDestinationsByOrigin(string originCode)
        {
            var destinationAirportList = new List<AirportDetails>();
            var originDestinationsList = _airportData.GetOriginDestinationsMapping();
            
            if (originDestinationsList.ContainsKey(originCode))
            {
                var destinationList= originDestinationsList[originCode];
                destinationAirportList = _airportData.GetAllAirport().Where(x => destinationList.Contains(x.Code)).ToList();
            }
            return destinationAirportList;
           
        }
    }
}
