using System.Collections.Generic;

namespace Terminal.Domain.Exchange
{
    public class OrderBook
    {
        public string Symbol { get; set; }
        public IEnumerable<OrderBookDetails> BuyOrders { get; set; }
        public IEnumerable<OrderBookDetails> SellOrders { get; set; }
    }

    public class OrderBookDetails
    {
        public double Volume { get; set; }
        public double Price { get; set; }
    }
}