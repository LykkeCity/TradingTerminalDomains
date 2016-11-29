using System;

namespace Lykke.Terminal.Domain.Exchange
{
    public enum OrderAction
    {
        Buy,
        Sell
    }

    public enum OrderStatus
    {
        Pending,
        Active,
        Done,
        Cancelled
    }

    public enum OrderComment
    {
        //closed since stopout amount is reached
        StopOut
    }


    public interface IOrderBase
    {
        string Id { get; }
        string ClientId { get; }
        string TradingAccountId { get; }
        DateTime CreatedAt { get; }
        double Volume { get; }
        double Price { get; }
        string AssetPairId { get; }
        string Status { get; }
        double DefinedPrice { get; }
        DateTime LastModified { get; }
    }

    public class OrderBase : IOrderBase
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string TradingAccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public string AssetPairId { get; set; }
        public string Status { get; set; }
        public double DefinedPrice { get; set; }
        public DateTime LastModified { get; set; }
    }

    public static class BaseOrderExt
    {
        public static OrderAction OrderAction(this IOrderBase orderBase)
        {
            return orderBase.Volume > 0 ? Exchange.OrderAction.Buy : Exchange.OrderAction.Sell;
        }
    }
}