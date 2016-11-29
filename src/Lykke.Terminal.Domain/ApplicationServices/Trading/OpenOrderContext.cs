namespace Lykke.Terminal.Domain.ApplicationServices.Trading
{
    public class OpenOrderContext
    {
        public string AccountId { get; set; }
        public string AssetPairId { get; set; }
        public string TransactioAccountId { get; set; }
        public double Volume { get; set; }
        public double DefinedPrice { get; set; }
    }
}