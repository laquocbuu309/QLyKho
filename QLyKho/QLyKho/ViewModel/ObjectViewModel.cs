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
    public class ObjectViewModel : BaseViewModel
    {
        #region
        private ObservableCollection<Object> _List;
        public ObservableCollection<Object> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<Unit> _Unit;
        public ObservableCollection<Unit> Unit { get => _Unit; set { _Unit = value; OnPropertyChanged(); } }

        private ObservableCollection<Suplier> _Suplier;
        public ObservableCollection<Suplier> Suplier { get => _Suplier; set { _Suplier = value; OnPropertyChanged(); } }

        private Object _SelectedItem;
        public Object SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.DisplayName;
                    QRCode = SelectedItem.QRCode;
                    BarCode = SelectedItem.BarCode;
                    SelectedUnit = SelectedItem.Unit;
                    SelectedSuplier = SelectedItem.Suplier;
                }
            }
        }

        private Unit _SelectedUnit;
        public Unit SelectedUnit
        {
            get => _SelectedUnit;
            set
            {
                _SelectedUnit = value;
                OnPropertyChanged();
                
            }
        }

        private Suplier _SelectedSuplier;
        public Suplier SelectedSuplier
        {
            get => _SelectedSuplier;
            set
            {
                _SelectedSuplier = value;
                OnPropertyChanged();
                
            }
        }


        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _QRCode;
        public string QRCode { get => _QRCode; set { _QRCode = value; OnPropertyChanged(); } }

        private string _BarCode;
        public string BarCode { get => _BarCode; set { _BarCode = value; OnPropertyChanged(); } }



        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        #endregion
        public ObjectViewModel()
        {
            List = new ObservableCollection<Object>(DataProvider.Ins.db.Objects);
            Unit = new ObservableCollection<Unit>(DataProvider.Ins.db.Units);
            Suplier = new ObservableCollection<Suplier>(DataProvider.Ins.db.Supliers);
            
            AddCommand = new RelayCommand<Object>((p) => {

                if (SelectedSuplier == null || SelectedUnit == null)
                {
                    return false;
                }

                return true;
            },
            (p) =>
            {
                var objects = new Object() { DisplayName = DisplayName , QRCode = QRCode, BarCode = BarCode, IdSuplier = SelectedSuplier.Id, IdUnit = SelectedUnit.Id, Id = Guid.NewGuid().ToString()};

                DataProvider.Ins.db.Objects.Add(objects);
                DataProvider.Ins.db.SaveChanges();
                List.Add(objects);
            }
            );
            
            EditCommand = new RelayCommand<Suplier>((p) =>
            {
                if (SelectedItem == null || SelectedSuplier == null || SelectedUnit == null)
                {
                    return false;
                }

                return true;

            },
            (p) =>
            {
                var objects = DataProvider.Ins.db.Objects.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                objects.DisplayName = DisplayName;
                objects.QRCode = QRCode;
                objects.BarCode = BarCode;
                objects.IdSuplier = SelectedSuplier.Id;
                objects.IdUnit = SelectedUnit.Id;
                DataProvider.Ins.db.SaveChanges();
                SelectedItem = objects;

            }
            );
            
        }
    }
}
