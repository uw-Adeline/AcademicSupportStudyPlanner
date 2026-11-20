
using System;

namespace AcademicSupportStudyPlanner.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; }

        public int SubjectID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

