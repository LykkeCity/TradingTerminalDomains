using System.Collections.Generic;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Accounts
{
    public interface IAccountInfo
    {
        string AccountId { get; }
    }

    public class AccountInfo : IAccountInfo
    {
        public string AccountId { get; set; }

        private AccountInfo() { }

        public static AccountInfo Create(IAccountInfo src)
        {
            return new AccountInfo
            {
                AccountId = src.AccountId
            };
        }

        public static IAccountInfo CreateDefault(string accountId)
        {
            return new AccountInfo
            {
                AccountId = accountId
            };
        }
    }

    public interface IAccountInfoRepository : IRepository<IAccountInfo>
    {
    }
}