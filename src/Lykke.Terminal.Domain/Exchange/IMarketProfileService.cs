using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IMarketProfileService
    {
        Task UpdateMarketProfileAsync(IProductQuote productQuote);
        Task<ProductQuote> GetIntrumentQuoteAsync(string instrumentId);
    }
}