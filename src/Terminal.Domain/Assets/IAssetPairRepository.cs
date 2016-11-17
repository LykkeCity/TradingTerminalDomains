using System.Collections.Generic;
using System.Threading.Tasks;
using Terminal.Domain.Infrastructure;

namespace Terminal.Domain.Assets
{
    public interface IAssetPair
    {
        string Id { get; }
        string Name { get; }
        int Accuracy { get; }
        string BaseAssetId { get; }
        string QuotingAssetId { get; }
        int InvertedAccuracy { get; }
    }

    public class AssetPair : IAssetPair
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Accuracy { get; set; }
        public string BaseAssetId { get; set; }
        public string QuotingAssetId { get; set; }
        public int InvertedAccuracy { get; set; }
    }

    public interface IAssetPairRepository : IRepository<IAssetPair>
    {
        Task AddAllAsync(IEnumerable<IAssetPair> assetPairs);
        Task<IAssetPair> GetByBaseAndQuotingIds(string baseAssetId, string quotingAssetId);
    }
}