using System.ComponentModel.DataAnnotations;

namespace MVCBasics.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public Person()
        {

        }

        public Person(string id, string name, string phoneNumber, string city)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            City = city;
        }
    }
}
