using System.Collections.Generic;

namespace Lykke.Terminal.Domain.ApplicationServices.Exchange
{
    public class OrderBookDto
    {
        public string InstrumentId { get; set; }
        public IEnumerable<OrderBookDetailsDto> BidPrices { get; set; }
        public IEnumerable<OrderBookDetailsDto> AskPrices { get; set; }
    }

    public class OrderBookDetailsDto
    {
        public double Volume { get; set; }
        public decimal Price { get; set; }
    }
}