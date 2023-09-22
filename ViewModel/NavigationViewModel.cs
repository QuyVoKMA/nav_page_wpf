using PageNavigation.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageNavigation.ViewModel
{
    class NavigationViewModel : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand {  get; set; }
        public ICommand CustomersCommand { get; set;}
        public ICommand ProductsCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand TransactionsCommad {  get; set; }
        public ICommand ShipmentsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel();
        private void Customer(object obj) => CurrentView = new CustomerViewModel();
        private void Product(object obj) => CurrentView = new ProductViewModel();
        private void Order(object obj) => CurrentView = new OrderViewModel();
        private void Transaction(object obj) => CurrentView = new TransationsViewModel();
        private void Shipment(object obj) => CurrentView = new ShippingViewMode();
        private void Setting(object obj) => CurrentView = new SettingsViewModel();

        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            ProductsCommand = new RelayCommand(Product);
            OrdersCommand = new RelayCommand(Order);
            TransactionsCommad = new RelayCommand(Transaction);
            ShipmentsCommand = new RelayCommand(Shipment);
            SettingsCommand = new RelayCommand(Setting);
            
            // Startup Page
            CurrentView = new NavigationViewModel();
        }
    }
}
