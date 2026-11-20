using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicSupportStudyPlanner.Controllers;
using AcademicSupportStudyPlanner.Models;
using AcademicSupportStudyPlanner.Views;

namespace AcademicSupportStudyPlanner.Views
{
    public partial class LoginForm : Form

    {
        public static Student CurrentStudent { get; private set; }
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += btnLogin_Click;
            btnRegister.Click += btnRegister_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show(
                        "Please enter your email and password.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                try
                {
                    StudentController controller = new StudentController();

                    Student student = controller.LoginStudent(email, password);


                    if (student != null)
                    {
                        CurrentStudent = student;

                        MessageBox.Show(
                            "Login successful!",
                            "Welcome",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.Hide();

                        DashboardForm dashboard = new DashboardForm(student);

                        dashboard.FormClosed += (s, args) =>
                        {
                            this.Show();
                            txtPassword.Clear();
                        };

                        dashboard.Show();
                    }

                    else
                    {
                        MessageBox.Show(
                            "Incorrect email or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Login error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                this.Hide();

                RegistrationForm registrationForm = new RegistrationForm();

                registrationForm.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                registrationForm.Show();
            }
        }
    }
}
