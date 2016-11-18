using System.Threading.Tasks;
using Lykke.Terminal.Domain.Assets;

namespace Lykke.Terminal.Domain.Trading
{
    public interface IOrderCalculator
    {
        Task<double> CalculateProfitLossAsync(double openPrice, double closePrice, double volume, IAssetPair assetPair,
            string baseAssetId);
    }
}