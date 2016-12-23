namespace Lykke.Terminal.Domain.Assets
{
    public interface IInstrumentCommission
    {
        string InstrumentId { get; }
        double OpenCommission { get; }
        double CloseCommission { get; }
    }

    public class InstrumentCommission : IInstrumentCommission
    {
        public string InstrumentId { get; set; }
        public double OpenCommission { get; set; }
        public double CloseCommission { get; set; }
    }
}