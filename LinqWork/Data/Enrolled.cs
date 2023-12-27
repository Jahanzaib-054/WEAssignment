using System.ComponentModel.DataAnnotations;

namespace LinqWork.Data
{
    public class Enrolled
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Class Class { get; set; }
    }
}
