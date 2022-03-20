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
        public Form2(string companyname, string contactname, string contacttitle, string country, string postal, string phone, string custid, object data)
        {
            InitializeComponent();
            Report1 report = new Report1();
            if (companyname == "alfki" || companyname == "ALFKI")
            {
                report.CompanyName.Value = companyname;
                report.ContactName.Value = "*********";
                report.ContactTitle.Value = contacttitle;
                report.Country.Value = country;
                report.PostalCode.Value = "***********";
                report.Phone.Value = "************";
                report.ReportParameters["CustomerID"].Value = custid;
                report.DataSource = data;
                report.ReportParameters["ObjectDS"].Value = data;
                reportViewer1.Report = report;

            }
            report.CompanyName.Value = companyname;
            report.ContactName.Value = contactname;
            report.ContactTitle.Value = contacttitle;
            report.Country.Value = country;
            report.PostalCode.Value = postal;
            report.Phone.Value = phone;
            report.ReportParameters["CustomerID"].Value = custid;
            report.DataSource = data;
            report.ReportParameters["ObjectDS"].Value = data;
            reportViewer1.Report = report;
            reportViewer1.RefreshReport();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
