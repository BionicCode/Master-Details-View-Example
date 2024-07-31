namespace Main
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;
  using System.Text;
  using System.Threading.Tasks;

  public class PersonModel : INotifyPropertyChanged
  {
    public int PersonID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int PersonAge { get; set; }
    public string PersonAddress { get; set; }
    public string PersonDepartmentID { get; set; }
    public string PersonGroupID { get; set; }
    public string PersonContact { get; set; }
    public string PersonLevelEductationID { get; set; }
    public string PersonDivisionID { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanegd([CallerMemberName] string propertyName = null)
      => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}
