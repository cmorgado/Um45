using Xamarin.Forms;

namespace Um45.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = App.Locator.Home;
        }
    }
}
