using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcademicSupportStudyPlanner.Models
{
    public class DashboardSummary
    {
        public int TotalSubjects { get; set; }

        public int TotalAssignments { get; set; }

        public int PendingAssignments { get; set; }

        public int TotalStudySessions { get; set; }
    }
}
