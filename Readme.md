<!-- default file list -->
*Files to look at*:

* [AdditionalReport.cs](./CS/PageMerging/AdditionalReport.cs) (VB: [AdditionalReport.vb](./VB/PageMerging/AdditionalReport.vb))
* [Form1.cs](./CS/PageMerging/Form1.cs) (VB: [Form1.vb](./VB/PageMerging/Form1.vb))
* [MainReport.cs](./CS/PageMerging/MainReport.cs) (VB: [MainReport.vb](./VB/PageMerging/MainReport.vb))
* [Program.cs](./CS/PageMerging/Program.cs) (VB: [Program.vb](./VB/PageMerging/Program.vb))
<!-- default file list end -->
# How to merge additional pages to a base report when it is being generated

<p>You might need to add additional pages to your main report when it is being generated and its pages are accessed as soon as they are created. To do so, handle the base report's <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.AfterPrint">XRControl.AfterPrint</a> event and use the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ModifyDocument(System.Action-DevExpress.XtraReports.IDocumentModifier-)">XtraReport.ModifyDocument</a> method. Do not forget to call the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.CreateDocument(System.Boolean)">CreateDocument</a> method for an additional report. </p></br><p>Please refer to the following documentation topics for more information:</br>
-<a href="https://docs.devexpress.com/XtraReports/3320/detailed-guide-to-devexpress-reporting/merge-reports">Merge Reports</a></br>
-<a href="https://docs.devexpress.com/XtraReports/3321/Detailed-Guide-to-DevExpress-Reporting/Merge-Reports/Merge-Reports-Specify-Page-Sequence-Manually">Merge Reports: Specify Page Sequence Manually</a></p></br>

<p>Note that in version 19.1, it became easier to merge reports using the XRSubreport control. Now it is no longer required to write a line of code to merge a subreport into a main report. Enable our new <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.SubreportBase.GenerateOwnPages">XRSubreport.GenerateOwnPages</a> option to print/export a sub-report across individual pages and retain page settings and orientation. See:</br>
- <a href="https://community.devexpress.com/blogs/reporting/archive/2019/05/02/reporting-merge-reports-in-report-designer-v19-1.aspx">Blogpost: Reporting - Merge Reports in Report Designer (v19.1)</a></br>
- <a href="https://docs.devexpress.com/XtraReports/400691/detailed-guide-to-devexpress-reporting/merge-reports/merge-reports-use-data-driven-page-sequence">Documentation: Merge Reports: Use Data-Driven Page Sequence</a>
</p>

