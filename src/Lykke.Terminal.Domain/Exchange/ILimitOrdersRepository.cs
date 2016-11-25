using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface ILimitOrder : IOrderBase
    {
        double RemainingVolume { get; }

        DateTime Registered { get; }

        DateTime LastMatchTime { get; }
    }

    public class LimitOrder : ILimitOrder
    {
        public string TradingAccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string AssetPairId { get; set; }
        public string Status { get; set; }
        public string Uid { get; set; }
        public bool Straight { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public double RemainingVolume { get; set; }
        public DateTime Registered { get; set; }
        public DateTime LastMatchTime { get; set; }
    }

    public interface IActiveLimitOrdersRepository : IRepository<ILimitOrder>
    {
        Task<IEnumerable<ILimitOrder>> GetByAssetPairIdAsync(string assetPairId);
        Task<ILimitOrder> GetByOrderIdAsync(string orderId);
    }
}