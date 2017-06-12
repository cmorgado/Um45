using System;
using System.Threading.Tasks;
using Um45.Interfaces;
using Um45.Views;
using Xamarin.Forms;

namespace Um45.Services
{
    public class UberNavigation : INavigationService
    {
        public MainPage HomeNavigation { get; set; }
        public async Task NavigateToDetails(string id)
        {
            await HomeNavigation.Navigation.PushAsync(new Views.Details());
        }

        public void NavigateToHome()
        {
          
        }

     
        public async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
          
        }

     

    
    }
}
