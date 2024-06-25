using System;
using System.Threading.Tasks;

namespace Abstraction
{
  public interface IDialogService
  {
    Task ShowDialogAsync(string message);
  }
}
