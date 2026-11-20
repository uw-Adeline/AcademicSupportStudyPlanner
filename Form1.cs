using AcademicSupportStudyPlanner.Data;
using System;
using System.Windows.Forms;
namespace AcademicSupportStudyPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            if (DatabaseConnection.TestConnection())
            {
                MessageBox.Show(
                    "Database connected successfully!",
                    "Connection Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Database connection failed. Please check your MySQL settings.",
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
