using System.ComponentModel.DataAnnotations;

namespace StudentInfoApp.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Student Name is required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Semester is required")]
        public string Semester { get; set; }
    }
}
