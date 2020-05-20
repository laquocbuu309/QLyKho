using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLyKho.ViewModel
{
    class AnnounceVM : BaseViewModel
    {
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public ICommand YesCommand { get; set; }
        public ICommand NoCommand { get; set; }
        public AnnounceVM()
        {
            bool btnYes = false, btnNo = false;
            YesCommand = new RelayCommand<object>((c) => true, (c) =>
            {
                btnYes = true;
            });
            NoCommand = new RelayCommand<object>((c) => true, (c) =>
            {
                btnNo = true;
            });
        }
    }
}
