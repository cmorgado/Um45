namespace Um45.Models
{
  public  class GitHubGuy:ModelBase
    {
        private string _name;
        public string Name

        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                NotifyPropertyChanged();
            }
        }

        private string _avatar;
        public string Avatar

        {
            get => _avatar;
            set
            {
                if (_avatar == value) return;
                _avatar = value;
                NotifyPropertyChanged();
            }
        }
    }
}
