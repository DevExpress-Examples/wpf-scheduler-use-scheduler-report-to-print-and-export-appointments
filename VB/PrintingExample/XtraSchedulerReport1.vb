Imports System

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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
            Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
            DirectCast(Me.reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.horizontalResourceHeaders1, Me.calendarControl1, Me.dayViewTimeCells1, Me.horizontalDateHeaders1, Me.dayViewTimeRuler1, Me.timeIntervalInfo1})
            Me.Detail.HeightF = 899F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' horizontalResourceHeaders1
            ' 
            Me.horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(93.00003F, 157F)
            Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
            Me.horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(549.9999F, 25F)
            Me.horizontalResourceHeaders1.View = Me.reportDayView1
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(283F, 8F)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SizeF = New System.Drawing.SizeF(350F, 142F)
            Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
            Me.calendarControl1.View = Me.reportDayView1
            ' 
            ' dayViewTimeCells1
            ' 
            Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalDateHeaders1
            Me.dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(93.00003F, 207F)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.SizeF = New System.Drawing.SizeF(549.9999F, 692F)
            Me.dayViewTimeCells1.View = Me.reportDayView1
            Me.dayViewTimeCells1.VisibleTimeSnapMode = False
            ' 
            ' horizontalDateHeaders1
            ' 
            Me.horizontalDateHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(93F, 182F)
            Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
            Me.horizontalDateHeaders1.SizeF = New System.Drawing.SizeF(550F, 25F)
            Me.horizontalDateHeaders1.View = Me.reportDayView1
            ' 
            ' dayViewTimeRuler1
            ' 
            Me.dayViewTimeRuler1.Corners.Top = 50
            Me.dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(43.00003F, 157F)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(50F, 742F)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(17F, 8F)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(242F, 100F)
            Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
            ' 
            ' XtraSchedulerReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.Margins = New System.Drawing.Printing.Margins(55, 100, 100, 100)
            Me.Version = "17.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() { Me.reportDayView1})
            DirectCast(Me.reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
