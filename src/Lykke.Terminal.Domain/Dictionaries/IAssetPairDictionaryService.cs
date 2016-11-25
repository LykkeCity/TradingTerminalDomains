using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Assets;

namespace Lykke.Terminal.Domain.Dictionaries
{
    public interface IAssetPairDictionaryService
    {
        Task<IEnumerable<IAssetPair>> GetAllAsync();
        Task<IAssetPair> GetByBaseAndQuotingIds(string baseAssetId, string quotingAssetId);
        Task<IAssetPair> GetByIdAsync(string id);
    }
}