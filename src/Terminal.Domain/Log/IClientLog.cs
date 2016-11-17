using System.Threading.Tasks;

namespace Terminal.Domain.Log
{
    public interface IClientLog
    {
        Task WriteAsync(string userId, string dataId);
    }
}
