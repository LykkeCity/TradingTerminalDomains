using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Accounts;
using Lykke.Terminal.Domain.Exchange;
using Lykke.Terminal.Domain.Messaging.Dtos;

namespace Lykke.Terminal.Domain.Notifications
{
    public interface IMatchingEngineEvents
    {
        Task AccountUpdatedAsync(AccountInfoDto account);

        Task AssetPairPriceUpdatedAsync(IAssetPairQuote assetPairQuote);

        Task ActiveOrdersUpdatedAsync(IEnumerable<MarketOrder> orders);

        Task OrderBookUpdatedAsync(OrderBookMessageDto message);
    }
}