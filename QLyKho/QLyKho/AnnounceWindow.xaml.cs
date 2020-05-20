using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QLyKho
{
    /// <summary>
    /// Interaction logic for AnnounceWindow.xaml
    /// </summary>
    public partial class AnnounceWindow : Window
    {
        public bool Yes = false;
        public AnnounceWindow(string content, string icon)
        {
            InitializeComponent();
            string duongdan = System.AppDomain.CurrentDomain.BaseDirectory;
            if (icon == "ThanhCong")
            {
                btnYes.Visibility = Visibility.Collapsed;
                btnNo.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image\\" + "CheckTC.png";
            }
            else if (icon == "CauHoi")
            {
                btnOk.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image\\" + "CauHoi.png";
            }
            else if (icon == "CanhBao")
            {
                btnYes.Visibility = Visibility.Collapsed;
                btnNo.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image\\" + "CanhBao.png";
            }
            Image.Source = new BitmapImage(new Uri(duongdan));
            lbContent.Content = content;
        }
        public AnnounceWindow()
        {
            InitializeComponent();
        }
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            Yes = true;
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
