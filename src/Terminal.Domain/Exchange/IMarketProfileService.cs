using System.Collections.Generic;
using System.Threading.Tasks;

namespace Terminal.Domain.Exchange
{
    public interface IMarketProfileService
    {
        Task<IEnumerable<AssetPairQuote>> GetMarketProfileAsync();
    }
}