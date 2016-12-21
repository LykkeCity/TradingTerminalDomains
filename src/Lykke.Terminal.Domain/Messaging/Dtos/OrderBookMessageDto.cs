﻿using System;
using System.Collections.Generic;
using Lykke.Terminal.Domain.ApplicationServices.Exchange;

namespace Lykke.Terminal.Domain.Messaging.Dtos
{
    public class OrderBookMessageDto
    {
        public string AssetPair { get; set; }
        public bool IsBuy { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<OrderBookDetailsDto> Prices { get; set; }

    }
}