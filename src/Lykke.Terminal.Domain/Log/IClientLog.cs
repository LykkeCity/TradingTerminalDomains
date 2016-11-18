using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Log
{
    public interface IClientLog
    {
        Task WriteAsync(string userId, string dataId);
    }
}
