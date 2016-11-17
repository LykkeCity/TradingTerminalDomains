using System.Threading.Tasks;
using Terminal.Domain.Assets;

namespace Terminal.Domain.Trading
{
    public interface IOrderCalculator
    {
        Task<double> CalculateProfitLossAsync(double openPrice, double closePrice, double volume, IAssetPair assetPair,
            string baseAssetId);
    }
}