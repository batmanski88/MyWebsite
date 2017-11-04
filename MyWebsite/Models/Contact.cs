using System.ComponentModel.DataAnnotations;

namespace MyWebsite.Models
{
    public class Contact
    {
        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Pole Email jest wymagane.")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email.")]
        public string FromEmail {get; set;}
        [Display(Name = "Temat: ")]
        [Required(ErrorMessage = "Pole Temat jest wymagane.")]
        public string Subject {get; set;}
        [Display(Name = "Treśc: ")]
        [Required(ErrorMessage = "Pole Treśc jest wymagane.")]
        public string Text {get; set;}

        public Contact()
        {
            
        }
    }
}