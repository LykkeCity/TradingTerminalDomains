using System.Collections.Generic;

namespace Lykke.Terminal.Domain.Notifications
{
    public class MatchingEngineTopics
    {
        public const string AccountUpdated = "AccountUpdated";
        public const string AssetPairPriceUpdated = "AssetPairPriceUpdated";
        public const string ActiveOrdersUpdated = "ActiveOrdersUpdated";

        public static IEnumerable<string> AllTopics => new List<string>
        {
            AccountUpdated,
            AssetPairPriceUpdated,
            ActiveOrdersUpdated
        };
    }
}