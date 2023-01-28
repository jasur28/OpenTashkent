using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OpenTashkent.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public DateTime AcessibleTime { get; set; }
        public string TelephoneNumber { get; set; }
        public IEnumerable<Subject> SubjectsInterestedIn { get; set; }
        public IEnumerable<Disease> Diseases { get; set; }
        public string ResponsiblePerson { get; set; }
        public IEnumerable<Subject> SubjectsCanTeach { get; set; }
    }
}
