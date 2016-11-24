using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Messaging.Handlers
{
    public interface IBrokerMessageHandler<T> where T : class
    {
        Task HandleAsync(T message, IBrokerMessageContext context);
    }
}