using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IMarketProfileService
    {
        Task<IEnumerable<AssetPairQuote>> GetMarketProfileAsync();
        Task UpdateMarketProfileAsync(IOrderBook order);
    }
}