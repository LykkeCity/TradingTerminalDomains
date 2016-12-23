using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.ApplicationServices.Exchange
{
    public interface IMarketProfileAppService : IAppService
    {
        Task<IEnumerable<TopOrderBookDto>> GetMarketProfileAsync();
    }
}