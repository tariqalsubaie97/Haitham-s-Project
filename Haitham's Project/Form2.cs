using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haitham_s_Project
{
    public partial class Form2 : Form
    {
        public Form2(string companyname, string contactname, string contacttitle, string country, string postal, string phone)
        {
            InitializeComponent();
            var report = new Report1();
            report.ReportParameters[0].Value = companyname;
            report.ReportParameters[1].Value = contactname;
            report.ReportParameters[2].Value = contacttitle;
            report.ReportParameters[3].Value = country;
            report.ReportParameters[4].Value = postal;
            report.ReportParameters[5].Value = phone;
            // reportViewer1.DataBindings. = Project.companyname;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
