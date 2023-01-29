using System.ComponentModel.DataAnnotations;

namespace OpenTashkent.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Adress { get; set; }
        public DayOfWeek AcessibleDay { get; set; }
        public DateTimeOffset AcessibleTime { get; set; }
        public string? TelephoneNumber { get; set; }
        public IEnumerable<Subject>? SubjectsInterestedIn { get; set; }
        public IEnumerable<Disease>? Diseases { get; set; }
        public string? ResponsiblePerson { get; set; }
    }
}
