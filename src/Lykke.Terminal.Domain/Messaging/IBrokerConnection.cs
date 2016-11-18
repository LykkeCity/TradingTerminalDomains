using System;

namespace Lykke.Terminal.Domain.Messaging
{
    public interface IBrokerConnection : IDisposable
    {
        IBroker GetBroker();
    }
}