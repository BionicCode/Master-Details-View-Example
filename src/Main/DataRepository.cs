namespace Main
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class DataRepository
  {
    public IEnumerable<PersonModel> GetPersonModels()
    {
      // TODO::Replace with your database access (or Model accesss)

      int personCount = 20;
      var persons = new List<PersonModel>();
      for (int index = 0; index < personCount; index++)
      {
        var randomAgeGenerator = new Random();
        var newPerson = new PersonModel()
        {
          Name = $"Person #{index + 1}",
          Surname = (index * 100).ToString(),
          PersonAge = randomAgeGenerator.Next(18, 100),
          PersonID = index + 1,
        };

        persons.Add(newPerson);
      }

      return persons;
    }
  }
}
