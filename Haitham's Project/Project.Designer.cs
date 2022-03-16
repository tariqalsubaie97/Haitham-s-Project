
namespace Haitham_s_Project
{
    partial class Project
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
            this.components = new System.ComponentModel.Container();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Haitham_s_Project.NorthwindDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PostalLabel = new System.Windows.Forms.Label();
            this.ContactTitleLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintAccountsCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Haitham_s_Project.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Haitham_s_Project.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipped_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ship_Via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ship_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(293, 42);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(164, 26);
            this.customerIDTextBox.TabIndex = 42;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID,
            this.Employee_First_Name,
            this.Employee_Last_Name,
            this.Order_Date,
            this.Shipped_Date,
            this.Ship_Via,
            this.Ship_Country});
            this.dataGridView1.Location = new System.Drawing.Point(91, 337);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(607, 367);
            this.dataGridView1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(91, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Orders:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PhoneLabel.Location = new System.Drawing.Point(492, 232);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(0, 25);
            this.PhoneLabel.TabIndex = 39;
            // 
            // PostalLabel
            // 
            this.PostalLabel.AutoSize = true;
            this.PostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PostalLabel.Location = new System.Drawing.Point(542, 171);
            this.PostalLabel.Name = "PostalLabel";
            this.PostalLabel.Size = new System.Drawing.Size(0, 25);
            this.PostalLabel.TabIndex = 38;
            // 
            // ContactTitleLabel
            // 
            this.ContactTitleLabel.AutoSize = true;
            this.ContactTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContactTitleLabel.Location = new System.Drawing.Point(225, 232);
            this.ContactTitleLabel.Name = "ContactTitleLabel";
            this.ContactTitleLabel.Size = new System.Drawing.Size(0, 25);
            this.ContactTitleLabel.TabIndex = 37;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContactLabel.Location = new System.Drawing.Point(237, 171);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(0, 25);
            this.ContactLabel.TabIndex = 36;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CompanyNameLabel.Location = new System.Drawing.Point(266, 119);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(0, 25);
            this.CompanyNameLabel.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(414, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(414, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Postal Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(414, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Country:";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CountryLbl.Location = new System.Drawing.Point(505, 119);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(0, 25);
            this.CountryLbl.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(91, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Contact Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(91, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(91, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Company Name:";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(510, 777);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(204, 28);
            this.PrintButton.TabIndex = 27;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // PrintAccountsCheck
            // 
            this.PrintAccountsCheck.AutoSize = true;
            this.PrintAccountsCheck.Location = new System.Drawing.Point(692, 746);
            this.PrintAccountsCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintAccountsCheck.Name = "PrintAccountsCheck";
            this.PrintAccountsCheck.Size = new System.Drawing.Size(22, 21);
            this.PrintAccountsCheck.TabIndex = 26;
            this.PrintAccountsCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(507, 741);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Print Only Orders";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(478, 39);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(101, 27);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.IDLabel.Location = new System.Drawing.Point(190, 42);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(97, 25);
            this.IDLabel.TabIndex = 23;
            this.IDLabel.Text = "Enter ID:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Haitham_s_Project.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.MinimumWidth = 8;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            this.Order_ID.Width = 150;
            // 
            // Employee_First_Name
            // 
            this.Employee_First_Name.HeaderText = "Employee First Name";
            this.Employee_First_Name.MinimumWidth = 8;
            this.Employee_First_Name.Name = "Employee_First_Name";
            this.Employee_First_Name.ReadOnly = true;
            this.Employee_First_Name.Width = 150;
            // 
            // Employee_Last_Name
            // 
            this.Employee_Last_Name.HeaderText = "Employee Last Name";
            this.Employee_Last_Name.MinimumWidth = 8;
            this.Employee_Last_Name.Name = "Employee_Last_Name";
            this.Employee_Last_Name.ReadOnly = true;
            this.Employee_Last_Name.Width = 150;
            // 
            // Order_Date
            // 
            this.Order_Date.HeaderText = "Order Date";
            this.Order_Date.MinimumWidth = 8;
            this.Order_Date.Name = "Order_Date";
            this.Order_Date.ReadOnly = true;
            this.Order_Date.Width = 150;
            // 
            // Shipped_Date
            // 
            this.Shipped_Date.HeaderText = "Shipped Date";
            this.Shipped_Date.MinimumWidth = 8;
            this.Shipped_Date.Name = "Shipped_Date";
            this.Shipped_Date.ReadOnly = true;
            this.Shipped_Date.Width = 150;
            // 
            // Ship_Via
            // 
            this.Ship_Via.HeaderText = "Ship Via";
            this.Ship_Via.MinimumWidth = 8;
            this.Ship_Via.Name = "Ship_Via";
            this.Ship_Via.ReadOnly = true;
            this.Ship_Via.Width = 150;
            // 
            // Ship_Country
            // 
            this.Ship_Country.HeaderText = "Ship Country";
            this.Ship_Country.MinimumWidth = 8;
            this.Ship_Country.Name = "Ship_Country";
            this.Ship_Country.ReadOnly = true;
            this.Ship_Country.Width = 150;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 844);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PostalLabel);
            this.Controls.Add(this.ContactTitleLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PrintAccountsCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IDLabel);
            this.Name = "Project";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label PostalLabel;
        private System.Windows.Forms.Label ContactTitleLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.CheckBox PrintAccountsCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipped_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ship_Via;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ship_Country;
    }
}