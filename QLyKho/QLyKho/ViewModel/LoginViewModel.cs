using QLyKho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLyKho.ViewModel
{
    class LoginViewModel : BaseViewModel
    {

        public bool IsLogin { get; set; }
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value;OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public ICommand LoginCommand { get; set; }
        public ICommand ExitCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        public LoginViewModel()
        {
            IsLogin = false;
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                login(p);
            }
            );

            ExitCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                IsLogin = false;
                p.Close();
            }
            );

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Password = p.Password;
            }
            );
        }

        void login(Window p)
        {
            if (p == null)
                return;

            string passEncode = MD5Hash(Base64Encode(Password));

            // Check Database to login
            var accCount = DataProvider.Ins.db.Users.Where(x => x.UserName == UserName && x.PassWord == passEncode).Count() ;
            if (accCount>0)
            {
                IsLogin = true;
                p.Close();
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu.");
            }
        }

        //Encode string to base64 
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        /* Decode string to base64
         public static string Base64Decode(string base64EncodedData) {
         var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
         return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
         }
         */

        //Encode string to md5
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
