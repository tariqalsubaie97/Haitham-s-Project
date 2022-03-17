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
        public Form2(string companyname, string contactname, string contacttitle, string country, string postal, string phone, object datasource)
        {  
           
            InitializeComponent();
            var report = new Report1();
            report.CompanyName.Value = companyname;
            report.ContactName.Value = contactname;
            report.ContactTitle.Value = contacttitle;
            report.Country.Value = country;
            report.PostalCode.Value = postal;
            report.Phone.Value = phone;
            var table = report.Items.Find("OrderTable", true)[0] as Telerik.Reporting.Table;
            table. = datasource;
            
            reportViewer1.Report = report;
            reportViewer1.RefreshReport();
           
            // reportViewer1.DataBindings. = Project.companyname;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        { 

        }
    }
}
