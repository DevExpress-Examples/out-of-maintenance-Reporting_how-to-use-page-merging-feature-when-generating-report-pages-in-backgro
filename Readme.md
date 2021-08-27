<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PageMerging/Form1.cs) (VB: [Form1.vb](./VB/PageMerging/Form1.vb))
<!-- default file list end -->
# How to use page merging feature when generating report pages in background


<p>Generally, you should merge report pages only after the document is created.<br />
So, if you need to update report pages when calling the XtraReport.CreateDocument(true) method (i.e. generating report pages in background), you might need to subscribe to the XtraReport.AfterPrint event to accomplish this task.</p>

<br/>


