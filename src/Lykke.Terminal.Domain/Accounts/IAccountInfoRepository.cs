using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Accounts
{
    //TODO: change to real repository
    public interface IAccountInfo
    {
        string AccountId { get; }

        double Balance { get; }

        string BaseAssetId { get; }

        double Leverage { get; }
    }

    public class AccountInfo : IAccountInfo
    {
        public string AccountId { get; set; }
        public double Balance { get; set; }
        public string BaseAssetId { get; set; }
        public double Leverage { get; set; }

        private AccountInfo() { }

        public static AccountInfo Create(IAccountInfo src)
        {
            return new AccountInfo
            {
                AccountId = src.AccountId,
                BaseAssetId = src.BaseAssetId,
                Balance = src.Balance,
                Leverage = src.Leverage
            };
        }

        public static IAccountInfo CreateDefault(string accountId)
        {
            return new AccountInfo
            {
                AccountId = accountId,
                Balance = AccountInfoDefaults.Balance,
                Leverage = AccountInfoDefaults.Leverage,
                BaseAssetId = AccountInfoDefaults.BaseAsset
            };
        }
    }

    public static class AccountInfoDefaults
    {
        public static double Balance = 50000;
        public static int Leverage = 200;
        public static string BaseAsset = "EUR";
    }

    public interface IAccountInfoRepository : IRepository<IAccountInfo>
    {
    }
}