using ViewModels;

namespace MauiDotNet8
{
  public partial class MainPage : ContentPage
  {
    int count = 0;

    public MainPage(MainPageViewModel viewModel)
    {
      InitializeComponent();
      this.BindingContext = viewModel; 
    }
  }

}
