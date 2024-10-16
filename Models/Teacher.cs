namespace YourNamespace.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        // Navigation property
        public List<Course> Courses { get; set; }
    }
}
