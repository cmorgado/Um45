using GalaSoft.MvvmLight.Ioc;
using Um45.Interfaces;

namespace Um45.Droid.Code
{
   public static class RegisterServices
    {
        public static void Init()
        {
            
            if (!SimpleIoc.Default.IsRegistered<ILogger>())
                SimpleIoc.Default.Register<ILogger>(() => new Um45.Droid.Services.Logger());

         
        }
    }
}