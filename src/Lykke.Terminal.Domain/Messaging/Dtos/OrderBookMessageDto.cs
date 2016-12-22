using System;
using System.Collections.Generic;
using Lykke.Terminal.Domain.ApplicationServices.Exchange;

namespace Lykke.Terminal.Domain.Messaging.Dtos
{
    public class OrderBookMessageDto
    {
        public string AssetPair { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<OrderBookDetailsDto> Bids { get; set; }
        public IEnumerable<OrderBookDetailsDto> Asks { get; set; }
    }
}