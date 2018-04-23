using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PageMerging {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            MainReport report = new MainReport();
            report.AfterPrint += new EventHandler(report_AfterPrint);
            report.ShowPreview();            
        }

        void report_AfterPrint(object sender, EventArgs e) {
            AdditionalReport add = new AdditionalReport();
            add.CreateDocument();
            ((MainReport)sender).Pages.AddRange(add.Pages);
        }
    }
}