namespace SalesWinApp
{
    partial class frmMain
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
            lbFPTStore = new Label();
            btnAccount = new Button();
            btnOrder = new Button();
            btnProduct = new Button();
            SuspendLayout();
            // 
            // lbFPTStore
            // 
            lbFPTStore.AutoSize = true;
            lbFPTStore.Location = new Point(155, 38);
            lbFPTStore.Name = "lbFPTStore";
            lbFPTStore.Size = new Size(56, 15);
            lbFPTStore.TabIndex = 0;
            lbFPTStore.Text = "FPT Store";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(112, 71);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(148, 23);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Account Management";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(112, 116);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(148, 23);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(112, 166);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(148, 23);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Product Management";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 282);
            Controls.Add(btnProduct);
            Controls.Add(btnOrder);
            Controls.Add(btnAccount);
            Controls.Add(lbFPTStore);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFPTStore;
        private Button btnAccount;
        private Button btnOrder;
        private Button btnProduct;
    }
}