
using System;

namespace AcademicSupportStudyPlanner.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public int StudentID { get; set; }

        public string SubjectName { get; set; }

        public string SubjectCode { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

