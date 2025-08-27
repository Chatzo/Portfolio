using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class ContactFormModel
    {
        [Required, EmailAddress] public string Email { get; set; }
        [Required] public string Message { get; set; }
    }
}
