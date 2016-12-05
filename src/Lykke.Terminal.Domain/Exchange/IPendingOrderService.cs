using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IPendingOrderService
    {
        Task MoveOrderToActiveAsync(IOrderBase pendingOrder, IAssetPairQuote assetPairQuote);
    }
}