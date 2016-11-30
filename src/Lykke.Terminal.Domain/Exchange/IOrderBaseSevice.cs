using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IOrderBaseSevice
    {
        Task MoveOrderToDoneAsync(IOrderBase order, OrderStatus status = OrderStatus.Done,
            double profitLoss = double.NaN);
    }
}