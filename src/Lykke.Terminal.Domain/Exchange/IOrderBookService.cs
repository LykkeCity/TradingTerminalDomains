using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IOrderBookService
    {
        Task<IEnumerable<OrderBook>> GetOrderBookAsync();
    }
}