using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IActiveOrderSevice
    {
        Task MoveOrderToDoneAsync(IOrderBase order, OrderStatus status = OrderStatus.Done,
            OrderComment comment = OrderComment.None, double profitLoss = double.NaN);
    }
}