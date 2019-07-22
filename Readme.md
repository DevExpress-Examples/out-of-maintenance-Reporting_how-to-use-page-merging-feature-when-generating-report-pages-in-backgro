<!-- default file list -->
*Files to look at*:

* [AdditionalReport.cs](./CS/PageMerging/AdditionalReport.cs) (VB: [AdditionalReport.vb](./VB/PageMerging/AdditionalReport.vb))
* [Form1.cs](./CS/PageMerging/Form1.cs) (VB: [Form1.vb](./VB/PageMerging/Form1.vb))
* [MainReport.cs](./CS/PageMerging/MainReport.cs) (VB: [MainReport.vb](./VB/PageMerging/MainReport.vb))
* [Program.cs](./CS/PageMerging/Program.cs) (VB: [Program.vb](./VB/PageMerging/Program.vb))
<!-- default file list end -->
# How to merge additional pages to a base report when it is being generated

<p>You might need to add additional pages to your main report when it is being generated and its pages are accessed as soon as they are created. To do so, handle the base report's <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.AfterPrint">XRControl.AfterPrint</a> event and use the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ModifyDocument(System.Action-DevExpress.XtraReports.IDocumentModifier-)">XtraReport.ModifyDocument</a> method to add additional pages. Please do not forget to call the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.CreateDocument(System.Boolean)">CreateDocument</a> method for the additional report. </p></br><p>Please refer to the following documentation topics for more information:</br>
-<a href="https://docs.devexpress.com/XtraReports/3320/detailed-guide-to-devexpress-reporting/merge-reports">Merge Reports</a></br>
-<a href="https://docs.devexpress.com/XtraReports/3321/Detailed-Guide-to-DevExpress-Reporting/Merge-Reports/Merge-Reports-Specify-Page-Sequence-Manually">Merge Reports: Specify Page Sequence Manually</a>

<br/>


