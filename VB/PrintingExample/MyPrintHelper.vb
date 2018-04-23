#Region "#MyPrintHelper"
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Printing.Native
Imports DevExpress.Xpf.Scheduling
Imports DevExpress.XtraPrinting.Native
Imports System.Windows

Namespace PrintingExample
    Public NotInheritable Class MyPrintHelper

        Private Sub New()
        End Sub

        Public Shared Property mainWindow() As Window

        Public Shared Sub PrintScheduler(ByVal scheduler As SchedulerControl)
            Dim report As New XtraSchedulerReport1()
            Dim dateTimeRange As DateTimeRange = scheduler.VisibleIntervals(0)
            scheduler.SchedulerPrintAdapter.DateTimeRange = dateTimeRange
            scheduler.SchedulerPrintAdapter.AssignToReport(report)
            PrintHelper.ShowPrintPreview(mainWindow, report)
        End Sub
    End Class
End Namespace
#End Region ' #MyPrintHelper
