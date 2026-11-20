namespace AcademicSupportStudyPlanner.Views
{
    partial class RegistrationForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(206, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(579, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Academic Support and Study Planner";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Blue;
            lblSubtitle.Location = new Point(254, 67);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(328, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "\tCreate Student Account";
            lblSubtitle.Click += label2_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Navy;
            lblFullName.Location = new Point(46, 116);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 28);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(46, 157);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(178, 37);
            txtFullName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Navy;
            lblEmail.Location = new Point(46, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(134, 28);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(46, 264);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 37);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Navy;
            lblPassword.Location = new Point(46, 319);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(46, 366);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 37);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.Blue;
            lblConfirmPassword.Location = new Point(46, 429);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 28);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(46, 481);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(202, 37);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Blue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.GhostWhite;
            btnRegister.Location = new Point(46, 535);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 34);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Navy;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.ForeColor = Color.GhostWhite;
            btnBackToLogin.Location = new Point(46, 587);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(167, 34);
            btnBackToLogin.TabIndex = 11;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Lavender;
            btnExit.Location = new Point(241, 587);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(778, 642);
            Controls.Add(btnExit);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnBackToLogin;
        private Button btnExit;
    }
}