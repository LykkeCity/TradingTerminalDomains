using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IProductQuote
    {
        string ProductQuoteId { get; }
        string AssetPairId { get; set; }
        bool IsBuy { get; set; }
        DateTime Timestamp { get; set; }
        IEnumerable<ProductQuoteLine> Prices { get; set; }
    }

    public class ProductQuote : IProductQuote
    {
        public string ProductQuoteId { get; set; }
        public string AssetPairId { get; set; }
        public bool IsBuy { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<ProductQuoteLine> Prices { get; set; }
    }

    public class ProductQuoteLine
    {
        public double Volume { get; set; }
        public double Price { get; set; }
    }

    public interface IProductQuoteRepository : IRepository<IProductQuote>
    {
        Task<IEnumerable<IProductQuote>> GetByAssetPairIdAndBuy(IProductQuote entity);
    }
}