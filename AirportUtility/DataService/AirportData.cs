using AirportUtility.Contract.IData;
using AirportUtility.Models;

namespace AirportUtility.Data
{
    public class AirportData : IAirportData
    {
        /// <summary>
        /// Returns All Airport Details List
        /// Retuning Data from Hardcoded list later this can be replacedwith any other Storage provider
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AirportDetails> GetAllAirport() {
            List<AirportDetails> AirportDetailsList = new List<AirportDetails>
            {
            new AirportDetails { Code = "JFK", Name = "John F. Kennedy International Airport", City = "New York", Country = "USA" },
            new AirportDetails { Code = "LHR", Name = "Heathrow Airport", City = "London", Country = "United Kingdom" },
            new AirportDetails { Code = "CDG", Name = "Charles de Gaulle Airport", City = "Paris", Country = "France" },
            new AirportDetails { Code = "HND", Name = "Haneda Airport", City = "Tokyo", Country = "Japan" },
            new AirportDetails { Code = "LAX", Name = "Los Angeles International Airport", City = "Los Angeles", Country = "USA" },
            new AirportDetails { Code = "PEK", Name = "Beijing Capital International Airport", City = "Beijing", Country = "China" },
            new AirportDetails { Code = "SYD", Name = "Sydney Kingsford Smith Airport", City = "Sydney", Country = "Australia" },
            new AirportDetails { Code = "DXB", Name = "Dubai International Airport", City = "Dubai", Country = "United Arab Emirates" },
            new AirportDetails { Code = "AMS", Name = "Amsterdam Airport Schiphol", City = "Amsterdam", Country = "Netherlands" },
            new AirportDetails { Code = "FRA", Name = "Frankfurt Airport", City = "Frankfurt", Country = "Germany" }
            };
            return AirportDetailsList;
        }

        /// <summary>
        /// Returns Origin Desination MApping lists
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, IList<string>> GetOriginDestinationsMapping() {
            IDictionary<string, IList<string>> originDestinationsMapping = new Dictionary<string, IList<string>>
            {
                { "JFK", new List<string> { "LHR", "CDG", "HND" } },
                { "LHR", new List<string> { "JFK", "CDG", "AMS", "FRA" } },
                { "CDG", new List<string> { "LHR", "JFK", "AMS", "FRA" } },
                { "HND", new List<string> { "JFK", "PEK", "SYD" } },
                { "LAX", new List<string> { "PEK", "SYD" } },
                { "PEK", new List<string> { "LAX", "HND" } },
                { "SYD", new List<string> { "HND", "LAX" } },
                { "DXB", new List<string> { "AMS", "FRA" } },
                { "AMS", new List<string> { "LHR", "CDG", "DXB" } },
                { "FRA", new List<string>()}
            };
            return originDestinationsMapping;
        }

    }
}
