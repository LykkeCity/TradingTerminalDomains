using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IPendingOrdersRepository : IRepository<IOrderBase>
    {
        Task<IEnumerable<IOrderBase>> GetByInstrumentIdAsync(string instrumentId);
    }
}