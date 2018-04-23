Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Xpf.Scheduling
Imports System.Collections.ObjectModel
Imports System.Data.Entity

Namespace PrintingExample
    <POCOViewModel> _
    Public Class MainViewModel
        Private receptionDeskContext As ReceptionDeskContext
        Public Overridable Property Doctors() As ObservableCollection(Of Doctor)
        Public Overridable Property Appointments() As ObservableCollection(Of MedicalAppointment)

        Protected Sub New()
            receptionDeskContext = New ReceptionDeskContext()
            receptionDeskContext.Doctors.Load()
            Doctors = receptionDeskContext.Doctors.Local
            receptionDeskContext.MedicalAppointments.Load()
            Appointments = receptionDeskContext.MedicalAppointments.Local
        End Sub
        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function
        Public Sub AppointmentsUpdated()
            receptionDeskContext.SaveChanges()
        End Sub

        #Region "#PrintScheduler"
        Public Sub PrintScheduler(ByVal scheduler As SchedulerControl)
            MyPrintHelper.PrintScheduler(scheduler)
        End Sub
        #End Region ' #PrintScheduler
    End Class
End Namespace
