using System.Threading.Tasks;
using Um45.Interfaces;
using Xamarin.Forms;

namespace Um45.Services
{
    public class UiHelper : IUiHelper
    {
        public async Task ShowAlert(string message)
        {
            await ShowAlert("Alerta", message);
        }

        public async Task ShowAlert(string title, string message)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, "OK");
        }

     


   

      

      
    }
}
