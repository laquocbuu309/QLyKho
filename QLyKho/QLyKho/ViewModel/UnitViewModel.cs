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
    public class UnitViewModel : BaseViewModel
    {
        #region
        private ObservableCollection<Unit> _List;
        public ObservableCollection<Unit> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private Unit _SelectedItem;
        public Unit SelectedItem { get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.DisplayName;
                }
            } }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        #endregion
        public UnitViewModel()
        {
            List = new ObservableCollection<Unit>(DataProvider.Ins.db.Units);

            AddCommand = new RelayCommand<Unit>((p) => 
            {
                if (string.IsNullOrEmpty(DisplayName))
                {
                    return false;
                }

                var displayList = DataProvider.Ins.db.Units.Where(x => x.DisplayName == DisplayName);
                if(displayList == null || displayList.Count() > 0)
                {
                    return false;
                }
                return true;

            }, 
            (p) =>
            {
                var unit = new Unit() { DisplayName = DisplayName };
                
                DataProvider.Ins.db.Units.Add(unit);
                DataProvider.Ins.db.SaveChanges();
                List.Add(unit);
            }
            );

            EditCommand = new RelayCommand<Unit>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || SelectedItem == null)
                {
                    return false;
                }

                var displayList = DataProvider.Ins.db.Units.Where(x => x.DisplayName == DisplayName);
                if (displayList == null || displayList.Count() > 0)
                {
                    return false;
                }
                return true;

            },
            (p) =>
            {
                var unit = DataProvider.Ins.db.Units.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                unit.DisplayName = DisplayName;
                DataProvider.Ins.db.SaveChanges();
                SelectedItem.DisplayName = DisplayName;

            }
            );
        }
    }
}
