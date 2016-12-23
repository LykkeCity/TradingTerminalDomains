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
        WaitingForExecution,
        Active,
        Done,
        Cancelled,
        Rejected
    }

    public enum OrderComment
    {
        None,
        //closed since stopout amount is reached
        StopOut,
        //no quote exists for presented asset pair
        NoQuote,
        //manually closed
        Closed,
        //closed by take profit
        TakeProfit,
        //closed by stop loss
        StopLoss,
        //rejected by trade service
        TradeService
    }


    public interface IOrderBase
    {
        string Id { get; }
        string ClientId { get; }
        string TradingAccountId { get; }
        DateTime CreatedAt { get; }
        double Volume { get; }
        decimal Price { get; }
        string AssetPairId { get; }
        OrderStatus Status { get; }
        double DefinedPrice { get; }
        DateTime LastModified { get; }
        OrderComment Comment { get; }
        double TakeProfit { get; }
        double StopLoss { get; }
        double Commission { get; }
    }

    public class OrderBase : IOrderBase
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string TradingAccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Volume { get; set; }
        public decimal Price { get; set; }
        public string AssetPairId { get; set; }
        public OrderStatus Status { get; set; }
        public double DefinedPrice { get; set; }
        public DateTime LastModified { get; set; }
        public OrderComment Comment { get; set; }
        public double TakeProfit { get; set; }
        public double StopLoss { get; set; }
        public double Commission { get; set; }

        public static OrderBase Create(IOrderBase src)
        {
            return new OrderBase
            {
                Id = src.Id,
                ClientId = src.ClientId,
                TradingAccountId = src.TradingAccountId,
                CreatedAt = src.CreatedAt,
                Volume = src.Volume,
                Price = src.Price,
                AssetPairId = src.AssetPairId,
                Status = src.Status,
                DefinedPrice = src.DefinedPrice,
                LastModified = src.LastModified,
                Comment = src.Comment,
                TakeProfit = src.TakeProfit,
                StopLoss = src.StopLoss
            };
        }
    }

    public static class BaseOrderExt
    {
        public static OrderAction OrderAction(this IOrderBase orderBase)
        {
            return orderBase.Volume > 0 ? Exchange.OrderAction.Buy : Exchange.OrderAction.Sell;
        }

        public static bool IsActiveOrder(this IOrderBase order)
        {
            return !(!double.IsNaN(order.DefinedPrice) && (Math.Abs(order.DefinedPrice) > 0));
        }
    }
}