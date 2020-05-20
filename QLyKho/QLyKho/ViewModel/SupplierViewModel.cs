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
    public class SupplierViewModel : BaseViewModel
    {
        #region
        private ObservableCollection<Suplier> _List;
        public ObservableCollection<Suplier> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private Suplier _SelectedItem;
        public Suplier SelectedItem
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
        public SupplierViewModel()
        {
            List = new ObservableCollection<Suplier>(DataProvider.Ins.db.Supliers);
           
            AddCommand = new RelayCommand<Suplier>((p) =>{return true;},
            (p) =>
            {
                var supplier = new Suplier() { DisplayName = DisplayName, Address = Address, Phone = Phone, Email = Email, MoreInfo = MoreInfo, ContractDate = ContractDate};

                DataProvider.Ins.db.Supliers.Add(supplier);
                DataProvider.Ins.db.SaveChanges();
                List.Add(supplier);
            }
            );
            
            EditCommand = new RelayCommand<Suplier>((p) =>
            {
                if (SelectedItem == null)
                {
                    return false;
                }

                return true;

            },
            (p) =>
            {
                var suplier = DataProvider.Ins.db.Supliers.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                suplier.DisplayName = DisplayName;
                suplier.Address = Address;
                suplier.Phone = Phone;
                suplier.Email = Email;
                suplier.MoreInfo = MoreInfo;
                suplier.ContractDate = ContractDate;
                DataProvider.Ins.db.SaveChanges();
                SelectedItem = suplier;

            }
            );
            
        }
    }
}
