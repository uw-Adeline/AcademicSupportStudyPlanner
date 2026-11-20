
using System;

namespace AcademicSupportStudyPlanner.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
