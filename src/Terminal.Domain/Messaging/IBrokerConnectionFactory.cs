namespace Terminal.Domain.Messaging
{
    public interface IBrokerConnectionFactory
    {
        IBrokerConnection Create(IBrokerConfiguration config);
    }
}