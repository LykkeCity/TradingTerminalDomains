using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Trading
{
    public interface ITradingService
    {
        Task OpenOrderAsync(OpenOrderContext context);

        Task CloseOrderAsync(string accountId, string orderId);
    }
}