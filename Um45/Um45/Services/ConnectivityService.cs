using System.Threading.Tasks;
using Plugin.Connectivity;
using Um45.Interfaces;

namespace Um45.Services
{
    public class ConnectivityService : IConnectivityService
    {
        public bool IsConnected()
        {


            return CrossConnectivity.Current.IsConnected;
        }

        public async Task<bool> IsRemoteReachable()
        {
            return await CrossConnectivity.Current.IsReachable("http://www.google.com", 1000);
        }
    }
}
