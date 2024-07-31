namespace Main
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;
  using System.Text;
  using System.Threading.Tasks;

  public class MainViewModel : INotifyPropertyChanged
  {
    public PersonViewModel PersonViewModel { get; }

    public MainViewModel()
    {
      this.PersonViewModel = new PersonViewModel();
    }

    public void Initialize()
    {
      this.PersonViewModel.Initialize();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanegd([CallerMemberName] string propertyName = null)
      => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}
