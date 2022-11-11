using System.ComponentModel.DataAnnotations;

namespace MVCBasics.ViewModels
{
    public class PersonViewModel
    {
        
        //public string Id { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Enter your name:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Enter your Phone number:")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Enter your city:")]
        public string City { get; set; }
    }
}
