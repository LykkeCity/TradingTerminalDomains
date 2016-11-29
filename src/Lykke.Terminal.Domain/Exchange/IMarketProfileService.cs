using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IMarketProfileService
    {
        Task UpdateMarketProfileAsync(IOrderBook order);
    }
}