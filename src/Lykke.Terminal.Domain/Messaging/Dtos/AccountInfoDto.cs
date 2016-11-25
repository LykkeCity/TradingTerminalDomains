using System.Collections.Generic;

namespace Lykke.Terminal.Domain.Messaging.Dtos
{
    public class AccountInfoDto
    {
        public string AccountId { get; set; }
        public IEnumerable<TradingAccountDto> TradingAccounts { get; set; }
    }

    public class TradingAccountDto
    {
        public string TradingAccountId { get; set; }
        public double Balance { get; set; }
        public string BaseAssetId { get; set; }
        public double Leverage { get; set; }
    }
}