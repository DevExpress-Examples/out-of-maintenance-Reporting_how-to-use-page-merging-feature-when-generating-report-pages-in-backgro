<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PageMerging/Form1.cs) (VB: [Form1.vb](./VB/PageMerging/Form1.vb))
<!-- default file list end -->
# How to use page merging feature when generating report pages in background


<p>Generally, you should merge report pages only after the document is created.<br />
So, if you need to update report pages when calling the XtraReport.CreateDocument(true) method (i.e. generating report pages in background), you might need to subscribe to the XtraReport.AfterPrint event to accomplish this task.</p>

<br/>


