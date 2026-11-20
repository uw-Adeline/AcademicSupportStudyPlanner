
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using AcademicSupportStudyPlanner.Models;
using AcademicSupportStudyPlanner.Controllers;

namespace AcademicSupportStudyPlanner.Views
{
    public partial class AssignmentForm : Form
    {
        private Student loggedInStudent;

        private AssignmentController assignmentController;
        private SubjectController subjectController;

        private List<Assignment> loadedAssignments =
            new List<Assignment>();

        private int selectedAssignmentID = 0;

        public AssignmentForm(Student student)
        {
            InitializeComponent();

            loggedInStudent = student;

            assignmentController = new AssignmentController();
            subjectController = new SubjectController();

            // Display logged-in student's name
            lblWelcome.Text = "Welcome, " + student.FullName;

            // Connect buttons to their events
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnBack.Click += btnBack_Click;

            // Connect table selection event
            dgvAssignments.CellClick += dgvAssignments_CellClick;

            // Load information
            LoadSubjects();
            LoadStatuses();
            LoadAssignments();
        }

        // LOAD THE STUDENT'S SUBJECTS
        private void LoadSubjects()
        {
            try
            {
                List<Subject> subjects =
                    subjectController.GetSubjects(
                        loggedInStudent.StudentID
                    );

                cmbSubject.DataSource = null;
                cmbSubject.DisplayMember = "SubjectName";
                cmbSubject.ValueMember = "SubjectID";
                cmbSubject.DataSource = subjects;

                cmbSubject.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading subjects: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // LOAD ASSIGNMENT STATUS OPTIONS
        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Completed");

            cmbStatus.SelectedIndex = 0;
        }

        // LOAD ASSIGNMENTS FROM DATABASE
        private void LoadAssignments()
        {
            try
            {
                loadedAssignments =
                    assignmentController.GetAssignments(
                        loggedInStudent.StudentID
                    );

                // Display assignments with their subject names
                var displayList = loadedAssignments.Select(a => new
                {
                    AssignmentID = a.AssignmentID,
                    Title = a.Title,

                    SubjectName = GetSubjectName(a.SubjectID),

                    DueDate = a.DueDate.ToString("dd MMM yyyy"),
                    Status = a.Status,
                    Description = a.Description
                }).ToList();

                dgvAssignments.DataSource = null;
                dgvAssignments.DataSource = displayList;

                // Set column headings
                dgvAssignments.Columns["AssignmentID"].HeaderText = "ID";
                dgvAssignments.Columns["Title"].HeaderText = "Assignment Title";
                dgvAssignments.Columns["SubjectName"].HeaderText = "Subject";
                dgvAssignments.Columns["DueDate"].HeaderText = "Due Date";
                dgvAssignments.Columns["Status"].HeaderText = "Status";
                dgvAssignments.Columns["Description"].HeaderText = "Description";

                dgvAssignments.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading assignments: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // GET SUBJECT NAME USING SUBJECT ID
        private string GetSubjectName(int subjectID)
        {
            foreach (Subject subject in
                subjectController.GetSubjects(loggedInStudent.StudentID))
            {
                if (subject.SubjectID == subjectID)
                    return subject.SubjectName;
            }

            return "Unknown Subject";
        }

        // VALIDATE INPUT FIELDS
        private bool ValidateFields()
        {
            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.");
                cmbSubject.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAssignmentTitle.Text))
            {
                MessageBox.Show("Please enter the assignment title.");
                txtAssignmentTitle.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assignment status.");
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        // ADD ASSIGNMENT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                Assignment assignment = new Assignment
                {
                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),

                    Title = txtAssignmentTitle.Text.Trim(),

                    Description = txtDescription.Text.Trim(),

                    DueDate = dtpDueDate.Value.Date,

                    Status = cmbStatus.SelectedItem.ToString()
                };

                bool result = assignmentController.AddAssignment(
                    assignment,
                    loggedInStudent.StudentID
                );

                if (result)
                {
                    MessageBox.Show(
                        "Assignment added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearFields();
                    LoadAssignments();
                }
                else
                {
                    MessageBox.Show("Assignment could not be added.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding assignment: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // SELECT ASSIGNMENT FROM TABLE
        private void dgvAssignments_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                int assignmentID = Convert.ToInt32(
                    dgvAssignments.Rows[e.RowIndex]
                    .Cells["AssignmentID"].Value
                );

                Assignment assignment = loadedAssignments
                    .FirstOrDefault(a => a.AssignmentID == assignmentID);

                if (assignment == null)
                    return;

                selectedAssignmentID = assignment.AssignmentID;

                cmbSubject.SelectedValue = assignment.SubjectID;

                txtAssignmentTitle.Text = assignment.Title;

                txtDescription.Text = assignment.Description;

                dtpDueDate.Value = assignment.DueDate;

                cmbStatus.SelectedItem = assignment.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error selecting assignment: " + ex.Message
                );
            }
        }

        // UPDATE ASSIGNMENT
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentID == 0)
            {
                MessageBox.Show(
                    "Please select an assignment from the table first."
                );
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                Assignment assignment = new Assignment
                {
                    AssignmentID = selectedAssignmentID,

                    SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),

                    Title = txtAssignmentTitle.Text.Trim(),

                    Description = txtDescription.Text.Trim(),

                    DueDate = dtpDueDate.Value.Date,

                    Status = cmbStatus.SelectedItem.ToString()
                };

                bool result = assignmentController.UpdateAssignment(
                    assignment,
                    loggedInStudent.StudentID
                );

                if (result)
                {
                    MessageBox.Show(
                        "Assignment updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearFields();
                    LoadAssignments();
                }
                else
                {
                    MessageBox.Show("Assignment could not be updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating assignment: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // DELETE ASSIGNMENT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentID == 0)
            {
                MessageBox.Show(
                    "Please select an assignment to delete."
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this assignment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool deleted = assignmentController.DeleteAssignment(
                        selectedAssignmentID,
                        loggedInStudent.StudentID
                    );

                    if (deleted)
                    {
                        MessageBox.Show(
                            "Assignment deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        ClearFields();
                        LoadAssignments();
                    }
                    else
                    {
                        MessageBox.Show("Assignment could not be deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting assignment: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // CLEAR INPUT FIELDS
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbSubject.SelectedIndex = -1;

            txtAssignmentTitle.Clear();

            txtDescription.Clear();

            dtpDueDate.Value = DateTime.Today;

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            selectedAssignmentID = 0;

            dgvAssignments.ClearSelection();
        }

        // RETURN TO DASHBOARD
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Assignment title TextChanged event
        private void txtAssignmentTitle_TextChanged(object sender, EventArgs e)
        {
        }

        // Description TextChanged event
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
        }

        // Due date label Click event
        private void lblDueDate_Click(object sender, EventArgs e)
        {
        }

        // Due date ValueChanged event
        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
        }

        // Status label Click event
        private void lblStatus_Click(object sender, EventArgs e)
        {
        }

    }
}

