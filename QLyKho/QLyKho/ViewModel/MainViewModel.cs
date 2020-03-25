using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool isLoaded = false;
        public MainViewModel()
        {
            if (!isLoaded)
            {
                isLoaded = true;
                LoginWindows login = new LoginWindows();
                login.ShowDialog();

            }
            
        }
    }
}
