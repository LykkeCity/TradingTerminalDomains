using System.Threading.Tasks;
using Lykke.Terminal.Domain.Accounts;
using Lykke.Terminal.Domain.Messaging.Dtos;

namespace Lykke.Terminal.Domain.ApplicationServices.Accounts
{
    public interface IAccountAppService
    {
        Task UpdateAccountInfoAsync(AccountInfo context);
        Task<AccountInfoDto> GetAccountInfoAsync(string accountId);
    }
}