using QLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<TonKho> _TonKhoList;
        public ObservableCollection<TonKho> TonKhoList { get => _TonKhoList; set { _TonKhoList = value;OnPropertyChanged(); } }
        public bool isLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitCommand { get; set; }
        public ICommand SupplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand ObjectCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                isLoaded = true;
                if (p == null) return;
                p.Hide();
                LoginWindows loginWindow = new LoginWindows();
                loginWindow.ShowDialog();
                if (loginWindow.DataContext == null) return;

                var loginVM = loginWindow.DataContext as LoginViewModel;
                if (loginVM.IsLogin)
                {
                    p.Show();

                    LoadTonKhoData();
                }
                else
                {
                    p.Close();
                }
                
            }
            );

            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                UnitWindow wd = new UnitWindow();
                wd.ShowDialog();
            }
            );

            SupplierCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SupplierWindow wd = new SupplierWindow();
                wd.ShowDialog();
            }
            );

            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                CustomerWindow wd = new CustomerWindow();
                wd.ShowDialog();
            }
            );

            ObjectCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ObjectWindow wd = new ObjectWindow();
                wd.ShowDialog();
            }
            );

            UserCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                UserWindow wd = new UserWindow();
                wd.ShowDialog();
            }
            );

            InputCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                InputWindow wd = new InputWindow();
                wd.ShowDialog();
                LoadTonKhoData();
            }
           );

            OutputCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OutputWindow wd = new OutputWindow();
                wd.ShowDialog();
            }
           );
        }

        private void LoadTonKhoData()
        {
            TonKhoList = new ObservableCollection<TonKho>();
            var objectList = DataProvider.Ins.db.Objects;
            int i = 1;
            foreach (var item in objectList)
            {
                var inputList = DataProvider.Ins.db.InputInfoes.Where(p => p.IdObject == item.Id);
                var outputList = DataProvider.Ins.db.OutputInfoes.Where(p => p.IdObject == item.Id);

                var unit = DataProvider.Ins.db.Units.Where(p => p.Id == item.IdUnit).First();

                int sumInput = 0;
                int sumOutput = 0;

                if (inputList != null && inputList.Count() >0)
                    sumInput = (int)inputList.Sum(p => p.Count);
                if (outputList!=null && outputList.Count() >0)
                {
                    sumOutput = (int)outputList.Sum(p => p.Count);
                }
                int tonkhoCount = sumInput - sumOutput;
                if (tonkhoCount <= 0)
                    continue;

                TonKho tonkho = new TonKho();
                tonkho.STT = i;
                tonkho.Object = item;
                tonkho.Count = tonkhoCount;
                tonkho.Unit = unit;
                TonKhoList.Add(tonkho);
                i++;
                                               
            }
        }
    }
}
