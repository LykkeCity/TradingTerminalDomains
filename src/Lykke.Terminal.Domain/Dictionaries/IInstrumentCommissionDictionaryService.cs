using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Assets;

namespace Lykke.Terminal.Domain.Dictionaries
{
    public interface IInstrumentCommissionDictionaryService
    {
        Task<IEnumerable<IInstrumentCommission>> GetAllAsync();
        Task<IInstrumentCommission> GetByInstrumentIdAsync(string instrumentId);
    }
}