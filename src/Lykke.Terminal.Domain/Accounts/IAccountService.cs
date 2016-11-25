using System.Threading.Tasks;
using Lykke.Terminal.Domain.Messaging.Dtos;

namespace Lykke.Terminal.Domain.Accounts
{
    public interface IAccountService
    {
        Task UpdateAccountInfoAsync(AccountInfo context);
        Task<AccountInfoDto> GetAccountInfoAsync(string accountId);
    }
}