namespace Main
{
  using System;
  using System.Collections.ObjectModel;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;

  public class PersonViewModel : INotifyPropertyChanged
  {
    public ObservableCollection<PersonModel> PersonItems { get; }
    private readonly DataRepository dataRepository;
    
    private PersonModel selectedPersonItem; 
    public PersonModel SelectedPersonItem
    {
      get => this.selectedPersonItem;
      set 
      { 
        this.selectedPersonItem = value;
        OnPropertyChanegd();
      }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public PersonViewModel()
    {
      this.PersonItems = new ObservableCollection<PersonModel>();
      this.dataRepository = new DataRepository();
    }

    public void Initialize()
    {
      IEnumerable<PersonModel> personItems = this.dataRepository.GetPersonModels();
      this.PersonItems.Clear();
      foreach (PersonModel personItem in personItems)
      {
        this.PersonItems.Add(personItem);
      }
    }

    protected virtual void OnPropertyChanegd([CallerMemberName] string propertyName = null)
      => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}