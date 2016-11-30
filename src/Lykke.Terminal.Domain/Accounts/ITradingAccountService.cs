using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Accounts
{
    public interface ITradingAccountService
    {
        Task<bool> IsStopOutReachedAsync(string tradingAccountId);

        Task ForcedLiquidationAsync(string tradingAccountId);
    }
}