using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IActiveOrderService
    {
        Task MoveOrderToDoneAsync(IOrderBase order, OrderStatus status = OrderStatus.Done,
            OrderComment comment = OrderComment.None, decimal profitLoss = 0);

        Task<IOrderBase> CreateActiveOrderAsync(IOrderBase currentOrder, IProductQuote currentQuote);
    }
}