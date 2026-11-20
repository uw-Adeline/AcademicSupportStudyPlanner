
using System;

namespace AcademicSupportStudyPlanner.Models
{
    public class StudySession
    {
        public int SessionID { get; set; }

        public int SubjectID { get; set; }

        public string Title { get; set; }

        public DateTime StudyDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }
    }
}

