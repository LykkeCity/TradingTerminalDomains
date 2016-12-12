using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Trading
{
    public interface ITradeExecutionService
    {
        Task<bool> CheckTradeRequestAsync(string orderId, string asset, double volume, double price);
    }
}