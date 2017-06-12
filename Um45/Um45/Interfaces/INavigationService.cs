using System;
using System.Threading.Tasks;

namespace Um45.Interfaces
{
    public interface INavigationService
    {
        Task GoBack();
        
        Task NavigateToDetails(string id);

        void NavigateToHome();
      
    }
}