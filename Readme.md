<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603978/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [AdditionalReport.cs](./CS/PageMerging/AdditionalReport.cs) (VB: [AdditionalReport.vb](./VB/PageMerging/AdditionalReport.vb))
* [Form1.cs](./CS/PageMerging/Form1.cs) (VB: [Form1.vb](./VB/PageMerging/Form1.vb))
* [MainReport.cs](./CS/PageMerging/MainReport.cs) (VB: [MainReport.vb](./VB/PageMerging/MainReport.vb))
* [Program.cs](./CS/PageMerging/Program.cs) (VB: [Program.vb](./VB/PageMerging/Program.vb))
<!-- default file list end -->
# How to use page merging feature when generating report pages in background


<p>Generally, you should merge report pages only after the document is created.<br />
So, if you need to update report pages when calling the XtraReport.CreateDocument(true) method (i.e. generating report pages in background), you might need to subscribe to the XtraReport.AfterPrint event to accomplish this task.</p>

<br/>


