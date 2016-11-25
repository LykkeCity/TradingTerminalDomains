using System;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IAssetPairQuote
    {
        string AssetPairId { get; }

        DateTime DateTime { get; }

        double Bid { get; }

        double Ask { get; }
    }

    public class AssetPairQuote : IAssetPairQuote
    {
        public string AssetPairId { get; set; }

        public DateTime DateTime { get; set; }

        public double Bid { get; set; }

        public double Ask { get; set; }

        public static AssetPairQuote Create(IAssetPairQuote src)
        {
            return new AssetPairQuote
            {
                AssetPairId = src.AssetPairId,
                DateTime = src.DateTime,
                Bid = src.Bid,
                Ask = src.Ask
            };
        }
    }

    public interface IMarketProfileRepository : IRepository<IAssetPairQuote>
    {
    }
}