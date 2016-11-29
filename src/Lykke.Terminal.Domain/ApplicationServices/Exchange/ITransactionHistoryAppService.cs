using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Exchange;

namespace Lykke.Terminal.Domain.ApplicationServices.Exchange
{
    public interface ITransactionHistoryAppService : IAppService
    {
        Task<IEnumerable<TransactionHistory>> GetTransactionHistoryAsync(string accountId);
    }
}