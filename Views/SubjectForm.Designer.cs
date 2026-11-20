namespace AcademicSupportStudyPlanner.Views
{
    partial class SubjectForm
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
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlSubjectDetails = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            txtSubjectCode = new TextBox();
            txtSubjectName = new TextBox();
            lblDescription = new Label();
            lblSubjectCode = new Label();
            lblSubjectName = new Label();
            lblFormTitle = new Label();
            lblSubjectsList = new Label();
            dgvSubjects = new DataGridView();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlSubjectDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
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
            pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(750, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(108, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(102, 63);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(411, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Organize and manage your academic subjects";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(88, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(425, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Subject Management";
            // 
            // pnlSubjectDetails
            // 
            pnlSubjectDetails.BackColor = Color.White;
            pnlSubjectDetails.Controls.Add(btnClear);
            pnlSubjectDetails.Controls.Add(btnDelete);
            pnlSubjectDetails.Controls.Add(btnUpdate);
            pnlSubjectDetails.Controls.Add(btnAdd);
            pnlSubjectDetails.Controls.Add(txtDescription);
            pnlSubjectDetails.Controls.Add(txtSubjectCode);
            pnlSubjectDetails.Controls.Add(txtSubjectName);
            pnlSubjectDetails.Controls.Add(lblDescription);
            pnlSubjectDetails.Controls.Add(lblSubjectCode);
            pnlSubjectDetails.Controls.Add(lblSubjectName);
            pnlSubjectDetails.Controls.Add(lblFormTitle);
            pnlSubjectDetails.Location = new Point(30, 111);
            pnlSubjectDetails.Name = "pnlSubjectDetails";
            pnlSubjectDetails.Size = new Size(945, 264);
            pnlSubjectDetails.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(605, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 38);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(495, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(385, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 38);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(275, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(25, 145);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(860, 42);
            txtDescription.TabIndex = 8;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Location = new Point(475, 80);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(410, 31);
            txtSubjectCode.TabIndex = 7;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(25, 80);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(410, 31);
            txtSubjectName.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(25, 120);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblSubjectCode
            // 
            lblSubjectCode.AutoSize = true;
            lblSubjectCode.Location = new Point(475, 55);
            lblSubjectCode.Name = "lblSubjectCode";
            lblSubjectCode.Size = new Size(117, 25);
            lblSubjectCode.TabIndex = 4;
            lblSubjectCode.Text = "Subject Code";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(25, 55);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.RightToLeft = RightToLeft.No;
            lblSubjectName.Size = new Size(122, 25);
            lblSubjectName.TabIndex = 3;
            lblSubjectName.Text = "Subject Name";
            lblSubjectName.Click += lblSubjectName_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.Navy;
            lblFormTitle.Location = new Point(20, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(183, 32);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "\tSubject Details";
            // 
            // lblSubjectsList
            // 
            lblSubjectsList.AutoSize = true;
            lblSubjectsList.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjectsList.ForeColor = Color.Navy;
            lblSubjectsList.Location = new Point(30, 390);
            lblSubjectsList.Name = "lblSubjectsList";
            lblSubjectsList.Size = new Size(152, 30);
            lblSubjectsList.TabIndex = 2;
            lblSubjectsList.Text = "Your Subjects";
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.BackgroundColor = Color.White;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(30, 430);
            dgvSubjects.MultiSelect = false;
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.RowHeadersVisible = false;
            dgvSubjects.RowHeadersWidth = 62;
            dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubjects.Size = new Size(940, 200);
            dgvSubjects.TabIndex = 3;
            dgvSubjects.CellContentClick += dgvSubjects_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Navy;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 650);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "\tBack to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1048, 705);
            Controls.Add(btnBack);
            Controls.Add(dgvSubjects);
            Controls.Add(lblSubjectsList);
            Controls.Add(pnlSubjectDetails);
            Controls.Add(pnlHeader);
            Cursor = Cursors.Hand;
            Name = "SubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSubjectDetails.ResumeLayout(false);
            pnlSubjectDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblWelcome;
        private Panel pnlSubjectDetails;
        private Label lblFormTitle;
        private TextBox txtDescription;
        private TextBox txtSubjectCode;
        private TextBox txtSubjectName;
        private Label lblDescription;
        private Label lblSubjectCode;
        private Label lblSubjectName;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Label lblSubjectsList;
        private DataGridView dgvSubjects;
        private Button btnBack;
    }
}