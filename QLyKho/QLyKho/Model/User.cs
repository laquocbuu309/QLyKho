//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLyKho.Model
{
    using QLyKho.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class User : BaseViewModel
    {
        private int _Id;
        public int Id { get => _Id; set { _Id = value; OnPropertyChanged(); } }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _PassWord;
        public string PassWord { get => _PassWord; set { _PassWord = value; OnPropertyChanged(); } }
        private int _IdRole;
        public int IdRole { get => _IdRole; set { _IdRole = value; OnPropertyChanged(); } }

        private UserRole _UserRole;
        public virtual UserRole UserRole { get => _UserRole; set { _UserRole = value; OnPropertyChanged(); } }
    }
}
