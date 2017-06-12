using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Um45.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<DetailsViewModel>();



        }
        //public HomeMenu HomeMenu => ServiceLocator.Current.GetInstance<HomeMenu>();

        public HomeViewModel Home => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public DetailsViewModel Details => ServiceLocator.Current.GetInstance<DetailsViewModel>();


    }
}
