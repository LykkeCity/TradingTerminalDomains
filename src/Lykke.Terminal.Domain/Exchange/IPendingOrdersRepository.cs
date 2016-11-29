using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IPendingOrdersRepository : IRepository<IOrderBase>
    {
        Task<IEnumerable<IOrderBase>> GetByAssetPairIdAsync(string assetPairId);
    }
}