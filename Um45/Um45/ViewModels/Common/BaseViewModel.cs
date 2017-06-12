using System;
using GalaSoft.MvvmLight.Command;
using sc.MobileApp.Mvvm.ViewModels.Common;
using Um45.Interfaces;
using Plugin.Connectivity;

namespace Um45.ViewModels.Common
{
    public class BaseViewModel : BaseWithProgress
    {
        public readonly IConnectivityService ConnectivityService;
        public readonly IUiHelper UiHelper;
        public readonly ILogger Logger;
        public readonly INavigationService NavigationService;
        public bool InternetConnection => CrossConnectivity.Current.IsConnected;

        //public BaseViewModel()
        //{
            
        //}


        //  public ServiceClient.ServiceClient Servicebroker = new ServiceClient.ServiceClient { BaseUrl = SuperApp.Instance.DEV_Endpoint, TokenKey = SuperApp.Instance.CurrentTokenKey };

        public BaseViewModel(IConnectivityService connectivityService
            , IUiHelper uiHelper
            , INavigationService navigationService
            , ILogger logger)
        {
            ConnectivityService = connectivityService;
        
            UiHelper = uiHelper;
            NavigationService = navigationService;
            Logger = logger;


            // will this fire in previous loaded viewmodels????
            CrossConnectivity.Current.ConnectivityTypeChanged += (object sender, Plugin.Connectivity.Abstractions.ConnectivityTypeChangedEventArgs e) =>
            {
                NotifyPropertyChanged("InternetConnection");
            };
        }

      

        private bool _isLogged;
        public bool IsLogged
        {
            get => _isLogged;
            set
            {
                if (_isLogged == value) return;
                _isLogged = value;
                NotifyPropertyChanged();
            }
        }

        private string _pageTitle;



        public string PageTitle
        {
            get => _pageTitle;
            set
            {
                if (_pageTitle == value) return;
                _pageTitle = value;
                NotifyPropertyChanged();
            }
        }



        private RelayCommand _goToDetails;
        public RelayCommand GoToDetails
        {
            get
            {
                return _goToDetails ?? (_goToDetails = new RelayCommand(
          async () =>
            {

                try
                {
                    LoadingCounter++;


                }
                catch (Exception ex)
                {

                    Logger.Log(ex);
                    await UiHelper.ShowAlert("DefaultErrorMessage");
                }
                finally
                {
                    LoadingCounter--;
                }



            }));
            }

        }



        private RelayCommand _goToHome;
        public RelayCommand GoToHome
        {
            get
            {
                return _goToHome ?? (_goToHome = new RelayCommand(
             () =>
            {

                try
                {
                    LoadingCounter++;


                }
                catch (Exception ex)
                {

                    Logger.Log(ex);
                    UiHelper.ShowAlert("DefaultErrorMessage");
                }
                finally
                {
                    LoadingCounter--;
                }



            }));
            }

        }



     


      



      



    }
}
