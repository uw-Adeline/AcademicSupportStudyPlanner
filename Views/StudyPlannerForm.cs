
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AcademicSupportStudyPlanner.Models;
using AcademicSupportStudyPlanner.Controllers;
using Org.BouncyCastle.Asn1.Cmp;

namespace AcademicSupportStudyPlanner.Views
{
    public partial class StudyPlannerForm : Form
    {
        private Student loggedInStudent;
        private StudySessionController studyController;
        private SubjectController subjectController;

        private List<StudySession> loadedSessions =
            new List<StudySession>();

        private List<Subject> loadedSubjects =
            new List<Subject>();

        private int selectedSessionID = 0;

        public StudyPlannerForm(Student student)
        {
            InitializeComponent();

            loggedInStudent = student;

            studyController = new StudySessionController();
            subjectController = new SubjectController();

            lblWelcome.Text = "Welcome, " + student.FullName;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnBack.Click += btnBack_Click;

            dgvStudySessions.CellClick += dgvStudySessions_CellClick;

            LoadSubjects();
            LoadStatuses();
            LoadStudySessions();
        }

        private void LoadSubjects()
        {
            try
            {
                loadedSubjects =
                    subjectController.GetSubjects(
                        loggedInStudent.StudentID
                    );

                cmbSubject.DataSource = null;
                cmbSubject.DisplayMember = "SubjectName";
                cmbSubject.ValueMember = "SubjectID";
                cmbSubject.DataSource = loadedSubjects;
                cmbSubject.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading subjects: " + ex.Message
                );
            }
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Planned");
            cmbStatus.Items.Add("Completed");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadStudySessions()
        {
            try
            {
                loadedSessions =
                    studyController.GetStudySessions(
                        loggedInStudent.StudentID
                    );

                var displayList = loadedSessions.Select(session => new
                {
                    SessionID = session.SessionID,
                    Title = session.Title,
                    Subject = GetSubjectName(session.SubjectID),
                    StudyDate = session.StudyDate.ToString("dd MMM yyyy"),
                    StartTime = session.StartTime.ToString(@"hh\:mm"),
                    EndTime = session.EndTime.ToString(@"hh\:mm"),
                    Status = session.Status,
                    Notes = session.Notes
                }).ToList();

                dgvStudySessions.DataSource = null;
                dgvStudySessions.DataSource = displayList;

                dgvStudySessions.Columns["SessionID"].HeaderText = "ID";
                dgvStudySessions.Columns["Title"].HeaderText = "Study Activity";
                dgvStudySessions.Columns["Subject"].HeaderText = "Subject";
                dgvStudySessions.Columns["StudyDate"].HeaderText = "Study Date";
                dgvStudySessions.Columns["StartTime"].HeaderText = "Start Time";
                dgvStudySessions.Columns["EndTime"].HeaderText = "End Time";
                dgvStudySessions.Columns["Status"].HeaderText = "Status";
                dgvStudySessions.Columns["Notes"].HeaderText = "Notes";

                dgvStudySessions.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading study sessions: " + ex.Message
                );
            }
        }

        private string GetSubjectName(int subjectID)
        {
            Subject subject = loadedSubjects.FirstOrDefault(
                s => s.SubjectID == subjectID
            );

            return subject == null ? "Unknown Subject" : subject.SubjectName;
        }

        private bool ValidateFields()
        {
            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.");
                cmbSubject.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a study activity title.");
                txtTitle.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                cmbStatus.Focus();
                return false;
            }

            TimeSpan start = dtpStartTime.Value.TimeOfDay;
            TimeSpan end = dtpEndTime.Value.TimeOfDay;

            if (end <= start)
            {
                MessageBox.Show(
                    "End time must be later than start time."
                );
                dtpEndTime.Focus();
                return false;
            }

            return true;
        }

        private StudySession CreateSession()
        {
            return new StudySession
            {
                SessionID = selectedSessionID,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                Title = txtTitle.Text.Trim(),
                StudyDate = dtpStudyDate.Value.Date,
                StartTime = dtpStartTime.Value.TimeOfDay,
                EndTime = dtpEndTime.Value.TimeOfDay,
                Notes = txtNotes.Text.Trim(),
                Status = cmbStatus.SelectedItem.ToString()
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                StudySession session = CreateSession();

                bool result = studyController.AddStudySession(
                    session,
                    loggedInStudent.StudentID
                );

                if (result)
                {
                    MessageBox.Show("Study session added successfully!");
                    ClearFields();
                    LoadStudySessions();
                }
                else
                {
                    MessageBox.Show("Study session could not be added.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding study session: " + ex.Message);
            }
        }

        private void dgvStudySessions_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                int sessionID = Convert.ToInt32(
                    dgvStudySessions.Rows[e.RowIndex]
                    .Cells["SessionID"].Value
                );

                StudySession session = loadedSessions.FirstOrDefault(
                    s => s.SessionID == sessionID
                );

                if (session == null)
                    return;

                selectedSessionID = session.SessionID;

                cmbSubject.SelectedValue = session.SubjectID;
                txtTitle.Text = session.Title;
                dtpStudyDate.Value = session.StudyDate.Date;

                dtpStartTime.Value = DateTime.Today.Add(session.StartTime);
                dtpEndTime.Value = DateTime.Today.Add(session.EndTime);

                txtNotes.Text = session.Notes;
                cmbStatus.SelectedItem = session.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error selecting study session: " + ex.Message
                );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSessionID == 0)
            {
                MessageBox.Show("Please select a study session first.");
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                StudySession session = CreateSession();

                bool result = studyController.UpdateStudySession(
                    session,
                    loggedInStudent.StudentID
                );

                if (result)
                {
                    MessageBox.Show("Study session updated successfully!");
                    ClearFields();
                    LoadStudySessions();
                }
                else
                {
                    MessageBox.Show("Study session could not be updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating study session: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSessionID == 0)
            {
                MessageBox.Show("Please select a study session first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this study session?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool deleted = studyController.DeleteStudySession(
                        selectedSessionID,
                        loggedInStudent.StudentID
                    );

                    if (deleted)
                    {
                        MessageBox.Show("Study session deleted successfully!");
                        ClearFields();
                        LoadStudySessions();
                    }
                    else
                    {
                        MessageBox.Show("Study session could not be deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting study session: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbSubject.SelectedIndex = -1;
            txtTitle.Clear();
            dtpStudyDate.Value = DateTime.Today;
            dtpStartTime.Value = DateTime.Today.AddHours(8);
            dtpEndTime.Value = DateTime.Today.AddHours(9);
            txtNotes.Clear();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            selectedSessionID = 0;
            dgvStudySessions.ClearSelection();
            txtTitle.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
