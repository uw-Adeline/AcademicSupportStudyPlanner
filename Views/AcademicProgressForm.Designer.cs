
using System.Drawing;
using System.Windows.Forms;

namespace AcademicSupportStudyPlanner.Views
{
    partial class AcademicProgressForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblWelcome;

        private Panel pnlTotalAssignments;
        private Panel pnlCompletedAssignments;
        private Panel pnlPendingAssignments;
        private Panel pnlTotalSessions;
        private Panel pnlCompletedSessions;

        private Label lblTotalAssignmentsTitle;
        private Label lblCompletedAssignmentsTitle;
        private Label lblPendingAssignmentsTitle;
        private Label lblTotalSessionsTitle;
        private Label lblCompletedSessionsTitle;

        private Label lblTotalAssignments;
        private Label lblCompletedAssignments;
        private Label lblPendingAssignments;
        private Label lblTotalSessions;
        private Label lblCompletedSessions;

        private Label lblAssignmentsSection;
        private Label lblStudySection;

        private DataGridView dgvCompletedAssignments;
        private DataGridView dgvStudyActivities;

        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.lblWelcome = new Label();

            this.pnlTotalAssignments = new Panel();
            this.pnlCompletedAssignments = new Panel();
            this.pnlPendingAssignments = new Panel();
            this.pnlTotalSessions = new Panel();
            this.pnlCompletedSessions = new Panel();

            this.lblTotalAssignmentsTitle = new Label();
            this.lblCompletedAssignmentsTitle = new Label();
            this.lblPendingAssignmentsTitle = new Label();
            this.lblTotalSessionsTitle = new Label();
            this.lblCompletedSessionsTitle = new Label();

            this.lblTotalAssignments = new Label();
            this.lblCompletedAssignments = new Label();
            this.lblPendingAssignments = new Label();
            this.lblTotalSessions = new Label();
            this.lblCompletedSessions = new Label();

            this.lblAssignmentsSection = new Label();
            this.lblStudySection = new Label();

            this.dgvCompletedAssignments = new DataGridView();
            this.dgvStudyActivities = new DataGridView();

            this.btnBack = new Button();

