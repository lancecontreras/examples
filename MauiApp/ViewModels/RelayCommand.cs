using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Input;

namespace ViewModels
{
  public class RelayCommand : ICommand
  {
    public event EventHandler CanExecuteChanged;

    Action _action;
    Func<bool> _canExecute; 
    public RelayCommand(Action action, Func<bool> canExecute)
    {
      _action = action; 
      _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
      return _canExecute(); 
    }

    public void Execute(object parameter)
    {
      _action();
    }

    public void RaiseCanExecuteChanged() { CanExecuteChanged(this, null); }
  }
}
