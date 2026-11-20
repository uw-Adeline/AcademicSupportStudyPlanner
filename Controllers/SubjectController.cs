
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AcademicSupportStudyPlanner.Data;
using AcademicSupportStudyPlanner.Models;

namespace AcademicSupportStudyPlanner.Controllers
{
    public class SubjectController
    {
        // CREATE: Add a new subject
        public bool AddSubject(Subject subject)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO Subjects
                    (StudentID, SubjectName, SubjectCode, Description)
                    VALUES
                    (@StudentID, @SubjectName, @SubjectCode, @Description)";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@StudentID", subject.StudentID);

                    command.Parameters.AddWithValue(
                        "@SubjectName", subject.SubjectName);

                    command.Parameters.AddWithValue(
                        "@SubjectCode",
                        (object)subject.SubjectCode ?? DBNull.Value);

                    command.Parameters.AddWithValue(
                        "@Description",
                        (object)subject.Description ?? DBNull.Value);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // READ: Get all subjects belonging to a student
        public List<Subject> GetSubjects(int studentID)
        {
            List<Subject> subjects = new List<Subject>();

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"SELECT * FROM Subjects
                                 WHERE StudentID = @StudentID";

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
                            Subject subject = new Subject();

                            subject.SubjectID =
                                Convert.ToInt32(reader["SubjectID"]);

                            subject.StudentID =
                                Convert.ToInt32(reader["StudentID"]);

                            subject.SubjectName =
                                Convert.ToString(reader["SubjectName"]) ?? "";

                            subject.SubjectCode =
                                reader["SubjectCode"] == DBNull.Value
                                ? ""
                                : Convert.ToString(reader["SubjectCode"]) ?? "";

                            subject.Description =
                                reader["Description"] == DBNull.Value
                                ? ""
                                : Convert.ToString(reader["Description"]) ?? "";

                            subject.CreatedAt =
                                Convert.ToDateTime(reader["CreatedAt"]);

                            subjects.Add(subject);
                        }
                    }
                }
            }

            return subjects;
        }

        // UPDATE: Modify an existing subject
        public bool UpdateSubject(Subject subject)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"UPDATE Subjects
                    SET SubjectName = @SubjectName,
                        SubjectCode = @SubjectCode,
                        Description = @Description
                    WHERE SubjectID = @SubjectID
                    AND StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SubjectID", subject.SubjectID);

                    command.Parameters.AddWithValue(
                        "@StudentID", subject.StudentID);

                    command.Parameters.AddWithValue(
                        "@SubjectName", subject.SubjectName);

                    command.Parameters.AddWithValue(
                        "@SubjectCode",
                        (object)subject.SubjectCode ?? DBNull.Value);

                    command.Parameters.AddWithValue(
                        "@Description",
                        (object)subject.Description ?? DBNull.Value);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE: Remove a subject
        public bool DeleteSubject(int subjectID, int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"DELETE FROM Subjects
                    WHERE SubjectID = @SubjectID
                    AND StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SubjectID", subjectID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

