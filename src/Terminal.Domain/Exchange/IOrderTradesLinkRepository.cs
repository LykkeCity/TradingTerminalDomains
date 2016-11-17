using System.Collections.Generic;
using System.Threading.Tasks;

namespace Terminal.Domain.Exchange
{
    public interface IOrderTradeLink
    {
        string MarketOrderId { get; }
        string LimitOrderId { get; }
    }

    public class OrderTradeLink : IOrderTradeLink
    {
        public string MarketOrderId { get; set; }
        public string LimitOrderId { get; set; }
    }

    public interface IOrderTradesLinkRepository
    {
        Task<IEnumerable<string>> GetAsync(string orderId);
        Task AddAsync(IOrderTradeLink orderTradeLink);
        Task AddAsync(IEnumerable<IOrderTradeLink> orderTradeLinks);
    }
}