Public Class XtraSchedulerReport1
    Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand

    Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders

    Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView

    Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

    Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells

    Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders

    Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler

    Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

    Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

    Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
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
        Detail = New DevExpress.XtraReports.UI.DetailBand()
        topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
        calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
        dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
        horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
        dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
        timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
        reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
        CType(reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {horizontalResourceHeaders1, calendarControl1, dayViewTimeCells1, horizontalDateHeaders1, dayViewTimeRuler1, timeIntervalInfo1})
        Detail.HeightF = 899F
        Detail.Name = "Detail"
        Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' topMarginBand1
        ' 
        topMarginBand1.HeightF = 100F
        topMarginBand1.Name = "topMarginBand1"
        ' 
        ' bottomMarginBand1
        ' 
        bottomMarginBand1.HeightF = 100F
        bottomMarginBand1.Name = "bottomMarginBand1"
        ' 
        ' horizontalResourceHeaders1
        ' 
        horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(93.00003F, 157F)
        horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
        horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(549.9999F, 25F)
        horizontalResourceHeaders1.View = reportDayView1
        ' 
        ' calendarControl1
        ' 
        calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(283F, 8F)
        calendarControl1.Name = "calendarControl1"
        calendarControl1.SizeF = New System.Drawing.SizeF(350F, 142F)
        calendarControl1.TimeCells = dayViewTimeCells1
        calendarControl1.View = reportDayView1
        ' 
        ' dayViewTimeCells1
        ' 
        dayViewTimeCells1.HorizontalHeaders = horizontalDateHeaders1
        dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(93.00003F, 207F)
        dayViewTimeCells1.Name = "dayViewTimeCells1"
        dayViewTimeCells1.SizeF = New System.Drawing.SizeF(549.9999F, 692F)
        dayViewTimeCells1.View = reportDayView1
        dayViewTimeCells1.VisibleTimeSnapMode = False
        ' 
        ' horizontalDateHeaders1
        ' 
        horizontalDateHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(93F, 182F)
        horizontalDateHeaders1.Name = "horizontalDateHeaders1"
        horizontalDateHeaders1.SizeF = New System.Drawing.SizeF(550F, 25F)
        horizontalDateHeaders1.View = reportDayView1
        ' 
        ' dayViewTimeRuler1
        ' 
        dayViewTimeRuler1.Corners.Top = 50
        dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(43.00003F, 157F)
        dayViewTimeRuler1.Name = "dayViewTimeRuler1"
        dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(50F, 742F)
        dayViewTimeRuler1.TimeCells = dayViewTimeCells1
        dayViewTimeRuler1.View = reportDayView1
        ' 
        ' timeIntervalInfo1
        ' 
        timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(17F, 8F)
        timeIntervalInfo1.Name = "timeIntervalInfo1"
        timeIntervalInfo1.SizeF = New System.Drawing.SizeF(242F, 100F)
        timeIntervalInfo1.TimeCells = dayViewTimeCells1
        ' 
        ' XtraSchedulerReport1
        ' 
        Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Detail, topMarginBand1, bottomMarginBand1})
        Margins = New System.Drawing.Printing.Margins(55, 100, 100, 100)
        Version = "17.2"
        Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {reportDayView1})
        CType(reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
#End Region
End Class
