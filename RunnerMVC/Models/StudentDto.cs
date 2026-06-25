namespace RunnerMVC.Models
{
    public class StudentDto
    {
        public string? Name { get; set; }
        public string? MiddleName { get; set; }
        public string? NSS { get; set; }
        public int Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
