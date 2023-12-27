using System.ComponentModel.DataAnnotations;

namespace LinqWork.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Major { get; set; }
        public string? Standing { get; set; }

        // Navigation properties
        public List<Enrolled> Enrolled { get; set; }
    }
}
