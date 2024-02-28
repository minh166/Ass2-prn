namespace SalesWinApp
{
    partial class frmProduct
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
            lbProductID = new Label();
            lbCategoryID = new Label();
            txtProductID = new TextBox();
            lbUnitPrice = new Label();
            lbProductName = new Label();
            txtProductName = new TextBox();
            lbUnitSlnStock = new Label();
            lbWeight = new Label();
            txtCategoryId = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtStock = new TextBox();
            dgvProduct = new DataGridView();
            btnAddNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            btnBack = new Button();
            lbSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(34, 54);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(63, 15);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(34, 96);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(69, 15);
            lbCategoryID.TabIndex = 2;
            lbCategoryID.Text = "Category ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(120, 51);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(137, 23);
            txtProductID.TabIndex = 1;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(34, 140);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(330, 54);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(84, 15);
            lbProductName.TabIndex = 4;
            lbProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(432, 51);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(137, 23);
            txtProductName.TabIndex = 9;
            // 
            // lbUnitSlnStock
            // 
            lbUnitSlnStock.AutoSize = true;
            lbUnitSlnStock.Location = new Point(330, 96);
            lbUnitSlnStock.Name = "lbUnitSlnStock";
            lbUnitSlnStock.Size = new Size(80, 15);
            lbUnitSlnStock.TabIndex = 5;
            lbUnitSlnStock.Text = "Unit Sln Stock";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(330, 140);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(45, 15);
            lbWeight.TabIndex = 6;
            lbWeight.Text = "Weight";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(120, 93);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(137, 23);
            txtCategoryId.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(120, 137);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(137, 23);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(432, 137);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(137, 23);
            txtWeight.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(432, 93);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(137, 23);
            txtStock.TabIndex = 11;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(34, 183);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(535, 150);
            dgvProduct.TabIndex = 12;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(59, 363);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 13;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(452, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(265, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(82, 407);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(487, 23);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(70, 447);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(463, 447);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(276, 447);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(34, 410);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 20;
            lbSearch.Text = "Search";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 494);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAddNew);
            Controls.Add(dgvProduct);
            Controls.Add(txtStock);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategoryId);
            Controls.Add(txtProductID);
            Controls.Add(lbCategoryID);
            Controls.Add(lbWeight);
            Controls.Add(lbUnitSlnStock);
            Controls.Add(lbProductName);
            Controls.Add(lbSearch);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductID);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductID;
        private Label lbCategoryID;
        private TextBox txtProductID;
        private Label lbUnitPrice;
        private Label lbProductName;
        private TextBox txtProductName;
        private Label lbUnitSlnStock;
        private Label lbWeight;
        private TextBox txtCategoryId;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtStock;
        private DataGridView dgvProduct;
        private Button btnAddNew;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnReset;
        private Button btnBack;
        private Label lbSearch;
    }
}