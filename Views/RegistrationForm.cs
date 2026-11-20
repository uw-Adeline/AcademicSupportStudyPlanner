using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AcademicSupportStudyPlanner.Controllers;
using AcademicSupportStudyPlanner.Models;

namespace AcademicSupportStudyPlanner.Views
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            btnRegister.Click += btnRegister_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;
            btnExit.Click += btnExit_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check empty fields
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check email format
            try
            {
                MailAddress emailAddress = new MailAddress(email);

                if (emailAddress.Address != email)
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check password length
            if (password.Length < 8)
            {
                MessageBox.Show(
                    "Password must contain at least 8 characters."
                );
                return;
            }

            // Check password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match. Please try again.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Create student object
            Student student = new Student
            {
                FullName = fullName,
                Email = email
            };

            try
            {
                StudentController controller = new StudentController();

                bool registered =
                    controller.RegisterStudent(student, password);

                if (registered)
                {
                    MessageBox.Show(
                        "Account created successfully! You can now log in.",
                        "Registration Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Registration could not be completed. Please check your details."
                    );
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "This email address is already registered.",
                        "Duplicate Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Database error: " + ex.Message,
                        "Registration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
