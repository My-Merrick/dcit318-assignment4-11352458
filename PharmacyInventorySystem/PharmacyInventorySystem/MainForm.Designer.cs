namespace PharmacyInventorySystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.TextBox txtNewQuantity;
        private System.Windows.Forms.TextBox txtQuantitySold;

        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnRecordSale;
        private System.Windows.Forms.Button btnViewAll;

        private System.Windows.Forms.DataGridView dataGridViewMedicines;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtSearchTerm = new TextBox();
            txtMedicineID = new TextBox();
            txtNewQuantity = new TextBox();
            txtQuantitySold = new TextBox();
            btnAddMedicine = new Button();
            btnSearch = new Button();
            btnUpdateStock = new Button();
            btnRecordSale = new Button();
            btnViewAll = new Button();
            dataGridViewMedicines = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicines).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(124, 84);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(216, 23);
            txtCategory.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(124, 114);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(124, 144);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(216, 23);
            txtQuantity.TabIndex = 3;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(593, 13);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(186, 23);
            txtSearchTerm.TabIndex = 4;
            // 
            // txtMedicineID
            // 
            txtMedicineID.Location = new Point(382, 365);
            txtMedicineID.Name = "txtMedicineID";
            txtMedicineID.Size = new Size(87, 23);
            txtMedicineID.TabIndex = 5;
            txtMedicineID.Text = "1";
            // 
            // txtNewQuantity
            // 
            txtNewQuantity.Location = new Point(94, 420);
            txtNewQuantity.Name = "txtNewQuantity";
            txtNewQuantity.Size = new Size(100, 23);
            txtNewQuantity.TabIndex = 6;
            // 
            // txtQuantitySold
            // 
            txtQuantitySold.Location = new Point(552, 421);
            txtQuantitySold.Name = "txtQuantitySold";
            txtQuantitySold.Size = new Size(100, 23);
            txtQuantitySold.TabIndex = 7;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(128, 181);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(75, 23);
            btnAddMedicine.TabIndex = 8;
            btnAddMedicine.Text = "Add Medicine";
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(785, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(209, 420);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(122, 23);
            btnUpdateStock.TabIndex = 10;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnRecordSale
            // 
            btnRecordSale.Location = new Point(674, 425);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(75, 23);
            btnRecordSale.TabIndex = 11;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(867, 13);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(83, 23);
            btnViewAll.TabIndex = 12;
            btnViewAll.Text = "View All";
            btnViewAll.Click += btnViewAll_Click;
            // 
            // dataGridViewMedicines
            // 
            dataGridViewMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicines.Location = new Point(489, 56);
            dataGridViewMedicines.Name = "dataGridViewMedicines";
            dataGridViewMedicines.Size = new Size(461, 288);
            dataGridViewMedicines.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 56);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 14;
            label1.Text = "Enter Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 15;
            label2.Text = "Enter Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 16;
            label3.Text = "Enter Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 148);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 17;
            label4.Text = "Enter Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 17);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 18;
            label5.Text = "Enter Drug Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 373);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 19;
            label6.Text = "Enter Med ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 420);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 20;
            label7.Text = "Enter New Qty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 429);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 21;
            label8.Text = "Enter Qty Sold";
            // 
            // MainForm
            // 
            ClientSize = new Size(991, 600);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtSearchTerm);
            Controls.Add(txtMedicineID);
            Controls.Add(txtNewQuantity);
            Controls.Add(txtQuantitySold);
            Controls.Add(btnAddMedicine);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnRecordSale);
            Controls.Add(btnViewAll);
            Controls.Add(dataGridViewMedicines);
            Name = "MainForm";
            Text = "Pharmacy Inventory System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
