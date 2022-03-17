using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haitham_s_Project
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Customers"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from Customers where CustomerID=@CustomerID", cn))
                        {
                            cmd.Parameters.AddWithValue("CustomerID", customerIDTextBox.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            CompanyNameLabel.Text = (string)dt.Rows[0]["CompanyName"];
                            ContactLabel.Text = (string)dt.Rows[0]["ContactName"];
                            ContactTitleLabel.Text = (string)dt.Rows[0]["ContactTitle"];
                            CountryLbl.Text = (string)dt.Rows[0]["Country"];
                            PostalLabel.Text = (string)dt.Rows[0]["PostalCode"];
                            PhoneLabel.Text = (string)dt.Rows[0]["Phone"];

                            using (DataTable orderdt = new DataTable("Orders"))
                            {
                                using (SqlCommand ordercmd = new SqlCommand("select O.OrderID,E.FirstName as [Employee First Name], E.LastName as [Employee Last Name],  P.ProductName, OrderDate,ShippedDate,S.CompanyName " +
                                    "as ShipVia,ShipCountry from Orders as O inner join Employees as E on O.EmployeeID = E.EmployeeID " +
                                    "inner join [Order Details] as OD on O.OrderID = OD.OrderID inner join Products as P on OD.ProductID= P.ProductID " +
                                    "inner join Shippers as S on O.ShipVia=S.ShipperID  where O.CustomerID=@CustomerID", cn))
                                {
                                    ordercmd.Parameters.AddWithValue("CustomerID", customerIDTextBox.Text);
                                    SqlDataAdapter orderadapter = new SqlDataAdapter(ordercmd);
                                    orderadapter.Fill(orderdt);
                                    dataGridView1.DataSource = orderdt;
                                    // List<string> orders = new List<string>();

                                }
                            }



                            // dataGridView.DataSource = dt;
                            //lblTotal.Text = $"Total records: {dataGridView.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (PrintAccountsCheck.Checked)
            {
                string companyname = CompanyNameLabel.Text;
                string contactname = ContactLabel.Text;
                string contacttitle = ContactTitleLabel.Text;
                string country = CountryLbl.Text;
                string postal = PostalLabel.Text;
                string phone = PhoneLabel.Text;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

            }
        }
    }
}
