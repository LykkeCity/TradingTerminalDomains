using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Exchange;
using Lykke.Terminal.Domain.Messaging.Dtos;

namespace Lykke.Terminal.Domain.Notifications
{
    public interface IMatchingEngineEvents
    {
        Task AccountUpdatedAsync(AccountInfoDto account);

        Task ActiveOrdersUpdatedAsync(IEnumerable<OrderBase> orders);

        Task OrderBookUpdatedAsync(OrderBookMessageResponseDto message);
    }
}