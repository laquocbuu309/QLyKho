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
        private ObservableCollection<Object> _ObjectList;
        public ObservableCollection<Object> ObjectList { get => _ObjectList; set { _ObjectList = value; OnPropertyChanged(); } }

        private ObservableCollection<Input> _InputList;
        public ObservableCollection<Input> InputList { get => _InputList; set { _InputList = value; OnPropertyChanged(); } }

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
                if (SelectedInput != null)
                {
                    DateInput = SelectedInput.DateInput;
                }
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

        private Nullable<System.DateTime> _DateInput;
        public Nullable<System.DateTime> DateInput { get => _DateInput; set { _DateInput = value; OnPropertyChanged(); } }

        private string _Status;
        public string Status { get => _Status; set { _Status = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        #endregion
        public InputViewModel()
        {
            List = new ObservableCollection<InputInfo>(DataProvider.Ins.db.InputInfoes);
            ObjectList = new ObservableCollection<Object>(DataProvider.Ins.db.Objects);
            InputList = new ObservableCollection<Input>(DataProvider.Ins.db.Inputs);

            
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
                var input = new Input() { Id = idInput, DateInput = DateInput };
                DataProvider.Ins.db.Inputs.Add(input);
                DataProvider.Ins.db.SaveChanges();
                InputList.Add(input);

                var InputInfo = new InputInfo() {Id = Guid.NewGuid().ToString(), IdObject = SelectedObject.Id, IdInput = idInput, Count = Count, InputPrice = InputPrice, Status = Status};
                DataProvider.Ins.db.InputInfoes.Add(InputInfo);
                DataProvider.Ins.db.SaveChanges();
                List.Add(InputInfo);
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
                var inputInfo = DataProvider.Ins.db.InputInfoes.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();

                inputInfo.IdObject = SelectedObject.Id;
                var object1 = DataProvider.Ins.db.Objects.Where(x => x.Id == SelectedObject.Id).SingleOrDefault();
                inputInfo.Object = object1;

                inputInfo.IdInput = SelectedInput.Id;
                var input = DataProvider.Ins.db.Inputs.Where(x => x.Id == inputInfo.IdInput).SingleOrDefault();
                input.DateInput = DateInput;
                inputInfo.Input = input;
                inputInfo.Count = Count;
                inputInfo.InputPrice = InputPrice;
                inputInfo.OutputPrice = OutputPrice;
                inputInfo.Status = Status;
                DataProvider.Ins.db.SaveChanges();
                SelectedItem = inputInfo;

            }
            );
        }
    }
}
