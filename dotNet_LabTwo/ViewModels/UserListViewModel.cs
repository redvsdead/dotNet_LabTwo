using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using dotNet_LabTwo.Models;
using System.Windows.Input;
using System.Windows.Data;

namespace dotNet_LabTwo.ViewModels
{
    public class UserListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<UserViewModel> UserList { get; set; }
        public ICollectionView UsersView
        {
            get;
            set;
        }
        private UserViewModel selectedUser;
        public bool isGrouped = false;
        public bool IsGrouped
        {
            get { return isGrouped; }
            set
            {
                isGrouped = value;
                GroupUnGroup();
                OnPropertyChanged("IsGroupped");
            }
        }
        public ICommand removeCommand { get; set; }
        public UserViewModel SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        private void GroupUnGroup()
        {
            UsersView.GroupDescriptions.Clear();
            if (IsGrouped)
                UsersView.GroupDescriptions.Add(new PropertyGroupDescription("Group"));
        }

        public void RemoveUser(object user)
        {

            UserList.Remove(user as UserViewModel);
            SelectedUser = UserList.FirstOrDefault();
        }

        public bool CanExecuteRemoveUser(object student)
        {
            return student != null && student is UserViewModel;
        }

        public UserListViewModel()
        {
            UserList = Initializer.Init();
            UsersView = Initializer.initView(UserList);
            removeCommand = new RelayCommand(RemoveUser, CanExecuteRemoveUser);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}