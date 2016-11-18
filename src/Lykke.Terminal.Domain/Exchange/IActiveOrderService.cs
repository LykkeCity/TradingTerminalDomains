using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IActiveOrderService
    {
        Task<IEnumerable<MarketOrder>> GetActiveOrders(string clientId);
    }
}