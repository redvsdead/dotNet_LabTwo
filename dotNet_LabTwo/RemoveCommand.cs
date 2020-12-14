using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using dotNet_LabTwo.ViewModels;

namespace dotNet_LabTwo
{
    public class RemoveCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return parameter != null && parameter is UserViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        { }
    }
}
