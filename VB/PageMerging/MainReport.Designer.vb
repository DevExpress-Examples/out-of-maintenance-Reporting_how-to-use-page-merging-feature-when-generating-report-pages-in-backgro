Imports Microsoft.VisualBasic
Imports System
Namespace PageMerging
	Partial Public Class MainReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4, Me.xrLabel3, Me.xrLabel2})
            Me.Detail.HeightF = 38.0!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel4
            '
            Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrLabel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 0!)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.Text = "xrLabel4"
            '
            'xrLabel3
            '
            Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
            Me.xrLabel3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0!)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(175.0!, 25.0!)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.Text = "xrLabel3"
            '
            'xrLabel2
            '
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductID]")})
            Me.xrLabel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(167.0!, 0!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "xrLabel2"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 25.0!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'xrLabel1
            '
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
            Me.xrLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "xrLabel1"
            '
            'ReportFooter
            '
            Me.ReportFooter.HeightF = 0!
            Me.ReportFooter.Name = "ReportFooter"
            Me.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            '
            'topMarginBand1
            '
            Me.topMarginBand1.Name = "topMarginBand1"
            '
            'bottomMarginBand1
            '
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            '
            'SqlDataSource1
            '
            Me.SqlDataSource1.ConnectionName = "PageMerging.Properties.Settings.nwindConnectionString"
            Me.SqlDataSource1.Name = "SqlDataSource1"
            ColumnExpression1.ColumnName = "OrderID"
            Table1.Name = "Order Details"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "ProductID"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "UnitPrice"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "Quantity"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "Discount"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Name = "Order Details"
            SelectQuery1.Tables.Add(Table1)
            Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
            '
            'MainReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader1, Me.ReportFooter, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
            Me.DataMember = "Order Details"
            Me.DataSource = Me.SqlDataSource1
            Me.Version = "19.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
