using System.Collections.Generic;

namespace YourNamespace.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public Course Course { get; set; }
    }
}
