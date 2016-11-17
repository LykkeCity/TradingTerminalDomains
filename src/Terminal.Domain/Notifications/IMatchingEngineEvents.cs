using System.Threading.Tasks;
using Terminal.Domain.Accounts;
using Terminal.Domain.Exchange;

namespace Terminal.Domain.Notifications
{
    public interface IMatchingEngineEvents
    {
        Task AccountUpdatedAsync(IAccountInfo account);

        Task AssetPairPriceUpdatedAsync(IAssetPairQuote assetPairQuote);

        Task ActiveOrdersUpdatedAsync(string accountId);
    }
}