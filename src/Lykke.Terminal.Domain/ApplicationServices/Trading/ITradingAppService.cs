using System.Threading.Tasks;
using Lykke.Terminal.Domain.Trading;

namespace Lykke.Terminal.Domain.ApplicationServices.Trading
{
    public interface ITradingAppService : IAppService
    {
        Task OpenOrderAsync(OpenOrderContext context);

        Task CloseOrderAsync(string accountId, string orderId);
    }
}