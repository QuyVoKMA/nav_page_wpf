using PageNavigation.Ultilities;
using PageNavigation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigation.ViewModel
{
    class SettingsViewModel: ViewModelBase
    {
        private readonly PageModel _pageModel;
        public bool Settings
        {
            get { return _pageModel.LocationStatus; }
            set { _pageModel.LocationStatus = value;OnPropertyChanged(); }
        }
        public SettingsViewModel() 
        {
            _pageModel = new PageModel();
            Settings = true;
        }
    }
}
