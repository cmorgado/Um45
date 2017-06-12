using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Um45.Interfaces;
using Um45.ViewModels.Common;

namespace Um45.ViewModels
{
   public class DetailsViewModel:BaseViewModel
    {
        public DetailsViewModel(IConnectivityService connectivityService, IUiHelper uiHelper, INavigationService navigationService, ILogger logger) : base(connectivityService, uiHelper, navigationService, logger)
        {
        }
    }
}
