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
    }

    public interface IMarketProfileRepository : IRepository<IAssetPairQuote>
    {
    }
}