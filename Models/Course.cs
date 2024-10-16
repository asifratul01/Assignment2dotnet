using System.Collections.Generic;

namespace YourNamespace.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        
        // Navigation properties
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
