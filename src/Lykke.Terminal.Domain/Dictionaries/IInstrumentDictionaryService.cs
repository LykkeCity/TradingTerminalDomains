using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Assets;

namespace Lykke.Terminal.Domain.Dictionaries
{
    public interface IInstrumentDictionaryService
    {
        Task<IEnumerable<IInstrument>> GetAllAsync();
        Task<IInstrument> GetByBaseAndQuotingIds(string baseAssetId, string quotingAssetId);
        Task<IInstrument> GetByIdAsync(string id);
    }
}