using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Accounts;
using Lykke.Terminal.Domain.Assets;
using Lykke.Terminal.Domain.Exchange;

namespace Lykke.Terminal.Domain.Trading
{
    public interface IOrderCalculator
    {
        Task<decimal> CalculateProfitLossAsync(decimal openPrice, decimal closePrice, double volume, IInstrument instrument, string baseAssetId);

        Task<decimal> CalculateMarginUsageAsync(IEnumerable<IOrderBase> orders, ITradingAccount tradingAccount);
    }
}