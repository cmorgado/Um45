using System.Threading.Tasks;

namespace Um45.Interfaces
{
    public interface IConnectivityService
    {
        bool IsConnected();

        Task<bool> IsRemoteReachable();

    }
}
