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
    public class DiseaseViewModel
    {
        private readonly Disease disease;

        public string Type
        {
            get
            {
                return disease.Type;
            }
            set
            {
                disease.Type = value;
                OnPropertyChanged("Type");
            }
        }

        public DiseaseViewModel(Disease disease)
        {
            this.disease = disease;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

