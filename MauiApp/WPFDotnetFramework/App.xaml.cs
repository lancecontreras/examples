using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Abstraction;
using Microsoft.Extensions.DependencyInjection;
using ViewModels;

namespace WPFDotnetFramework
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private readonly ServiceCollection _serviceCollection = new ServiceCollection();

    public App()
    {
      _serviceCollection.AddTransient<MainPageViewModel>();
      _serviceCollection.AddSingleton<IDialogService, DialogService>();
      this.ServiceProvider = _serviceCollection.BuildServiceProvider();
    }

    public ServiceProvider ServiceProvider { get; set; }
  }
}
