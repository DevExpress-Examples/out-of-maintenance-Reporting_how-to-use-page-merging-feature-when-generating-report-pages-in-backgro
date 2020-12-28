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
			Dim ds As New DataSet1()
			Dim rnd As New Random(DateTime.Now.Millisecond)
			For i As Integer = 0 To 49
				Dim OrderID As Integer = rnd.Next(100)
				Dim ProductID As Integer = rnd.Next(50)
				If ds.Order_Details.FindByOrderIDProductID(OrderID, ProductID) Is Nothing Then
					ds.Order_Details.AddOrder_DetailsRow(OrderID, ProductID, CDec(Math.Round(rnd.NextDouble()*50, 2)), 5, 0.0F)
				End If
			Next i
			report.DataSource = ds
			AddHandler report.AfterPrint, AddressOf report_AfterPrint
			report.ShowPreview()
		End Sub

		Private Sub report_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
			Dim add As New AdditionalReport()
			add.CreateDocument()
			DirectCast(sender, MainReport).Pages.AddRange(add.Pages)
		End Sub
	End Class
End Namespace