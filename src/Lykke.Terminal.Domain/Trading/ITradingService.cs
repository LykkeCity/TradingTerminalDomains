using System.Threading.Tasks;
using Lykke.Terminal.Domain.Exchange;

namespace Lykke.Terminal.Domain.Trading
{
    public interface ITradingService
    {
        Task CloseOrderAsync(IOrderBase activeOrder, OrderComment orderComment);
        bool IsTakeProfitCorrect(IOrderBase order, double price);
        bool IsStopLossCorrect(IOrderBase order, double price);
        bool IsTakeProfitReached(IOrderBase order, AssetPairQuote assetPairQuote);
        bool IsStopLossReached(IOrderBase order, AssetPairQuote assetPairQuote);
    }
}