using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDotnetFramework
{
  public class DialogService : IDialogService
  {
    public async Task ShowDialogAsync(string message)
    {
      await Task.Run(() => MessageBox.Show(message)); 
    }
  }
}
