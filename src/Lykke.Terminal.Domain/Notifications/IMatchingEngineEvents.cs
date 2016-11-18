using System.Threading.Tasks;
using Lykke.Terminal.Domain.Accounts;
using Lykke.Terminal.Domain.Exchange;

namespace Lykke.Terminal.Domain.Notifications
{
    public interface IMatchingEngineEvents
    {
        Task AccountUpdatedAsync(IAccountInfo account);

        Task AssetPairPriceUpdatedAsync(IAssetPairQuote assetPairQuote);

        Task ActiveOrdersUpdatedAsync(string accountId);
    }
}