using System.ComponentModel.DataAnnotations;

namespace OpenTashkent.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string UserName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Adress { get; set; }
        public DateTime? AcessibleTime { get; set; }
        public string? TelephoneNumber { get; set; }
        public IEnumerable<Subject>? SubjectsCanTeach { get; set; }
    }
}
