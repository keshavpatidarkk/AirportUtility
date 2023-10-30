using AirportUtility.Models;

namespace AirportUtility.Contract.IData
{
    public interface IAirportData
    {
        IEnumerable<AirportDetails> GetAllAirport();
        IDictionary<string, IList<string>> GetOriginDestinationsMapping();

    }
}
