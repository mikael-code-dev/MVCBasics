using MVCBasics.Models;

namespace MVCBasics.ViewModels
{
    public class PeopleViewModel
    {
        public static List<Person> listOfPeople { get; set; } = new List<Person>();
        public List<Person> tempList { get; set; } = new List<Person>();
        public PersonViewModel CreatePerson { get; set; } = new();



        public static void SeedPeople()
        {
            listOfPeople.Add(new Person(Guid.NewGuid().ToString(), "Smith", "112", "London"));
            listOfPeople.Add(new Person(Guid.NewGuid().ToString(), "Jean-Luc", "113", "Paris"));
            listOfPeople.Add(new Person(Guid.NewGuid().ToString(), "Orvar", "114", "Oslo"));
            listOfPeople.Add(new Person(Guid.NewGuid().ToString(), "Pecka", "115", "Helsinki"));
        }
    }
}
