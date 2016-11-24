using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IOrderBook
    {
        string OrderBookId { get; }
        string AssetPairId { get; set; }
        bool IsBuy { get; set; }
        DateTime Timestamp { get; set; }
        IEnumerable<OrderBookLine> Prices { get; set; }
    }

    public class OrderBook : IOrderBook
    {
        public string OrderBookId { get; set; }
        public string AssetPairId { get; set; }
        public bool IsBuy { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<OrderBookLine> Prices { get; set; }
    }

    public class OrderBookLine
    {
        public double Volume { get; set; }
        public double Price { get; set; }
    }

    public interface IOrderBookRepository : IRepository<IOrderBook>
    {
        Task<IEnumerable<IOrderBook>> GetByAssetPairIdAndBuy(IOrderBook entity);
    }
}