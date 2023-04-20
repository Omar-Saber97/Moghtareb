using Moghtareb.Models;

namespace Moghtareb.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        int Complete();
        Task<int> CompleteAsync();
    }
}
