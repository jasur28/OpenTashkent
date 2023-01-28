namespace OpenTashkent.Models.ViewModels
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Disease>? Diseases { get; set; }

    }
}
