#Region "#MyPrintHelper"
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Scheduling
Imports System.Windows

Namespace PrintingExample

    Public Module MyPrintHelper

        Public Property mainWindow As Window

        Public Sub PrintScheduler(ByVal scheduler As SchedulerControl)
            Dim report As XtraSchedulerReport1 = New XtraSchedulerReport1()
            Dim dateTimeRange As DateTimeRange = scheduler.VisibleIntervals(0)
            scheduler.SchedulerPrintAdapter.DateTimeRange = dateTimeRange
            scheduler.SchedulerPrintAdapter.AssignToReport(report)
            PrintHelper.ShowPrintPreview(mainWindow, report)
        End Sub
    End Module
End Namespace
#End Region  ' #MyPrintHelper
