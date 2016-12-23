using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IDoneOrder : IOrderBase
    {
        decimal ProfitLoss { get; }
    }

    public class DoneOrder : IDoneOrder
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string TradingAccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Volume { get; set; }
        public decimal Price { get; set; }
        public string InstrumentId { get; set; }
        public OrderStatus Status { get; set; }
        public double DefinedPrice { get; set; }
        public DateTime LastModified { get; set; }
        public OrderComment Comment { get; set; }
        public double TakeProfit { get; set; }
        public double StopLoss { get; set; }
        public double Commission { get; set; }
        public decimal ProfitLoss { get; set; }
    }

    public interface IDoneOrdersRepository : IRepository<IDoneOrder>
    {
        Task<IEnumerable<IDoneOrder>> GetByClientId(string clientId);
    }
}