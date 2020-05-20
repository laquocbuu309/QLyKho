using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLyKho.ViewModel
{
    public class ControlBarVM : BaseViewModel
    {
        #region
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MouseMoveWindowCommand { get; set; }
        #endregion
        public ControlBarVM()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => { Window window = GetWindowParent(p);
                if (window != null)
                {
                    if( window.Name == "loginWindow" || window.Name == "mainWindow")
                    {
                        AnnounceWindow tb = new AnnounceWindow("Bạn có muốn thoát không?", "CauHoi");
                        tb.ShowDialog();
                        if (tb.Yes == true)
                        {
                            window.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else window.Close();
                }                    
            }
            );

            MaximizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                Window window = GetWindowParent(p);
                if (window != null)
                {
                    if (window.WindowState != WindowState.Maximized)
                    {
                        window.WindowState = WindowState.Maximized;
                    }    
                    else
                    {
                        window.WindowState = WindowState.Normal;
                    }    
                        
                }
            }
            );

            MinimizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                Window window = GetWindowParent(p);
                if (window != null)
                {
                    window.WindowState = WindowState.Minimized;
                }
            }
            );
            MouseMoveWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                Window window = GetWindowParent(p);
                if (window != null)
                {
                    window.DragMove();
                }
            }
           );

        }
        Window GetWindowParent(UserControl p)
        {
            Window parent = null;
            parent = Window.GetWindow(p);
            return parent;
        }
    }
}
