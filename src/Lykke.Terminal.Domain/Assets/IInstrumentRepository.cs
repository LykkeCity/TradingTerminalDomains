using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Terminal.Domain.Infrastructure;

namespace Lykke.Terminal.Domain.Assets
{
    public interface IInstrument
    {
        string Id { get; }
        string Name { get; }
        int Accuracy { get; }
        string BaseAssetId { get; }
        string QuotingAssetId { get; }
        int InvertedAccuracy { get; }
        double SwapShort { get; }
        double SwapLong { get; }
    }

    public class Instrument : IInstrument
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Accuracy { get; set; }
        public string BaseAssetId { get; set; }
        public string QuotingAssetId { get; set; }
        public int InvertedAccuracy { get; set; }
        public double SwapShort { get; set; }
        public double SwapLong { get; set; }
    }

    public interface IInstrumentRepository : IRepository<IInstrument>
    {
        Task AddAllAsync(IEnumerable<IInstrument> instruments);
        Task<IInstrument> GetByBaseAndQuotingIds(string baseAssetId, string quotingAssetId);
    }
}