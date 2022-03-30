using System.ComponentModel.DataAnnotations;

namespace GDLibrary.Api.Domain.Services.RequestABook
{
    public class RequestABookCommand
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email address is invalid.")]
        public string Email { get; set; }
        
        [Required]
        public string Title { get; set; }
    }
}
