using System;

namespace Lykke.Terminal.Domain.ApplicationServices.Exchange
{
    public class TopOrderBookDto
    {
        public string InstrumentId { get; set; }

        public DateTime Timestamp { get; set; }

        public decimal Bid { get; set; }

        public decimal Ask { get; set; }
    }
}