namespace AcademicSupportStudyPlanner.Views
{
    partial class AssignmentForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlAssignmentDetails = new Panel();
            lblFormTitle = new Label();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblAssignmentTitle = new Label();
            txtAssignmentTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblAssignmentsList = new Label();
            dgvAssignments = new DataGridView();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlAssignmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 54, 93);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 105);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(509, 54);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Assignment Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(35, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(326, 28);
            lblSubtitle.TabIndex = 5;
            lblSubtitle.Text = "Track and manage your assignments";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(750, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(85, 25);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome";
            // 
            // pnlAssignmentDetails
            // 
            pnlAssignmentDetails.BackColor = Color.White;
            pnlAssignmentDetails.Controls.Add(btnClear);
            pnlAssignmentDetails.Controls.Add(btnDelete);
            pnlAssignmentDetails.Controls.Add(btnUpdate);
            pnlAssignmentDetails.Controls.Add(btnAdd);
            pnlAssignmentDetails.Controls.Add(cmbStatus);
            pnlAssignmentDetails.Controls.Add(lblStatus);
            pnlAssignmentDetails.Controls.Add(dtpDueDate);
            pnlAssignmentDetails.Controls.Add(lblDueDate);
            pnlAssignmentDetails.Controls.Add(txtDescription);
            pnlAssignmentDetails.Controls.Add(lblDescription);
            pnlAssignmentDetails.Controls.Add(txtAssignmentTitle);
            pnlAssignmentDetails.Controls.Add(lblAssignmentTitle);
            pnlAssignmentDetails.Controls.Add(cmbSubject);
            pnlAssignmentDetails.Controls.Add(lblSubject);
            pnlAssignmentDetails.Controls.Add(lblFormTitle);
            pnlAssignmentDetails.Location = new Point(30, 125);
            pnlAssignmentDetails.Name = "pnlAssignmentDetails";
            pnlAssignmentDetails.Size = new Size(940, 260);
            pnlAssignmentDetails.TabIndex = 4;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(20, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(164, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Assignment Details";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(25, 55);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(70, 25);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(25, 80);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(450, 33);
            cmbSubject.TabIndex = 2;
            // 
            // lblAssignmentTitle
            // 
            lblAssignmentTitle.AutoSize = true;
            lblAssignmentTitle.Location = new Point(512, 52);
            lblAssignmentTitle.Name = "lblAssignmentTitle";
            lblAssignmentTitle.Size = new Size(143, 25);
            lblAssignmentTitle.TabIndex = 3;
            lblAssignmentTitle.Text = "Assignment Title";
            // 
            // txtAssignmentTitle
            // 
            txtAssignmentTitle.Location = new Point(512, 80);
            txtAssignmentTitle.Name = "txtAssignmentTitle";
            txtAssignmentTitle.ScrollBars = ScrollBars.Vertical;
            txtAssignmentTitle.Size = new Size(150, 31);
            txtAssignmentTitle.TabIndex = 4;
            txtAssignmentTitle.TextChanged += txtAssignmentTitle_TextChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(25, 125);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(25, 150);
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(450, 31);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(500, 125);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(86, 25);
            lblDueDate.TabIndex = 7;
            lblDueDate.Text = "Due Date";
            lblDueDate.Click += lblDueDate_Click;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(491, 153);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(211, 31);
            dtpDueDate.TabIndex = 8;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(720, 122);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(708, 148);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(185, 33);
            cmbStatus.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GhostWhite;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(49, 205);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 38);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(235, 205);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 38);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(474, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 38);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Gray;
            btnClear.Location = new Point(746, 204);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 38);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblAssignmentsList
            // 
            lblAssignmentsList.AutoSize = true;
            lblAssignmentsList.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssignmentsList.ForeColor = Color.Navy;
            lblAssignmentsList.Location = new Point(30, 400);
            lblAssignmentsList.Name = "lblAssignmentsList";
            lblAssignmentsList.RightToLeft = RightToLeft.No;
            lblAssignmentsList.Size = new Size(251, 38);
            lblAssignmentsList.TabIndex = 5;
            lblAssignmentsList.Text = "Your Assignments";
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Location = new Point(30, 440);
            dgvAssignments.MultiSelect = false;
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.RowHeadersWidth = 62;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(940, 190);
            dgvAssignments.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Navy;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 650);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(273, 34);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // AssignmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1021, 729);
            Controls.Add(btnBack);
            Controls.Add(dgvAssignments);
            Controls.Add(lblAssignmentsList);
            Controls.Add(pnlAssignmentDetails);
            Controls.Add(pnlHeader);
            Name = "AssignmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assignment Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAssignmentDetails.ResumeLayout(false);
            pnlAssignmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHeader;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel pnlAssignmentDetails;
        private Label lblSubject;
        private Label lblFormTitle;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtAssignmentTitle;
        private Label lblAssignmentTitle;
        private ComboBox cmbSubject;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private DateTimePicker dtpDueDate;
        private Label lblDueDate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblAssignmentsList;
        private DataGridView dgvAssignments;
        private Button btnBack;
    }
}