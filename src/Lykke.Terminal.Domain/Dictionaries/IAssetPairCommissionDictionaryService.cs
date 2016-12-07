using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Assets;

namespace Lykke.Terminal.Domain.Dictionaries
{
    public interface IAssetPairCommissionDictionaryService
    {
        Task<IEnumerable<IAssetPairCommission>> GetAllAsync();
        Task<IAssetPairCommission> GetByAssetPairId(string assetPairId);
    }
}