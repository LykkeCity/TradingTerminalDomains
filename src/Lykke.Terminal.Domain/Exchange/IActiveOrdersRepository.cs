using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IActiveOrdersRepository : IRepository<IOrderBase>
    {
        Task<IEnumerable<IOrderBase>> GetByClientId(string clientId);
        Task<IEnumerable<IOrderBase>> GetByTradingAccountId(string tradingAccountId);
    }
}