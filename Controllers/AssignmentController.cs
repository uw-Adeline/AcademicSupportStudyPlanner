
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AcademicSupportStudyPlanner.Data;
using AcademicSupportStudyPlanner.Models;

namespace AcademicSupportStudyPlanner.Controllers
{
    public class AssignmentController
    {
        // CREATE: Add a new assignment
        public bool AddAssignment(Assignment assignment, int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Assignments
                    (SubjectID, Title, Description, DueDate, Status)
                    SELECT SubjectID, @Title, @Description, @DueDate, @Status
                    FROM Subjects
                    WHERE SubjectID = @SubjectID
                    AND StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SubjectID", assignment.SubjectID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    command.Parameters.AddWithValue(
                        "@Title", assignment.Title);

                    command.Parameters.AddWithValue(
                        "@Description",
                        (object)assignment.Description ?? DBNull.Value);

                    command.Parameters.AddWithValue(
                        "@DueDate", assignment.DueDate.Date);

                    command.Parameters.AddWithValue(
                        "@Status", assignment.Status ?? "Pending");

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // READ: Retrieve all assignments belonging to a student
        public List<Assignment> GetAssignments(int studentID)
        {
            List<Assignment> assignments = new List<Assignment>();

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT A.*
                    FROM Assignments A
                    INNER JOIN Subjects S
                    ON A.SubjectID = S.SubjectID
                    WHERE S.StudentID = @StudentID
                    ORDER BY A.DueDate ASC";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    connection.Open();

                    using (MySqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Assignment assignment = new Assignment();

                            assignment.AssignmentID =
                                Convert.ToInt32(reader["AssignmentID"]);

                            assignment.SubjectID =
                                Convert.ToInt32(reader["SubjectID"]);

                            assignment.Title =
                                Convert.ToString(reader["Title"]) ?? "";

                            assignment.Description =
                                reader["Description"] == DBNull.Value
                                ? ""
                                : Convert.ToString(reader["Description"]) ?? "";

                            assignment.DueDate =
                                Convert.ToDateTime(reader["DueDate"]);

                            assignment.Status =
                                Convert.ToString(reader["Status"]) ?? "Pending";

                            assignment.CreatedAt =
                                Convert.ToDateTime(reader["CreatedAt"]);

                            assignments.Add(assignment);
                        }
                    }
                }
            }

            return assignments;
        }

        // UPDATE: Modify an existing assignment
        public bool UpdateAssignment(
            Assignment assignment, int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    UPDATE Assignments A
                    INNER JOIN Subjects S
                    ON A.SubjectID = S.SubjectID
                    SET A.Title = @Title,
                        A.Description = @Description,
                        A.DueDate = @DueDate,
                        A.Status = @Status
                    WHERE A.AssignmentID = @AssignmentID
                    AND S.StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@AssignmentID", assignment.AssignmentID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    command.Parameters.AddWithValue(
                        "@Title", assignment.Title);

                    command.Parameters.AddWithValue(
                        "@Description",
                        (object)assignment.Description ?? DBNull.Value);

                    command.Parameters.AddWithValue(
                        "@DueDate", assignment.DueDate.Date);

                    command.Parameters.AddWithValue(
                        "@Status", assignment.Status ?? "Pending");

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE: Remove an assignment
        public bool DeleteAssignment(
            int assignmentID, int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    DELETE A
                    FROM Assignments A
                    INNER JOIN Subjects S
                    ON A.SubjectID = S.SubjectID
                    WHERE A.AssignmentID = @AssignmentID
                    AND S.StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@AssignmentID", assignmentID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

