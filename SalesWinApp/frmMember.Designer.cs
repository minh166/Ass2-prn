namespace SalesWinApp
{
    partial class frmMember
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
            lbMember = new Label();
            lbMemberID = new Label();
            lbEmail = new Label();
            lbCompany = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            dgvMember = new DataGridView();
            btnAddNew = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new Point(286, 24);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(52, 15);
            lbMember.TabIndex = 0;
            lbMember.Text = "Member";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(34, 68);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(63, 15);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "MemberID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(34, 105);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(34, 143);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(59, 15);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Company";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(334, 68);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(334, 105);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(334, 143);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(114, 65);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(160, 23);
            txtMemberID.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(114, 140);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(160, 23);
            txtCompany.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(402, 65);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(160, 23);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(402, 102);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(160, 23);
            txtCountry.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(402, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 8;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(34, 179);
            dgvMember.Name = "dgvMember";
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(528, 201);
            dgvMember.TabIndex = 13;
            dgvMember.CellContentClick += dgvMember_CellContentClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(34, 403);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 14;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(487, 403);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(173, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(316, 403);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnAddNew);
            Controls.Add(dgvMember);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompany);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Controls.Add(lbMember);
            Name = "frmMember";
            Text = "frmMember";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMember;
        private Label lbMemberID;
        private Label lbEmail;
        private Label lbCompany;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private DataGridView dgvMember;
        private Button btnAddNew;
        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
    }
}