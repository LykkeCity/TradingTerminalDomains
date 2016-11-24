using System.Collections.Generic;

namespace Lykke.Terminal.Domain.Exchange
{
    public class OrderBookDto
    {
        public string Symbol { get; set; }
        public IEnumerable<OrderBookDetailsDto> BuyOrders { get; set; }
        public IEnumerable<OrderBookDetailsDto> SellOrders { get; set; }
    }

    public class OrderBookDetailsDto
    {
        public double Volume { get; set; }
        public double Price { get; set; }
    }
}