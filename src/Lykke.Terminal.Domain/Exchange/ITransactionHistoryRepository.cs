using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    //todo: change to real repository
    public interface ITransactionHistory
    {
        string AccountId { get; }

        string TransactionId { get; }

        string AssetPairId { get; }

        DateTime CompletedAt { get; }

        double ProfitLoss { get; }

        double Price { get; }
    }

    public class TransactionHistory : ITransactionHistory
    {
        public string AccountId { get; set; }

        public string TransactionId { get; set; }

        public string AssetPairId { get; set; }

        public DateTime CompletedAt { get; set; }

        public double ProfitLoss { get; set; }

        public double Price { get; set; }
    }

    public interface ITransactionHistoryRepository : IRepository<ITransactionHistory>
    {
        Task<IEnumerable<ITransactionHistory>> GetByClientId(string clientId);
    }
}