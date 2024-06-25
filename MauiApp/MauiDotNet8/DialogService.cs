using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDotNet8
{
  public class DialogService : IDialogService
  {
    public async Task ShowDialogAsync(string message)
    {
      Task? displayTask = App.Current?.MainPage?.DisplayAlert("Maui Application", message, "OK");
      if (displayTask != null)
      {
        await displayTask; 
      }
    }
  }
}
