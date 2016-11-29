using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.ApplicationServices.Exchange
{
    public interface IOrderBookAppService : IAppService
    {
        Task<IEnumerable<OrderBookDto>> GetOrderBookAsync();
    }
}