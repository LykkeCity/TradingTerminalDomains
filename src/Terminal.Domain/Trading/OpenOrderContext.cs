namespace Terminal.Domain.Trading
{
    public class OpenOrderContext
    {
        public string AccountId { get; set; }
        public string AssetPairId { get; set; }
        public double Volume { get; set; }
        public double DefinedPrice { get; set; }
    }
}