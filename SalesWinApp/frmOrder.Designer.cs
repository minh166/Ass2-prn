namespace SalesWinApp
{
    partial class frmOrder
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
            lbOrder = new Label();
            lbOrderID = new Label();
            lbMemberID = new Label();
            lbFreight = new Label();
            lbOrderDate = new Label();
            lbRequiredDate = new Label();
            lbShippedDate = new Label();
            txtOrderID = new TextBox();
            txtMemberID = new TextBox();
            txtFreight = new TextBox();
            dateOrder = new DateTimePicker();
            dateRequired = new DateTimePicker();
            dateShipped = new DateTimePicker();
            dgvOrder = new DataGridView();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lbStartDate = new Label();
            lbEndDate = new Label();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            btnStatistics = new Button();
            btnReset = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Location = new Point(287, 23);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(37, 15);
            lbOrder.TabIndex = 0;
            lbOrder.Text = "Order";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(25, 68);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(51, 15);
            lbOrderID.TabIndex = 1;
            lbOrderID.Text = "Order ID";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(25, 105);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(66, 15);
            lbMemberID.TabIndex = 2;
            lbMemberID.Text = "Member ID";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(25, 143);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(44, 15);
            lbFreight.TabIndex = 3;
            lbFreight.Text = "Freight";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(305, 71);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(64, 15);
            lbOrderDate.TabIndex = 4;
            lbOrderDate.Text = "Order Date";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(305, 108);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(81, 15);
            lbRequiredDate.TabIndex = 5;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(305, 146);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(77, 15);
            lbShippedDate.TabIndex = 6;
            lbShippedDate.Text = "Shipped Date";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(106, 65);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(151, 23);
            txtOrderID.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(106, 102);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(151, 23);
            txtMemberID.TabIndex = 8;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(106, 140);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(151, 23);
            txtFreight.TabIndex = 9;
            // 
            // dateOrder
            // 
            dateOrder.Location = new Point(393, 65);
            dateOrder.Name = "dateOrder";
            dateOrder.Size = new Size(200, 23);
            dateOrder.TabIndex = 10;
            // 
            // dateRequired
            // 
            dateRequired.Location = new Point(393, 105);
            dateRequired.Name = "dateRequired";
            dateRequired.Size = new Size(200, 23);
            dateRequired.TabIndex = 11;
            // 
            // dateShipped
            // 
            dateShipped.Location = new Point(393, 143);
            dateShipped.Name = "dateShipped";
            dateShipped.Size = new Size(200, 23);
            dateShipped.TabIndex = 12;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(25, 183);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowTemplate.Height = 25;
            dgvOrder.Size = new Size(568, 150);
            dgvOrder.TabIndex = 13;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(96, 354);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 14;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(272, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(436, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(25, 408);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(58, 15);
            lbStartDate.TabIndex = 17;
            lbStartDate.Text = "Start Date";
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(305, 408);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(54, 15);
            lbEndDate.TabIndex = 18;
            lbEndDate.Text = "End Date";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(106, 405);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(151, 23);
            txtStartDate.TabIndex = 19;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(393, 405);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(200, 23);
            txtEndDate.TabIndex = 20;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(96, 460);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(75, 23);
            btnStatistics.TabIndex = 21;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(272, 460);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(436, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 494);
            Controls.Add(lbEndDate);
            Controls.Add(lbStartDate);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(btnStatistics);
            Controls.Add(btnAddNew);
            Controls.Add(dgvOrder);
            Controls.Add(dateShipped);
            Controls.Add(dateRequired);
            Controls.Add(dateOrder);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbFreight);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Controls.Add(lbOrder);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrder;
        private Label lbOrderID;
        private Label lbMemberID;
        private Label lbFreight;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private TextBox txtOrderID;
        private TextBox txtMemberID;
        private TextBox txtFreight;
        private DateTimePicker dateOrder;
        private DateTimePicker dateRequired;
        private DateTimePicker dateShipped;
        private DataGridView dgvOrder;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lbStartDate;
        private Label lbEndDate;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private Button btnStatistics;
        private Button btnReset;
        private Button btnBack;
    }
}