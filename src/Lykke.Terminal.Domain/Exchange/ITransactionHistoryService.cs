using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface ITransactionHistoryService
    {
        Task<IEnumerable<TransactionHistory>> GetTransactionHistoryAsync(string accountId);
    }
}