using System.Collections.Generic;

namespace Lykke.Terminal.Domain.Notifications
{
    public class MatchingEngineEventName
    {
        public const string AccountUpdated = "AccountUpdated";
        public const string ActiveOrdersUpdated = "ActiveOrdersUpdated";
        public const string OrderBookUpdated = "lykke.orderbook";

        public static IEnumerable<string> AllTopics => new List<string>
        {
            AccountUpdated,
            ActiveOrdersUpdated,
            OrderBookUpdated
        };
    }
}