using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;

namespace Haitham_s_Project
{
    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    public partial class Report1 : Telerik.Reporting.Report
    {
        public Report1()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

           // Form1 f1 = new Form1();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void CompanyName_ItemDataBinding(object sender, EventArgs e)
        {

        }

        private void textBox10_ItemDataBound(object sender, EventArgs e)
        {

        }

        private void table1_NeedDataSource(object sender, EventArgs e)
        {
          
        }

        private void table1_ItemDataBinding(object sender, EventArgs e)
        {

        }
    }
    }
