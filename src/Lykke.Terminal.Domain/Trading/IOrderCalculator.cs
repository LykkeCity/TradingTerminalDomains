using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Accounts;
using Lykke.Terminal.Domain.Assets;
using Lykke.Terminal.Domain.Exchange;

namespace Lykke.Terminal.Domain.Trading
{
    public interface IOrderCalculator
    {
        Task<double> CalculateProfitLossAsync(double openPrice, double closePrice, double volume, IAssetPair assetPair,
            string baseAssetId);

        Task<double> CalculateMarginUsageAsync(IEnumerable<IOrderBase> orders, ITradingAccount tradingAccount);
    }
}