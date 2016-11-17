using System.Threading.Tasks;

namespace Terminal.Domain.Accounts
{
    public interface IAccountService
    {
        Task UpdateAccountInfoAsync(AccountInfo context);
        Task<AccountInfo> GetAccountInfoAsync(string accountId);
    }
}