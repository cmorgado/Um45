using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using Um45.Interfaces;
using Um45.Models;
using Um45.Services;
using Um45.ViewModels.Common;

namespace Um45.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(IConnectivityService connectivityService
            , IUiHelper uiHelper
            , INavigationService navigationService
            , ILogger logger) : base(connectivityService, uiHelper, navigationService, logger)
        {
           
        }

        private ObservableCollection<GitHubGuy> _items = new ObservableCollection<GitHubGuy>();
        public ObservableCollection<GitHubGuy> Items

        {
            get => _items;
            set
            {
                if (_items == value) return;
                _items = value;
                NotifyPropertyChanged();
            }
        }



        private string _searchQuery;
        public string SearchQuery

        {
            get => _searchQuery;
            set
            {
                if (_searchQuery == value) return;
                _searchQuery = value;
                NotifyPropertyChanged();
            }
        }

        private int _totalFound;
        public int TotalFound

        {
            get => _totalFound;
            set
            {
                if (_totalFound == value) return;
                _totalFound = value;
                NotifyPropertyChanged();
            }
        }

        private RelayCommand _load;

        public RelayCommand Load
        {
            get
            {
                return _load ?? (_load = new RelayCommand(
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

        private RelayCommand<string> _gotoDetails;

        public RelayCommand<string> GotoDetails
        {
            get
            {
                return _gotoDetails ?? (_gotoDetails = new RelayCommand<string>(
                           async (id) =>
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

        private RelayCommand _doSearch;

        public RelayCommand DoSearch
        {
            get
            {
                return _doSearch ?? (_doSearch = new RelayCommand(
                           async () =>
                           {
                               try
                               {
                                   LoadingCounter++;
                                   var miniGitHubClient = new MiniGitHubClient();
                                   var r = await miniGitHubClient.Search(SearchQuery);
                                   if (r.Error.HasError)
                                       await UiHelper.ShowAlert("DefaultErrorMessage");
                                   else
                                   {
                                       Items.Clear();
                                       TotalFound = r.Data.TotalCount;
                                       foreach (var dataItem in r.Data.Items)
                                       {
                                           Items.Add(new GitHubGuy { Name = dataItem.Login, Avatar = dataItem.AvatarUrl });
                                       }
                                   }


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
    }
}
