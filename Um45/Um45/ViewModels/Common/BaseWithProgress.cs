using Um45.Models;

namespace Um45.ViewModels.Common
{
    public class BaseWithProgress : ModelBase
    {
        private int _loadingCounter;
        public int LoadingCounter
        {
            get => _loadingCounter;
            set
            {
                _loadingCounter = value;
                if (_loadingCounter < 0)
                    _loadingCounter = 0;
                IsLoading = _loadingCounter > 0;
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                NotifyPropertyChanged();
            }
        }
    }
}