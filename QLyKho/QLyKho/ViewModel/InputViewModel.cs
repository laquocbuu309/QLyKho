using QLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Object = QLyKho.Model.Object;

namespace QLyKho.ViewModel
{
    public class InputViewModel : BaseViewModel
    {
        #region
        private ObservableCollection<InputInfo> _List;
        public ObservableCollection<InputInfo> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private ObservableCollection<Object> _Object;
        public ObservableCollection<Object> Object { get => _Object; set { _Object = value; OnPropertyChanged(); } }

        private ObservableCollection<Input> _Input;
        public ObservableCollection<Input> Input { get => _Input; set { _Input = value; OnPropertyChanged(); } }

        private InputInfo _SelectedItem;
        public InputInfo SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedObject = SelectedItem.Object;
                    SelectedInput = SelectedItem.Input;
                    SelectedInputFix = SelectedInput;
                    Count = SelectedItem.Count;
                    InputPrice = SelectedItem.InputPrice;
                    Status = SelectedItem.Status;
                }
            }
        }

        private Object _SelectedObject;
        public Object SelectedObject
        {
            get => _SelectedObject;
            set
            {
                _SelectedObject = value;
                OnPropertyChanged();
            }
        }

        private Input _SelectedInput;
        public Input SelectedInput
        {
            get => _SelectedInput;
            set
            {
                _SelectedInput = value;
                OnPropertyChanged();
            }
        }

        private Input _SelectedInputFix;
        public Input SelectedInputFix
        {
            get => _SelectedInputFix;
            set
            {
                _SelectedInputFix = value;
                OnPropertyChanged();
            }
        }
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
        private Nullable<int> _Count;
        public Nullable<int> Count { get => _Count; set { _Count = value; OnPropertyChanged(); } }
        private Nullable<double> _InputPrice;
        public Nullable<double> InputPrice { get => _InputPrice; set { _InputPrice = value; OnPropertyChanged(); } }
        private Nullable<double> _OutputPrice;
        public Nullable<double> OutputPrice { get => _OutputPrice; set { _OutputPrice = value; OnPropertyChanged(); } }
        private string _Status;
        public string Status { get => _Status; set { _Status = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        #endregion
        public InputViewModel()
        {
            List = new ObservableCollection<InputInfo>(DataProvider.Ins.db.InputInfoes);
            Object = new ObservableCollection<Object>(DataProvider.Ins.db.Objects);
            Input = new ObservableCollection<Input>(DataProvider.Ins.db.Inputs);
            
            AddCommand = new RelayCommand<InputInfo>((p) => {
                if (SelectedObject == null && SelectedInput == null)
                {
                    return false;
                }
                return true;
            },
            (p) =>
            {
                string idInput = Guid.NewGuid().ToString();
                var input = new Input() { Id = idInput, DateInput = SelectedInput.DateInput };
                DataProvider.Ins.db.Inputs.Add(input);
                DataProvider.Ins.db.SaveChanges();
                Input.Add(input);

                var InputInfo = new InputInfo() {Id = Guid.NewGuid().ToString(), IdObject = SelectedObject.Id, IdInput = idInput, Count = Count, InputPrice = InputPrice, Status = Status};
                DataProvider.Ins.db.InputInfoes.Add(InputInfo);
                DataProvider.Ins.db.SaveChanges();
                List.Add(InputInfo);
            }
            );
            /*
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
            */
        }
    }
}
