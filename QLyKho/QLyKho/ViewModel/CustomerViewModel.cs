using QLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLyKho.ViewModel
{
    public class CustomerViewModel : BaseViewModel
    {
        #region
        private ObservableCollection<Customer> _List;
        public ObservableCollection<Customer> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private Customer _SelectedItem;
        public Customer SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.DisplayName;
                    Address = SelectedItem.Address;
                    Phone = SelectedItem.Phone;
                    Email = SelectedItem.Email;
                    MoreInfo = SelectedItem.MoreInfo;
                    ContractDate = SelectedItem.ContractDate;
                }
            }
        }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _Address;
        public string Address { get => _Address; set { _Address = value; OnPropertyChanged(); } }

        private string _Phone;
        public string Phone { get => _Phone; set { _Phone = value; OnPropertyChanged(); } }

        private string _Email;
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }

        private string _MoreInfo;
        public string MoreInfo { get => _MoreInfo; set { _MoreInfo = value; OnPropertyChanged(); } }

        private DateTime? _ContractDate;
        public DateTime? ContractDate { get => _ContractDate; set { _ContractDate = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        #endregion
        public CustomerViewModel()
        {
            List = new ObservableCollection<Customer>(DataProvider.Ins.db.Customers);

            AddCommand = new RelayCommand<Customer>((p) => { return true; },
            (p) =>
            {
                var customer = new Customer() { DisplayName = DisplayName, Address = Address, Phone = Phone, Email = Email, MoreInfo = MoreInfo, ContractDate = ContractDate };

                DataProvider.Ins.db.Customers.Add(customer);
                DataProvider.Ins.db.SaveChanges();
                List.Add(customer);
            }
            );

            EditCommand = new RelayCommand<Customer>((p) =>
            {
                if (SelectedItem == null)
                {
                    return false;
                }

                return true;

            },
            (p) =>
            {
                var customer = DataProvider.Ins.db.Customers.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                customer.DisplayName = DisplayName;
                customer.Address = Address;
                customer.Phone = Phone;
                customer.Email = Email;
                customer.MoreInfo = MoreInfo;
                customer.ContractDate = ContractDate;
                DataProvider.Ins.db.SaveChanges();
                SelectedItem = customer;

            }
            );

        }
    }
}
