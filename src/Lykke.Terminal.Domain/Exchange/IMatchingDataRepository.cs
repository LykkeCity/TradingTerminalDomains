using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IMatchingData
    {
        double Volume { get; }
        string MarketOrderId { get; }
        string LimitOrderId { get; }
    }

    public class MatchedData : IMatchingData
    {
        public double Volume { get; set; }
        public string MarketOrderId { get; set; }
        public string LimitOrderId { get; set; }
    }

    public interface IMatchingDataRepository
    {
        Task AddAsync(IMatchingData matchingData);
        Task AddAsync(IEnumerable<IMatchingData> matchingData);
    }
}