using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Accounts
{
    public interface IAccountService
    {
        Task UpdateAccountInfoAsync(AccountInfo context);
        Task<AccountInfo> GetAccountInfoAsync(string accountId);
    }
}