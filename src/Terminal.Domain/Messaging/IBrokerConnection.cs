using System;

namespace Terminal.Domain.Messaging
{
    public interface IBrokerConnection : IDisposable
    {
        IBroker GetBroker();
    }
}