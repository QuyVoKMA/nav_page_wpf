using PageNavigation.Ultilities;
using PageNavigation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigation.ViewModel
{
    class TransationsViewModel: ViewModelBase
    {
        private readonly PageModel _pageModel;
        public decimal TransactionAmount
        {
            get { return _pageModel.TransactionValue; }
            set { _pageModel.TransactionValue = value; OnPropertyChanged(); }
        }
        public TransationsViewModel() 
        {
            _pageModel = new PageModel();
            TransactionAmount = 5638;
        }
    }
}
