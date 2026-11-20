
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AcademicSupportStudyPlanner.Data;
using AcademicSupportStudyPlanner.Models;

namespace AcademicSupportStudyPlanner.Controllers
{
    public class StudySessionController
    {
        // CREATE: Add a new study session
        public bool AddStudySession(StudySession session, int studentID)
        {
            // End time must be later than start time
            if (session.EndTime <= session.StartTime)
            {
                return false;
            }

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO StudySessions
                    (SubjectID, Title, StudyDate, StartTime,
                     EndTime, Notes, Status)
                    SELECT SubjectID, @Title, @StudyDate, @StartTime,
                           @EndTime, @Notes, @Status
                    FROM Subjects
                    WHERE SubjectID = @SubjectID
                    AND StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SubjectID", session.SubjectID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    command.Parameters.AddWithValue(
                        "@Title", session.Title);

                    command.Parameters.AddWithValue(
                        "@StudyDate", session.StudyDate.Date);

                    command.Parameters.AddWithValue(
                        "@StartTime", session.StartTime);

                    command.Parameters.AddWithValue(
                        "@EndTime", session.EndTime);

                    command.Parameters.AddWithValue(
                        "@Notes",
                        (object)session.Notes ?? DBNull.Value);

                    command.Parameters.AddWithValue(
                        "@Status", session.Status ?? "Planned");

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // READ: Get all study sessions belonging to a student
        public List<StudySession> GetStudySessions(int studentID)
        {
            List<StudySession> sessions =
                new List<StudySession>();

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT SS.*
                    FROM StudySessions SS
                    INNER JOIN Subjects S
                    ON SS.SubjectID = S.SubjectID
                    WHERE S.StudentID = @StudentID
                    ORDER BY SS.StudyDate ASC, SS.StartTime ASC";

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
                            StudySession session =
                                new StudySession();

                            session.SessionID =
                                Convert.ToInt32(reader["SessionID"]);

                            session.SubjectID =
                                Convert.ToInt32(reader["SubjectID"]);

                            session.Title =
                                Convert.ToString(reader["Title"]) ?? "";

                            session.StudyDate =
                                Convert.ToDateTime(reader["StudyDate"]);

                            session.StartTime =
                                TimeSpan.Parse(
                                    reader["StartTime"].ToString());

                            session.EndTime =
                                TimeSpan.Parse(
                                    reader["EndTime"].ToString());

                            session.Notes =
                                reader["Notes"] == DBNull.Value
                                ? ""
                                : Convert.ToString(reader["Notes"]) ?? "";

                            session.Status =
                                Convert.ToString(reader["Status"]) ?? "Planned";

                            sessions.Add(session);
                        }
                    }
                }
            }

            return sessions;
        }

        // UPDATE: Modify an existing study session
        public bool UpdateStudySession(
            StudySession session, int studentID)
        {
            if (session.EndTime <= session.StartTime)
            {
                return false;
            }

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    UPDATE StudySessions SS
                    INNER JOIN Subjects S
                    ON SS.SubjectID = S.SubjectID
                    SET SS.Title = @Title,
                        SS.StudyDate = @StudyDate,
                        SS.StartTime = @StartTime,
                        SS.EndTime = @EndTime,
                        SS.Notes = @Notes,
                        SS.Status = @Status
                    WHERE SS.SessionID = @SessionID
                    AND S.StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SessionID", session.SessionID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    command.Parameters.AddWithValue(
                        "@Title", session.Title);

                    command.Parameters.AddWithValue(
                        "@StudyDate", session.StudyDate.Date);

                    command.Parameters.AddWithValue(
                        "@StartTime", session.StartTime);

                    command.Parameters.AddWithValue(
                        "@EndTime", session.EndTime);

                    command.Parameters.AddWithValue(
                        "@Notes",
                        (object)session.Notes ?? DBNull.Value);

                    command.Parameters.AddWithValue(
                        "@Status", session.Status ?? "Planned");

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE: Remove a study session
        public bool DeleteStudySession(
            int sessionID, int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    DELETE SS
                    FROM StudySessions SS
                    INNER JOIN Subjects S
                    ON SS.SubjectID = S.SubjectID
                    WHERE SS.SessionID = @SessionID
                    AND S.StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@SessionID", sessionID);

                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

