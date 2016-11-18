using System.ComponentModel.DataAnnotations;

namespace Lykke.Terminal.Domain.Settings
{
    public interface IBaseSettings
    {
        DbSettings Db { get; set; }
        MatchingEngine MatchingEngineSettings { get; set; }
    }

    public class DbSettings
    {
        [Required]
        public string LogsConnString { get; set; }

        [Required]
        public string ALimitOrdersConnString { get; set; }

        [Required]
        public string HLimitOrdersConnString { get; set; }

        [Required]
        public string HMarketOrdersConnString { get; set; }

        [Required]
        public string HTradesConnString { get; set; }

        [Required]
        public string HLiquidityConnString { get; set; }

        [Required]
        public string ClientPersonalInfoConnString { get; set; }

        [Required]
        public string DictsConnString { get; set; }
    }

    public class MatchingEngine
    {
        [Required]
        public ServiceBus ServiceBusConnection { get; set; }

        public string SubsriptionName { get; set; }
    }

    public class ServiceBus
    {
        [Required]
        public string ServiceBusNamespace { get; set; }

        [Required]
        public string ServiceBusPolicyName { get; set; }

        [Required]
        public string ServiceBusKey { get; set; }
    }

    public class BaseSettings : IBaseSettings
    {
        [Required]
        public DbSettings Db { get; set; }

        public MatchingEngine MatchingEngineSettings { get; set; }
    }
}