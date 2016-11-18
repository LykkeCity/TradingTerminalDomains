using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Messaging
{
    public interface IBroker
    {
        Task SendMessageAsync<T>(string topic, IEnumerable<string> subscriberList, T message);

        Task SubscribeAsync<T>(string topic, IEnumerable<string> subscriberList,
            Func<T, IBrokerMessageContext, Task> messageCallbackAsyncFunc);
    }
}