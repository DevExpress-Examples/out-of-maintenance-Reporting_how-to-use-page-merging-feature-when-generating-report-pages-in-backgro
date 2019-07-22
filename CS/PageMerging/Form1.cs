using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace PageMerging {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport mainReport = CreateMainReport();                       
            mainReport.ShowPreview();
        }

        private void MainReport_AfterPrint(object sender, EventArgs e) {
            XtraReport additionalReport = CreateAdditionalReport();
            (sender as XtraReport).ModifyDocument(x => { x.AddPages(additionalReport.Pages); });
        }

        private XtraReport CreateMainReport() {
            MainReport mainReport = new MainReport();
            mainReport.AfterPrint += MainReport_AfterPrint;
            mainReport.CreateDocument();
            return mainReport;
        }

        private XtraReport CreateAdditionalReport() {
            AdditionalReport add = new AdditionalReport();
            add.CreateDocument();
            return add;
        }        
    }
}