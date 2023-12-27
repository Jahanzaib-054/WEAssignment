using System.ComponentModel.DataAnnotations;

namespace LinqWork.Data
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? RoomNumber { get; set; }
        public int FacultyId { get; set; }

        // Navigation property
        public Faculty Faculty { get; set; }
        public List<Enrolled> Enrolled { get; set; }
    }
}
