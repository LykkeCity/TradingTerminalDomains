using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IProductQuoteService
    {
        Task UpdateOrdersOnQuoteChangeAsync(IProductQuote productQuote);
        Task<ProductQuote> GetProductQuoteAsync(string instrumentId);
    }
}