Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace PageMerging
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim report As New MainReport()
            AddHandler report.AfterPrint, AddressOf report_AfterPrint
			report.ShowPreview()
		End Sub

		Private Sub report_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
			Dim add As New AdditionalReport()
			add.CreateDocument()
            CType(sender, MainReport).ModifyDocument(
                Sub(x)
                    x.AddPages(add.Pages)
                End Sub)
        End Sub
	End Class
End Namespace