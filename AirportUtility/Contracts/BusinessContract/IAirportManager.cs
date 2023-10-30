using AirportUtility.Models;

namespace AirportUtility.Contract.IBusiness
{
    public interface IAirportManager
    {
        IList<AirportDetails> GetDestinationsByOrigin(string originCode);
    }
}
