using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IDoneOrderService
    {
        Task<IDoneOrder> CreateDoneOrderAsync(IOrderBase order, OrderStatus orderStatus, OrderComment orderComment,
            decimal profitLoss = 0);
    }
}