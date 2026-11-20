namespace AcademicSupportStudyPlanner.Views
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppTitle = new Label();
            lblWelcome = new Label();
            lblDashboardSubtitle = new Label();
            btnLogout = new Button();
            lblOverview = new Label();
            pnlSubjects = new Panel();
            lblSubjectsCount = new Label();
            lblSubjectsTitle = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            pnlAssignments = new Panel();
            lblAssignmentsCount = new Label();
            lblAssignmentsTitle = new Label();
            pnlPending = new Panel();
            lblPendingCount = new Label();
            lblPendingTitle = new Label();
            pnlStudySessions = new Panel();
            lblStudySessionsCount = new Label();
            lblStudySessionsTitle = new Label();
            btnSubjects = new Button();
            btnAssignments = new Button();
            btnStudyPlanner = new Button();
            btnProgress = new Button();
            lblAcademicManagement = new Label();
            pnlSubjects.SuspendLayout();
            panel4.SuspendLayout();
            pnlAssignments.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlStudySessions.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.Navy;
            lblAppTitle.Location = new Point(52, 9);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(579, 45);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Academic Support and Study Planner";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Navy;
            lblWelcome.Location = new Point(60, 54);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(266, 38);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "\tWelcome, Student!";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardSubtitle.ForeColor = Color.Gray;
            lblDashboardSubtitle.Location = new Point(60, 92);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(500, 32);
            lblDashboardSubtitle.TabIndex = 2;
            lblDashboardSubtitle.Text = "Manage your academic activities in one place";
            lblDashboardSubtitle.Click += lblDashboardSubtitle_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.BlueViolet;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(632, 76);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // lblOverview
            // 
            lblOverview.AutoSize = true;
            lblOverview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverview.ForeColor = Color.Navy;
            lblOverview.Location = new Point(61, 136);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(252, 32);
            lblOverview.TabIndex = 4;
            lblOverview.Text = "Dashboard Overview";
            lblOverview.Click += lblOverview_Click;
            // 
            // pnlSubjects
            // 
            pnlSubjects.BackColor = Color.FromArgb(219, 234, 254);
            pnlSubjects.BorderStyle = BorderStyle.FixedSingle;
            pnlSubjects.Controls.Add(lblSubjectsCount);
            pnlSubjects.Controls.Add(lblSubjectsTitle);
            pnlSubjects.Controls.Add(panel4);
            pnlSubjects.Controls.Add(panel3);
            pnlSubjects.Location = new Point(52, 185);
            pnlSubjects.Name = "pnlSubjects";
            pnlSubjects.Size = new Size(261, 119);
            pnlSubjects.TabIndex = 5;
            // 
            // lblSubjectsCount
            // 
            lblSubjectsCount.AutoSize = true;
            lblSubjectsCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjectsCount.ForeColor = Color.Navy;
            lblSubjectsCount.Location = new Point(46, 71);
            lblSubjectsCount.Name = "lblSubjectsCount";
            lblSubjectsCount.Size = new Size(41, 48);
            lblSubjectsCount.TabIndex = 8;
            lblSubjectsCount.Text = "0";
            // 
            // lblSubjectsTitle
            // 
            lblSubjectsTitle.AutoSize = true;
            lblSubjectsTitle.Location = new Point(37, 20);
            lblSubjectsTitle.Name = "lblSubjectsTitle";
            lblSubjectsTitle.Size = new Size(120, 25);
            lblSubjectsTitle.TabIndex = 0;
            lblSubjectsTitle.Text = "Total Subjects";
            lblSubjectsTitle.Click += lblSubjectsTitle_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(8, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 115);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 170);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 145);
            panel5.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 145);
            panel3.TabIndex = 6;
            // 
            // pnlAssignments
            // 
            pnlAssignments.BackColor = Color.FromArgb(220, 239, 229);
            pnlAssignments.BorderStyle = BorderStyle.FixedSingle;
            pnlAssignments.Controls.Add(lblAssignmentsCount);
            pnlAssignments.Controls.Add(lblAssignmentsTitle);
            pnlAssignments.Location = new Point(347, 185);
            pnlAssignments.Name = "pnlAssignments";
            pnlAssignments.Size = new Size(284, 119);
            pnlAssignments.TabIndex = 6;
            // 
            // lblAssignmentsCount
            // 
            lblAssignmentsCount.AutoSize = true;
            lblAssignmentsCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssignmentsCount.ForeColor = Color.Navy;
            lblAssignmentsCount.Location = new Point(50, 71);
            lblAssignmentsCount.Name = "lblAssignmentsCount";
            lblAssignmentsCount.Size = new Size(41, 48);
            lblAssignmentsCount.TabIndex = 9;
            lblAssignmentsCount.Text = "0";
            lblAssignmentsCount.Click += lblAssignmentsCount_Click;
            // 
            // lblAssignmentsTitle
            // 
            lblAssignmentsTitle.AutoSize = true;
            lblAssignmentsTitle.Location = new Point(38, 20);
            lblAssignmentsTitle.Name = "lblAssignmentsTitle";
            lblAssignmentsTitle.Size = new Size(156, 25);
            lblAssignmentsTitle.TabIndex = 9;
            lblAssignmentsTitle.Text = "\tTotal Assignments";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.FromArgb(254, 240, 213);
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(lblPendingCount);
            pnlPending.Controls.Add(lblPendingTitle);
            pnlPending.Location = new Point(53, 327);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(261, 143);
            pnlPending.TabIndex = 7;
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.Navy;
            lblPendingCount.Location = new Point(45, 90);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(41, 48);
            lblPendingCount.TabIndex = 9;
            lblPendingCount.Text = "0";
            lblPendingCount.Click += lblPendingCount_Click;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Location = new Point(36, 23);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(183, 25);
            lblPendingTitle.TabIndex = 9;
            lblPendingTitle.Text = "\tPending Assignments";
            // 
            // pnlStudySessions
            // 
            pnlStudySessions.BackColor = Color.FromArgb(233, 221, 248);
            pnlStudySessions.BorderStyle = BorderStyle.FixedSingle;
            pnlStudySessions.Controls.Add(lblStudySessionsCount);
            pnlStudySessions.Controls.Add(lblStudySessionsTitle);
            pnlStudySessions.Location = new Point(347, 335);
            pnlStudySessions.Name = "pnlStudySessions";
            pnlStudySessions.Size = new Size(284, 135);
            pnlStudySessions.TabIndex = 8;
            // 
            // lblStudySessionsCount
            // 
            lblStudySessionsCount.AutoSize = true;
            lblStudySessionsCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudySessionsCount.ForeColor = Color.Navy;
            lblStudySessionsCount.Location = new Point(46, 82);
            lblStudySessionsCount.Name = "lblStudySessionsCount";
            lblStudySessionsCount.Size = new Size(41, 48);
            lblStudySessionsCount.TabIndex = 9;
            lblStudySessionsCount.Text = "0";
            lblStudySessionsCount.Click += lblStudySessionsCount_Click;
            // 
            // lblStudySessionsTitle
            // 
            lblStudySessionsTitle.AutoSize = true;
            lblStudySessionsTitle.Location = new Point(37, 23);
            lblStudySessionsTitle.Name = "lblStudySessionsTitle";
            lblStudySessionsTitle.Size = new Size(130, 25);
            lblStudySessionsTitle.TabIndex = 9;
            lblStudySessionsTitle.Text = "\tStudy Sessions";
            // 
            // btnSubjects
            // 
            btnSubjects.BackColor = Color.FromArgb(40, 120, 181);
            btnSubjects.Cursor = Cursors.Hand;
            btnSubjects.FlatStyle = FlatStyle.Flat;
            btnSubjects.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubjects.ForeColor = Color.White;
            btnSubjects.Location = new Point(56, 546);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(260, 45);
            btnSubjects.TabIndex = 10;
            btnSubjects.Text = "Manage Subjects";
            btnSubjects.UseVisualStyleBackColor = false;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnAssignments
            // 
            btnAssignments.BackColor = Color.FromArgb(23, 54, 93);
            btnAssignments.Cursor = Cursors.Hand;
            btnAssignments.FlatStyle = FlatStyle.Flat;
            btnAssignments.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignments.ForeColor = Color.White;
            btnAssignments.Location = new Point(347, 546);
            btnAssignments.Name = "btnAssignments";
            btnAssignments.Size = new Size(260, 45);
            btnAssignments.TabIndex = 11;
            btnAssignments.Text = "\tManage Assignments";
            btnAssignments.UseVisualStyleBackColor = false;
            btnAssignments.Click += btnAssignments_Click;
            // 
            // btnStudyPlanner
            // 
            btnStudyPlanner.BackColor = Color.FromArgb(40, 120, 181);
            btnStudyPlanner.Cursor = Cursors.Hand;
            btnStudyPlanner.FlatStyle = FlatStyle.Flat;
            btnStudyPlanner.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudyPlanner.ForeColor = Color.White;
            btnStudyPlanner.Location = new Point(56, 598);
            btnStudyPlanner.Name = "btnStudyPlanner";
            btnStudyPlanner.Size = new Size(260, 45);
            btnStudyPlanner.TabIndex = 12;
            btnStudyPlanner.Text = "Study Planner";
            btnStudyPlanner.UseVisualStyleBackColor = false;
            btnStudyPlanner.Click += btnStudyPlanner_Click;
            // 
            // btnProgress
            // 
            btnProgress.BackColor = Color.FromArgb(23, 54, 93);
            btnProgress.Cursor = Cursors.Hand;
            btnProgress.FlatStyle = FlatStyle.Flat;
            btnProgress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProgress.ForeColor = Color.White;
            btnProgress.Location = new Point(347, 598);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(260, 45);
            btnProgress.TabIndex = 13;
            btnProgress.Text = "Academic Progress";
            btnProgress.UseVisualStyleBackColor = false;
            btnProgress.Click += btnProgress_Click;
            // 
            // lblAcademicManagement
            // 
            lblAcademicManagement.AutoSize = true;
            lblAcademicManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcademicManagement.ForeColor = Color.Navy;
            lblAcademicManagement.Location = new Point(56, 500);
            lblAcademicManagement.Name = "lblAcademicManagement";
            lblAcademicManagement.Size = new Size(283, 32);
            lblAcademicManagement.TabIndex = 14;
            lblAcademicManagement.Text = "\tAcademic Management";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(806, 699);
            Controls.Add(lblAcademicManagement);
            Controls.Add(btnProgress);
            Controls.Add(btnStudyPlanner);
            Controls.Add(btnAssignments);
            Controls.Add(btnSubjects);
            Controls.Add(pnlStudySessions);
            Controls.Add(pnlPending);
            Controls.Add(pnlAssignments);
            Controls.Add(pnlSubjects);
            Controls.Add(lblOverview);
            Controls.Add(btnLogout);
            Controls.Add(lblDashboardSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(lblAppTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tAcademic Support and Study Planner - Dashboard";
            pnlSubjects.ResumeLayout(false);
            pnlSubjects.PerformLayout();
            panel4.ResumeLayout(false);
            pnlAssignments.ResumeLayout(false);
            pnlAssignments.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlStudySessions.ResumeLayout(false);
            pnlStudySessions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppTitle;
        private Label lblWelcome;
        private Label lblDashboardSubtitle;
        private Button btnLogout;
        private Label lblOverview;
        private Panel pnlSubjects;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel pnlAssignments;
        private Panel pnlPending;
        private Panel pnlStudySessions;
        private Label lblSubjectsCount;
        private Label lblSubjectsTitle;
        private Label lblAssignmentsCount;
        private Label lblAssignmentsTitle;
        private Label lblPendingCount;
        private Label lblPendingTitle;
        private Label lblStudySessionsCount;
        private Label lblStudySessionsTitle;
        private Button btnSubjects;
        private Button btnAssignments;
        private Button btnStudyPlanner;
        private Button btnProgress;
        private Label lblAcademicManagement;
    }
}