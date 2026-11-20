
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AcademicSupportStudyPlanner.Models;
using AcademicSupportStudyPlanner.Controllers;

namespace AcademicSupportStudyPlanner.Views
{
    public partial class AcademicProgressForm : Form
    {
        private Student loggedInStudent;

        private AssignmentController assignmentController;
        private StudySessionController studyController;
        private SubjectController subjectController;

        private List<Assignment> loadedAssignments = new List<Assignment>();
        private List<StudySession> loadedSessions = new List<StudySession>();
        private List<Subject> loadedSubjects = new List<Subject>();

        public AcademicProgressForm(Student student)
        {
            InitializeComponent();

            loggedInStudent = student;

            assignmentController = new AssignmentController();
            studyController = new StudySessionController();
            subjectController = new SubjectController();

            lblWelcome.Text = "Welcome, " + student.FullName;

            btnBack.Click += btnBack_Click;

            LoadProgressData();
        }

        private void LoadProgressData()
        {
            try
            {
                loadedSubjects =
                    subjectController.GetSubjects(loggedInStudent.StudentID);

                loadedAssignments =
                    assignmentController.GetAssignments(loggedInStudent.StudentID);

                loadedSessions =
                    studyController.GetStudySessions(loggedInStudent.StudentID);

                UpdateSummaryCards();
                LoadCompletedAssignments();
                LoadStudyActivities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load academic progress.\n\n" + ex.Message,
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateSummaryCards()
        {
            int totalAssignments = loadedAssignments.Count;

            int completedAssignments = loadedAssignments.Count(a =>
                string.Equals(a.Status, "Completed",
                    StringComparison.OrdinalIgnoreCase));

            int pendingAssignments = loadedAssignments.Count(a =>
                string.Equals(a.Status, "Pending",
                    StringComparison.OrdinalIgnoreCase));

            int totalSessions = loadedSessions.Count;

            int completedSessions = loadedSessions.Count(s =>
                string.Equals(s.Status, "Completed",
                    StringComparison.OrdinalIgnoreCase));

            lblTotalAssignments.Text = totalAssignments.ToString();
            lblCompletedAssignments.Text = completedAssignments.ToString();
            lblPendingAssignments.Text = pendingAssignments.ToString();
            lblTotalSessions.Text = totalSessions.ToString();
            lblCompletedSessions.Text = completedSessions.ToString();
        }

        private string GetSubjectName(int subjectID)
        {
            Subject subject = loadedSubjects.FirstOrDefault(
                s => s.SubjectID == subjectID);

            return subject != null ? subject.SubjectName : "Unknown Subject";
        }

        private void LoadCompletedAssignments()
        {
            var completedList = loadedAssignments
                .Where(a => string.Equals(
                    a.Status, "Completed",
                    StringComparison.OrdinalIgnoreCase))
                .Select(a => new
                {
                    a.Title,
                    Subject = GetSubjectName(a.SubjectID),
                    DueDate = a.DueDate.ToString("dd MMM yyyy"),
                    a.Status
                })
                .ToList();

            dgvCompletedAssignments.DataSource = null;
            dgvCompletedAssignments.DataSource = completedList;
        }

        private void LoadStudyActivities()
        {
            var activityList = loadedSessions
                .Select(s => new
                {
                    s.Title,
                    Subject = GetSubjectName(s.SubjectID),
                    StudyDate = s.StudyDate.ToString("dd MMM yyyy"),
                    StartTime = s.StartTime.ToString(@"hh\:mm"),
                    EndTime = s.EndTime.ToString(@"hh\:mm"),
                    s.Status
                })
                .ToList();

            dgvStudyActivities.DataSource = null;
            dgvStudyActivities.DataSource = activityList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
