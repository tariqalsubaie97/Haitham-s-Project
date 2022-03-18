using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haitham_s_Project
{
    public partial class Form2 : Form
    {
        public Form2(string companyname, string contactname, string contacttitle, string country, string postal, string phone, string custid)
        {  
           
            InitializeComponent();
            Report1 report = new Report1();
            report.CompanyName.Value = companyname;
            report.ContactName.Value = contactname;
            report.ContactTitle.Value = contacttitle;
            report.Country.Value = country;
            report.PostalCode.Value = postal;
            report.Phone.Value = phone;
            report.ReportParameters["CustomerID"].Value = custid;
            reportViewer1.Report = report;
            reportViewer1.RefreshReport();
           
            // reportViewer1.DataBindings. = Project.companyname;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        { 

        }
    }
}
