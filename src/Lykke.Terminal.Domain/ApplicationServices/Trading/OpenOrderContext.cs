namespace Lykke.Terminal.Domain.ApplicationServices.Trading
{
    public class OpenOrderContext
    {
        public string AccountId { get; set; }
        public string InstrumentId { get; set; }
        public string TransactioAccountId { get; set; }
        public double Volume { get; set; }
        public double DefinedPrice { get; set; }
        public double? TakeProfit { get; set; }
        public double? StopLoss { get; set; }
    }
}