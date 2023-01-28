using System.ComponentModel.DataAnnotations;

namespace OpenTashkent.Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