            this.pnlHeader.SuspendLayout();
            this.pnlTotalAssignments.SuspendLayout();
            this.pnlCompletedAssignments.SuspendLayout();
            this.pnlPendingAssignments.SuspendLayout();
            this.pnlTotalSessions.SuspendLayout();
            this.pnlCompletedSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudyActivities)).BeginInit();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.ClientSize = new Size(1050, 780);
            this.MinimumSize = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Academic Progress";
            this.Name = "AcademicProgressForm";

            // HEADER
            this.pnlHeader.BackColor = Color.FromArgb(23, 54, 93);
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Size = new Size(1050, 115);
            this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.lblTitle.Text = "Academic Progress";
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(30, 15);
            this.lblTitle.Size = new Size(450, 40);

            this.lblSubtitle.Text = "Track your assignments and study activities";
            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.FromArgb(220, 230, 242);
            this.lblSubtitle.Location = new Point(33, 62);
            this.lblSubtitle.Size = new Size(450, 25);

            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblWelcome.ForeColor = Color.White;
            this.lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            this.lblWelcome.Location = new Point(650, 35);
            this.lblWelcome.Size = new Size(370, 35);
            this.lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblWelcome);

            // SUMMARY CARD 1
            ConfigureCard(
                pnlTotalAssignments,
                lblTotalAssignmentsTitle,
                lblTotalAssignments,
                "Total Assignments",
                Color.FromArgb(219, 234, 254),
                Color.FromArgb(23, 54, 93),
                25);

            // SUMMARY CARD 2
            ConfigureCard(
                pnlCompletedAssignments,
                lblCompletedAssignmentsTitle,
                lblCompletedAssignments,
                "Completed Assignments",
                Color.FromArgb(220, 239, 229),
                Color.FromArgb(23, 107, 69),
                225);

            // SUMMARY CARD 3
            ConfigureCard(
                pnlPendingAssignments,
                lblPendingAssignmentsTitle,
                lblPendingAssignments,
                "Pending Assignments",
                Color.FromArgb(254, 240, 213),
                Color.FromArgb(138, 90, 18),
                425);

            // SUMMARY CARD 4
            ConfigureCard(
                pnlTotalSessions,
                lblTotalSessionsTitle,
                lblTotalSessions,
                "Total Study Sessions",
                Color.FromArgb(233, 221, 248),
                Color.FromArgb(89, 53, 140),
                625);

            // SUMMARY CARD 5
            ConfigureCard(
                pnlCompletedSessions,
                lblCompletedSessionsTitle,
                lblCompletedSessions,
                "Completed Sessions",
                Color.FromArgb(226, 232, 240),
                Color.FromArgb(51, 65, 85),
                825);

            // ASSIGNMENTS SECTION
            this.lblAssignmentsSection.Text = "Completed Assignments";
            this.lblAssignmentsSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblAssignmentsSection.ForeColor = Color.FromArgb(23, 54, 93);
            this.lblAssignmentsSection.Location = new Point(25, 225);
            this.lblAssignmentsSection.Size = new Size(450, 30);

            ConfigureGrid(this.dgvCompletedAssignments, 25, 260, 1000, 155);

            // STUDY SECTION
            this.lblStudySection.Text = "Study Activities";
            this.lblStudySection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblStudySection.ForeColor = Color.FromArgb(23, 54, 93);
            this.lblStudySection.Location = new Point(25, 435);
            this.lblStudySection.Size = new Size(450, 30);

            ConfigureGrid(this.dgvStudyActivities, 25, 470, 1000, 210);

            // BACK BUTTON
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.Name = "btnBack";
            this.btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnBack.BackColor = Color.FromArgb(23, 54, 93);
            this.btnBack.ForeColor = Color.White;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new Point(25, 710);
            this.btnBack.Size = new Size(190, 40);
            this.btnBack.Cursor = Cursors.Hand;

            // ADD CONTROLS TO FORM
            this.Controls.Add(this.pnlHeader);

            this.Controls.Add(this.pnlTotalAssignments);
            this.Controls.Add(this.pnlCompletedAssignments);
            this.Controls.Add(this.pnlPendingAssignments);
            this.Controls.Add(this.pnlTotalSessions);
            this.Controls.Add(this.pnlCompletedSessions);

            this.Controls.Add(this.lblAssignmentsSection);
            this.Controls.Add(this.dgvCompletedAssignments);

            this.Controls.Add(this.lblStudySection);
            this.Controls.Add(this.dgvStudyActivities);

            this.Controls.Add(this.btnBack);

            this.pnlHeader.ResumeLayout(false);
            this.pnlTotalAssignments.ResumeLayout(false);
            this.pnlCompletedAssignments.ResumeLayout(false);
            this.pnlPendingAssignments.ResumeLayout(false);
            this.pnlTotalSessions.ResumeLayout(false);
            this.pnlCompletedSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudyActivities)).EndInit();
            this.ResumeLayout(false);
        }

        private void ConfigureCard(
            Panel panel,
            Label titleLabel,
            Label countLabel,
            string title,
            Color backgroundColor,
            Color textColor,
            int left)
        {
            panel.BackColor = backgroundColor;
            panel.Location = new Point(left, 140);
            panel.Size = new Size(185, 75);
            panel.BorderStyle = BorderStyle.None;

            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            titleLabel.ForeColor = textColor;
            titleLabel.Location = new Point(10, 8);
            titleLabel.Size = new Size(165, 25);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            countLabel.Text = "0";
            countLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            countLabel.ForeColor = textColor;
            countLabel.Location = new Point(10, 33);
            countLabel.Size = new Size(165, 35);
            countLabel.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(titleLabel);
            panel.Controls.Add(countLabel);
        }

        private void ConfigureGrid(
            DataGridView grid,
            int left,
            int top,
            int width,
            int height)
        {
            grid.Location = new Point(left, top);
            grid.Size = new Size(width, height);
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            grid.AutoGenerateColumns = true;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(23, 54, 93);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            grid.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(23, 54, 93);

            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);
        }
    }
}
