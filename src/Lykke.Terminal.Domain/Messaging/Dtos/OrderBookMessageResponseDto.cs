using System;
using Lykke.Terminal.Domain.ApplicationServices.Exchange;

namespace Lykke.Terminal.Domain.Messaging.Dtos
{
    public class OrderBookMessageResponseDto : OrderBookDto
    {
        public DateTime Timestamp { get; set; }
        public decimal IndicativeAskPrice { get; set; }
        public decimal IndicativeBidPrice { get; set; }
    }
}