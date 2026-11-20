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

namespace AcademicSupportStudyPlanner.Views
{
    public partial class DashboardForm : Form
    {

        private Student loggedInStudent;

        public DashboardForm(Student student)
        {
            InitializeComponent();
            btnStudyPlanner.Click += btnStudyPlanner_Click;
            btnAssignments.Click += btnAssignments_Click;

            loggedInStudent = student;

            btnLogout.Click += btnLogout_Click;
            btnProgress.Click += btnProgress_Click;

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                DashboardController controller = new DashboardController();

                DashboardSummary summary =
                    controller.GetDashboardSummary(loggedInStudent.StudentID);

                // Display the student's name
                lblWelcome.Text = "Welcome, " + loggedInStudent.FullName + "!";

                // Display database statistics
                lblSubjectsCount.Text =
                    summary.TotalSubjects.ToString();

                lblAssignmentsCount.Text =
                    summary.TotalAssignments.ToString();

                lblPendingCount.Text =
                    summary.PendingAssignments.ToString();

                lblStudySessionsCount.Text =
                    summary.TotalStudySessions.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard information: " + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Logout and return to Login Form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            this.Hide();

            AssignmentForm assignmentForm =
                new AssignmentForm(loggedInStudent);

            assignmentForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadDashboardData();
            };

            assignmentForm.Show();
        }

        private void lblDashboardSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void lblOverview_Click(object sender, EventArgs e)
        {

        }

        private void btnStudyPlanner_Click(object sender, EventArgs e)
        {
            {
                this.Hide();

                StudyPlannerForm studyForm =
                    new StudyPlannerForm(loggedInStudent);

                studyForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                studyForm.Show();
            }
        }

        private void lblPendingCount_Click(object sender, EventArgs e)
        {

        }

        private void lblAssignmentsCount_Click(object sender, EventArgs e)
        {

        }

        private void lblStudySessionsCount_Click(object sender, EventArgs e)
        {

        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            this.Hide();

            AcademicProgressForm progressForm =
                new AcademicProgressForm(loggedInStudent);

            progressForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadDashboardData();
            };

            progressForm.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSubjectsTitle_Click(object sender, EventArgs e)
        {

        }
      

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            {
                this.Hide();

                SubjectForm subjectForm = new SubjectForm(loggedInStudent);

                subjectForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                subjectForm.Show();
            }
        }
    }
}
