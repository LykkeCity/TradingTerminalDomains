using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Terminal.Domain.Infrastructure;

namespace Terminal.Domain.Exchange
{
    public interface IMarketOrder : IOrderBase
    {
        DateTime MatchedAt { get; }
        DateTime Registered { get; }
        bool Straight { get; }
        double DustSize { get; }
    }

    public class MarketOrder : IMarketOrder
    {
        public string AssetPairId { get; set; }

        public string Status { get; set; }

        public string Uid { get; set; }

        public string ClientId { get; set; }

        public DateTime CreatedAt { get; set; }

        public double DustSize { get; set; }

        public string Id { get; set; }

        public DateTime MatchedAt { get; set; }

        public double Price { get; set; }

        public DateTime Registered { get; set; }

        public bool Straight { get; set; }

        public double Volume { get; set; }
    }

    public interface IMarketOrdersRepository : IRepository<IMarketOrder>
    {
        Task AddExecutedLimitedOrderAsync(IMarketOrder marketOrder);
        Task<IEnumerable<IMarketOrder>> GetByClientId(string clientId);
    }
}