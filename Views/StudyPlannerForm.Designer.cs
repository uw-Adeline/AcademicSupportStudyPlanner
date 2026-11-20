
using System.Drawing;
using System.Windows.Forms;
namespace AcademicSupportStudyPlanner.Views

{
    partial class StudyPlannerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();

            pnlStudyDetails = new Panel();
            lblFormTitle = new Label();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblStudyTitle = new Label();
            txtTitle = new TextBox();
            lblStudyDate = new Label();
            dtpStudyDate = new DateTimePicker();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            lblNotes = new Label();
            txtNotes = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            lblSessionsList = new Label();
            dgvStudySessions = new DataGridView();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlStudyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudySessions).BeginInit();
            SuspendLayout();

            // FORM
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1000, 750);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Study Planner";
            Name = "StudyPlannerForm";
            MinimumSize = new Size(1016, 789);

            // HEADER PANEL
            pnlHeader.BackColor = Color.FromArgb(23, 54, 93);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 105);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblWelcome);

            // HEADER TITLE
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Study Planner";

            // HEADER SUBTITLE
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(35, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Plan and organize your study sessions";

            // WELCOME
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(750, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = "Welcome";

            // DETAILS PANEL
            pnlStudyDetails.BackColor = Color.White;
            pnlStudyDetails.Location = new Point(30, 125);
            pnlStudyDetails.Name = "pnlStudyDetails";
            pnlStudyDetails.Size = new Size(940, 320);

            // FORM TITLE
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(23, 54, 93);
            lblFormTitle.Location = new Point(20, 10);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Text = "Study Session Details";

            // SUBJECT
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(25, 52);
            lblSubject.Name = "lblSubject";
            lblSubject.Text = "Subject";

            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.Font = new Font("Segoe UI", 10F);
            cmbSubject.Location = new Point(25, 76);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(420, 31);

            // STUDY TITLE
            lblStudyTitle.AutoSize = true;
            lblStudyTitle.Location = new Point(475, 52);
            lblStudyTitle.Name = "lblStudyTitle";
            lblStudyTitle.Text = "Study Activity Title";

            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(475, 76);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(420, 30);

            // STUDY DATE
            lblStudyDate.AutoSize = true;
            lblStudyDate.Location = new Point(25, 118);
            lblStudyDate.Name = "lblStudyDate";
            lblStudyDate.Text = "Study Date";

            dtpStudyDate.Font = new Font("Segoe UI", 10F);
            dtpStudyDate.Format = DateTimePickerFormat.Short;
            dtpStudyDate.Location = new Point(25, 142);
            dtpStudyDate.Name = "dtpStudyDate";
            dtpStudyDate.Size = new Size(200, 30);

            // START TIME
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(250, 118);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Text = "Start Time";

            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Font = new Font("Segoe UI", 10F);
            dtpStartTime.Location = new Point(250, 142);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(150, 30);
            dtpStartTime.Value = DateTime.Today.AddHours(8);

            // END TIME
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(425, 118);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Text = "End Time";

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Font = new Font("Segoe UI", 10F);
            dtpEndTime.Location = new Point(425, 142);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(150, 30);
            dtpEndTime.Value = DateTime.Today.AddHours(9);

            // STATUS
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(600, 118);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "Status";

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.Location = new Point(600, 142);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(295, 31);

            // NOTES
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(25, 185);
            lblNotes.Name = "lblNotes";
            lblNotes.Text = "Study Notes";

            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Location = new Point(25, 210);
            txtNotes.Multiline = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(870, 48);

            // BUTTONS
            ConfigureButton(btnAdd, "Add", "btnAdd",
                Color.FromArgb(40, 120, 181), 275, 270);

            ConfigureButton(btnUpdate, "Update", "btnUpdate",
                Color.FromArgb(23, 54, 93), 385, 270);

            ConfigureButton(btnDelete, "Delete", "btnDelete",
                Color.FromArgb(220, 53, 69), 495, 270);

            ConfigureButton(btnClear, "Clear", "btnClear",
                Color.FromArgb(108, 117, 125), 605, 270);

            pnlStudyDetails.Controls.AddRange(new Control[]
            {
                lblFormTitle, lblSubject, cmbSubject,
                lblStudyTitle, txtTitle,
                lblStudyDate, dtpStudyDate,
                lblStartTime, dtpStartTime,
                lblEndTime, dtpEndTime,
                lblStatus, cmbStatus,
                lblNotes, txtNotes,
                btnAdd, btnUpdate, btnDelete, btnClear
            });

            // SESSIONS LABEL
            lblSessionsList.AutoSize = true;
            lblSessionsList.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSessionsList.ForeColor = Color.FromArgb(23, 54, 93);
            lblSessionsList.Location = new Point(30, 465);
            lblSessionsList.Name = "lblSessionsList";
            lblSessionsList.Text = "Your Study Sessions";

            // DATA GRID
            dgvStudySessions.AllowUserToAddRows = false;
            dgvStudySessions.AllowUserToDeleteRows = false;
            dgvStudySessions.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudySessions.BackgroundColor = Color.White;
            dgvStudySessions.Location = new Point(30, 505);
            dgvStudySessions.Name = "dgvStudySessions";
            dgvStudySessions.ReadOnly = true;
            dgvStudySessions.RowHeadersVisible = false;
            dgvStudySessions.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvStudySessions.MultiSelect = false;
            dgvStudySessions.Size = new Size(940, 155);

            // BACK BUTTON
            btnBack.BackColor = Color.FromArgb(23, 54, 93);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 680);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 40);
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;

            // ADD CONTROLS TO FORM
            Controls.Add(pnlHeader);
            Controls.Add(pnlStudyDetails);
            Controls.Add(lblSessionsList);
            Controls.Add(dgvStudySessions);
            Controls.Add(btnBack);

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStudyDetails.ResumeLayout(false);
            pnlStudyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudySessions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureButton(
            Button button, string text, string name,
            Color color, int x, int y)
        {
            button.BackColor = color;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(x, y);
            button.Name = name;
            button.Size = new Size(100, 38);
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblWelcome;

        private Panel pnlStudyDetails;
        private Label lblFormTitle;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblStudyTitle;
        private TextBox txtTitle;
        private Label lblStudyDate;
        private DateTimePicker dtpStudyDate;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblEndTime;
        private DateTimePicker dtpEndTime;
        private Label lblNotes;
        private TextBox txtNotes;
        private Label lblStatus;
        private ComboBox cmbStatus;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Label lblSessionsList;
        private DataGridView dgvStudySessions;
        private Button btnBack;
    }
}
