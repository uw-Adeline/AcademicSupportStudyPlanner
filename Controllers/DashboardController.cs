
using System;
using MySql.Data.MySqlClient;
using AcademicSupportStudyPlanner.Data;
using AcademicSupportStudyPlanner.Models;

namespace AcademicSupportStudyPlanner.Controllers
{
    public class DashboardController
    {
        public DashboardSummary GetDashboardSummary(int studentID)
        {
            DashboardSummary summary = new DashboardSummary();

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT
                    (
                        SELECT COUNT(*)
                        FROM Subjects
                        WHERE StudentID = @StudentID
                    ) AS TotalSubjects,

                    (
                        SELECT COUNT(*)
                        FROM Assignments A
                        INNER JOIN Subjects S
                        ON A.SubjectID = S.SubjectID
                        WHERE S.StudentID = @StudentID
                    ) AS TotalAssignments,

                    (
                        SELECT COUNT(*)
                        FROM Assignments A
                        INNER JOIN Subjects S
                        ON A.SubjectID = S.SubjectID
                        WHERE S.StudentID = @StudentID
                        AND A.Status = 'Pending'
                    ) AS PendingAssignments,

                    (
                        SELECT COUNT(*)
                        FROM StudySessions SS
                        INNER JOIN Subjects S
                        ON SS.SubjectID = S.SubjectID
                        WHERE S.StudentID = @StudentID
                    ) AS TotalStudySessions";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    connection.Open();

                    using (MySqlDataReader reader =
                           command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            summary.TotalSubjects =
                                Convert.ToInt32(reader["TotalSubjects"]);

                            summary.TotalAssignments =
                                Convert.ToInt32(reader["TotalAssignments"]);

                            summary.PendingAssignments =
                                Convert.ToInt32(reader["PendingAssignments"]);

                            summary.TotalStudySessions =
                                Convert.ToInt32(reader["TotalStudySessions"]);
                        }
                    }
                }
            }

            return summary;
        }
    }
}
