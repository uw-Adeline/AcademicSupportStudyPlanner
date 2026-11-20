
using System;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using AcademicSupportStudyPlanner.Data;
using AcademicSupportStudyPlanner.Models;

namespace AcademicSupportStudyPlanner.Controllers
{
    public class StudentController
    {
        // REGISTER: Create a new student account
        public bool RegisterStudent(Student student, string password)
        {
            if (string.IsNullOrWhiteSpace(student.FullName) ||
                string.IsNullOrWhiteSpace(student.Email) ||
                string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            string passwordHash = HashPassword(password);

            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Students (FullName, Email, PasswordHash)
                    VALUES (@FullName, @Email, @PasswordHash)";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@FullName", student.FullName);

                    command.Parameters.AddWithValue(
                        "@Email", student.Email);

                    command.Parameters.AddWithValue(
                        "@PasswordHash", passwordHash);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // LOGIN: Check student email and password
        public Student LoginStudent(string email, string password)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT * FROM Students
                    WHERE Email = @Email";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    using (MySqlDataReader reader =
                           command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string savedHash =
                                Convert.ToString(reader["PasswordHash"]) ?? "";

                            if (VerifyPassword(password, savedHash))
                            {
                                Student student = new Student();

                                student.StudentID =
                                    Convert.ToInt32(reader["StudentID"]);

                                student.FullName =
                                    Convert.ToString(reader["FullName"]) ?? "";

                                student.Email =
                                    Convert.ToString(reader["Email"]) ?? "";

                                student.CreatedAt =
                                    Convert.ToDateTime(reader["CreatedAt"]);

                                return student;
                            }
                        }
                    }
                }
            }

            // Return null if the login details are incorrect
            return null;
        }

        // READ: Get student details using StudentID
        public Student GetStudentById(int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT StudentID, FullName, Email, CreatedAt
                    FROM Students
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
                        if (reader.Read())
                        {
                            Student student = new Student();

                            student.StudentID =
                                Convert.ToInt32(reader["StudentID"]);

                            student.FullName =
                                Convert.ToString(reader["FullName"]) ?? "";

                            student.Email =
                                Convert.ToString(reader["Email"]) ?? "";

                            student.CreatedAt =
                                Convert.ToDateTime(reader["CreatedAt"]);

                            return student;
                        }
                    }
                }
            }

            return null;
        }

        // UPDATE: Change student name and email
        public bool UpdateStudent(Student student)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    UPDATE Students
                    SET FullName = @FullName,
                        Email = @Email
                    WHERE StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@StudentID", student.StudentID);

                    command.Parameters.AddWithValue(
                        "@FullName", student.FullName);

                    command.Parameters.AddWithValue(
                        "@Email", student.Email);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE: Remove a student account
        public bool DeleteStudent(int studentID)
        {
            using (MySqlConnection connection =
                   DatabaseConnection.GetConnection())
            {
                string query = @"
                    DELETE FROM Students
                    WHERE StudentID = @StudentID";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@StudentID", studentID);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // SECURITY: Convert password into a secure hash
        private string HashPassword(string password)
        {
            int iterations = 100000;

            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                32
            );

            return iterations + ":" +
                   Convert.ToBase64String(salt) + ":" +
                   Convert.ToBase64String(hash);
        }

        // SECURITY: Verify the entered password
        private bool VerifyPassword(
            string password, string savedHash)
        {
            string[] parts = savedHash.Split(':');

            if (parts.Length != 3)
                return false;

            if (!int.TryParse(parts[0], out int iterations))
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] originalHash =
                    Convert.FromBase64String(parts[2]);

                byte[] enteredHash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256,
                    32
                );

                return CryptographicOperations.FixedTimeEquals(
                    originalHash, enteredHash);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

