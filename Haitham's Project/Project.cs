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
                            PostalLabel.Text = (string)dt.Rows[0]["Postal"];
                            PhoneLabel.Text = (string)dt.Rows[0]["Phone"];

                            using (DataTable orderdt = new DataTable("Orders"))
                            {
                                using (SqlCommand ordercmd = new SqlCommand("select *,E.FirstName, E.LastName from Orders where CustomerID=@CustomerID inner join Employees on EmployeeID = E.EmployeeID ", cn))
                                {
                                    cmd.Parameters.AddWithValue("CustomerID", customerIDTextBox.Text);
                                    SqlDataAdapter orderadapter = new SqlDataAdapter(ordercmd);
                                    orderadapter.Fill(orderdt);
                                    dataGridView1 = orderdt;
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
    }
}
