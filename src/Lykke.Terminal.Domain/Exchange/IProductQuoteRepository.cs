using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IProductQuote
    {
        string ProductQuoteId { get; }
        string InstrumentId { get; set; }
        DateTime Timestamp { get; set; }
        IEnumerable<ProductQuoteData> BidPrices { get; set; }
        IEnumerable<ProductQuoteData> AskPrices { get; set; }
    }

    public class ProductQuote : IProductQuote
    {
        public string ProductQuoteId { get; set; }
        public string InstrumentId { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<ProductQuoteData> BidPrices { get; set; }
        public IEnumerable<ProductQuoteData> AskPrices { get; set; }

        public decimal IndicativeAskPrice
        {
            get { return AskPrices.OrderBy(x => x.Price).First().Price; }
        }

        public decimal IndicativeBidPrice
        {
            get { return BidPrices.OrderBy(x => x.Price).Last().Price; }
        }
    }

    public class ProductQuoteData
    {
        public double Volume { get; set; }
        public decimal Price { get; set; }
    }

    public interface IProductQuoteRepository : IRepository<IProductQuote>
    {
        Task<IProductQuote> GetByInstrumentId(string instrumentId);
    }
}