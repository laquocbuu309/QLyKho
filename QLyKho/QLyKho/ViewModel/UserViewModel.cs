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
    public class UserViewModel : BaseViewModel
    {
        #region
        private ObservableCollection<User> _List;
        public ObservableCollection<User> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<UserRole> _UserRole;
        public ObservableCollection<UserRole> UserRole { get => _UserRole; set { _UserRole = value; OnPropertyChanged(); } }


        private User _SelectedItem;
        public User SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.DisplayName;
                    UserName = SelectedItem.UserName;
                    SelectedRole = SelectedItem.UserRole;
                }
            }
        }

        private UserRole _SelectedRole;
        public UserRole SelectedRole
        {
            get => _SelectedRole;
            set
            {
                _SelectedRole = value;
                OnPropertyChanged();
            }
        }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        #endregion
        public UserViewModel()
        {
            List = new ObservableCollection<User>(DataProvider.Ins.db.Users);
            UserRole = new ObservableCollection<UserRole>(DataProvider.Ins.db.UserRoles);

            AddCommand = new RelayCommand<User>((p) => {

                if (SelectedRole == null)
                {
                    return false;
                }

                var userList = DataProvider.Ins.db.Users.Where(x => x.UserName == UserName);
                if (userList == null || userList.Count() > 0)
                {
                    return false;
                }
                return true;
            },
            (p) =>
            {
                var user = new User() { DisplayName = DisplayName, UserName = UserName, IdRole = SelectedRole.Id, PassWord = "cdd96d3cc73d1dbdaffa03cc6cd7339b" };

                DataProvider.Ins.db.Users.Add(user);
                DataProvider.Ins.db.SaveChanges();
                List.Add(user);
            }
            );
            
            EditCommand = new RelayCommand<Suplier>((p) =>
            {
                if (SelectedItem == null || SelectedRole == null)
                {
                    return false;
                }

                return true;

            },
            (p) =>
            {
                var user = DataProvider.Ins.db.Users.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
                user.DisplayName = DisplayName;
                user.UserName = UserName;
                user.IdRole = SelectedRole.Id;
                
                DataProvider.Ins.db.SaveChanges();
                SelectedItem = user;
            }
            );
            
        }
    }
}
