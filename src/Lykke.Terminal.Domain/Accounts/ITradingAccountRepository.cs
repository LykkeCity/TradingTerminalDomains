using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Accounts
{
    public interface ITradingAccount
    {
        string TradingAccountId { get; }
        string AccountId { get; }
        decimal Balance { get; }
        string BaseAssetId { get; }
        double Leverage { get; }
        double StopOut { get; }
    }

    public class TradingAccount : ITradingAccount
    {
        public string TradingAccountId { get; set; }
        public string AccountId { get; set; }
        public decimal Balance { get; set; }
        public string BaseAssetId { get; set; }
        public double Leverage { get; set; }
        public double StopOut { get; set; }

        public static TradingAccount Create(ITradingAccount src)
        {
            return new TradingAccount
            {
                TradingAccountId = src.TradingAccountId,
                AccountId = src.AccountId,
                Balance = src.Balance,
                Leverage = src.Leverage,
                BaseAssetId = src.BaseAssetId,
                StopOut = src.StopOut
            };
        }

        public static ITradingAccount CreateDefault(string accountId)
        {
            return new TradingAccount
            {
                TradingAccountId = Guid.NewGuid().ToString(),
                AccountId = accountId,
                Balance = TradingAccountInfoDefaults.Balance,
                Leverage = TradingAccountInfoDefaults.Leverage,
                BaseAssetId = TradingAccountInfoDefaults.BaseAsset,
                StopOut = TradingAccountInfoDefaults.StopOut
            };
        }
    }

    public static class TradingAccountInfoDefaults
    {
        public static decimal Balance = 50000;
        public static int Leverage = 200;
        public static string BaseAsset = "EUR";
        public static double StopOut = 20;
    }

    public interface ITradingAccountRepository : IRepository<ITradingAccount>
    {
        Task<IEnumerable<ITradingAccount>> GetByClientId(string clientId);
    }
}