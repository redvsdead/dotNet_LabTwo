using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNet_LabTwo.Models;

namespace dotNet_LabTwo.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private readonly User user;

        public ObservableCollection<DiseaseViewModel> Diseases { get; set; }

        public UserViewModel(User _user)
        {
            user = _user;
            InitializeDiseases();
        }

        public string Name
        {
            get
            {
                return user.Name;
            }
            set
            {
                user.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get
            {
                return user.Surname;
            }
            set
            {
                user.Surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public int Group
        {
            get
            {
                return user.Group;
            }
            set
            {
                user.Group = value;
                OnPropertyChanged("Group");
            }
        }

        public int DiseaseCount
        {
            get
            {
                return user.Diseases.Select(d => d.Id).Count();
            }
        }

        public string FullName
        {
            get
            {
                return user.Surname + " " + user.Name;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged; 
        private void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private void InitializeDiseases()
        {
            Diseases = new ObservableCollection<DiseaseViewModel>();
            user.Diseases.ForEach(d => Diseases.Add(new DiseaseViewModel(d)));
        }
    }
}
