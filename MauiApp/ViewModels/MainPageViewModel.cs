using Abstraction;
using System;
using System.Windows.Input;

namespace ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    IDialogService _dialogService;

    public MainPageViewModel(IDialogService dialogService)
    {
      _dialogService = dialogService;
      ShowMessageCommand = new RelayCommand(ShowMessageDelegate, CanShowMessage);
    }

    private bool CanShowMessage()
    {
      return !string.IsNullOrEmpty(Message);
    }

    private async void ShowMessageDelegate()
    {
      await _dialogService.ShowDialogAsync(this.Message);
      Message = string.Empty; 
    }

    private string _Title = "Main Page";
    public string Title
    {
      get { return _Title; }
      set { SetProperty(ref _Title, value); }
    }

    private string _Message;
    public string Message
    {
      get { return _Message; }
      set {
        if (SetProperty(ref _Message, value))
        {
          ShowMessageCommand.RaiseCanExecuteChanged();
        }
      }
    }

    public RelayCommand ShowMessageCommand { get; set; }
  
  }
}
