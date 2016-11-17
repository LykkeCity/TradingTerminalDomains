using System.Collections.Generic;
using System.Threading.Tasks;

namespace Terminal.Domain.Exchange
{
    public interface IOrderBookService
    {
        Task<IEnumerable<OrderBook>> GetOrderBookAsync();
    }
}