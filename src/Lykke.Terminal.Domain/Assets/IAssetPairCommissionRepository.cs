namespace Lykke.Terminal.Domain.Assets
{
    public interface IAssetPairCommission
    {
        string AssetPairId { get; }
        double OpenCommission { get; }
        double CloseCommission { get; }
    }

    public class AssetPairCommission : IAssetPairCommission
    {
        public string AssetPairId { get; set; }
        public double OpenCommission { get; set; }
        public double CloseCommission { get; set; }
    }
}