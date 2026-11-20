using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicSupportStudyPlanner.Models;
using AcademicSupportStudyPlanner.Controllers;

namespace AcademicSupportStudyPlanner.Views
{
    public partial class SubjectForm : Form
    {
        private Student loggedInStudent;
        private SubjectController subjectController;
        private int selectedSubjectID = 0;

        public SubjectForm(Student student)
        {
            InitializeComponent();

            loggedInStudent = student;
            subjectController = new SubjectController();

            lblWelcome.Text = "Welcome, " + student.FullName;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnBack.Click += btnBack_Click;

            dgvSubjects.CellClick += dgvSubjects_CellClick;

            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                dgvSubjects.DataSource = null;

                dgvSubjects.DataSource =
                    subjectController.GetSubjects(
                        loggedInStudent.StudentID
                    );

                if (dgvSubjects.Columns["StudentID"] != null)
                    dgvSubjects.Columns["StudentID"].Visible = false;

                if (dgvSubjects.Columns["CreatedAt"] != null)
                    dgvSubjects.Columns["CreatedAt"].Visible = false;

                if (dgvSubjects.Columns["SubjectID"] != null)
                    dgvSubjects.Columns["SubjectID"].HeaderText = "ID";

                if (dgvSubjects.Columns["SubjectName"] != null)
                    dgvSubjects.Columns["SubjectName"].HeaderText = "Subject Name";

                if (dgvSubjects.Columns["SubjectCode"] != null)
                    dgvSubjects.Columns["SubjectCode"].HeaderText = "Subject Code";

                if (dgvSubjects.Columns["Description"] != null)
                    dgvSubjects.Columns["Description"].HeaderText = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSubjects.CurrentRow?.DataBoundItem is Subject subject)
            {
                selectedSubjectID = subject.SubjectID;

                txtSubjectName.Text = subject.SubjectName;
                txtSubjectCode.Text = subject.SubjectCode;
                txtDescription.Text = subject.Description;
            }
        }
        private void lblSubjectName_Click(object sender, EventArgs e)
        {

        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSubjects.CurrentRow?.DataBoundItem is Subject subject)
            {
                selectedSubjectID = subject.SubjectID;

                txtSubjectName.Text = subject.SubjectName;
                txtSubjectCode.Text = subject.SubjectCode;
                txtDescription.Text = subject.Description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
                {
                    MessageBox.Show("Please enter the subject name.");
                    txtSubjectName.Focus();
                    return;
                }

                try
                {
                    Subject subject = new Subject
                    {
                        StudentID = loggedInStudent.StudentID,
                        SubjectName = txtSubjectName.Text.Trim(),
                        SubjectCode = txtSubjectCode.Text.Trim(),
                        Description = txtDescription.Text.Trim()
                    };

                    subjectController.AddSubject(subject);

                    MessageBox.Show("Subject added successfully!");

                    ClearFields();
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding subject: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == 0)
            {
                MessageBox.Show("Please select a subject first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Subject name is required.");
                return;
            }

            try
            {
                Subject subject = new Subject
                {
                    SubjectID = selectedSubjectID,
                    StudentID = loggedInStudent.StudentID,
                    SubjectName = txtSubjectName.Text.Trim(),
                    SubjectCode = txtSubjectCode.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };

                subjectController.UpdateSubject(subject);

                MessageBox.Show("Subject updated successfully!");

                ClearFields();
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating subject: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == 0)
            {
                MessageBox.Show("Please select a subject first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this subject?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    subjectController.DeleteSubject(
                        selectedSubjectID,
                        loggedInStudent.StudentID
                    );

                    MessageBox.Show("Subject deleted successfully!");

                    ClearFields();
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting subject: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtSubjectName.Clear();
            txtSubjectCode.Clear();
            txtDescription.Clear();

            selectedSubjectID = 0;
            dgvSubjects.ClearSelection();

            txtSubjectName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
