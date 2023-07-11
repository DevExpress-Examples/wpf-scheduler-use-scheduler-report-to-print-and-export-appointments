Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity

Namespace PrintingExample

    Public Class ReceptionDeskContext
        Inherits DbContext

        ' Your context has been configured to use a 'ReceptionDeskContext' connection string from your application's 
        ' configuration file (App.config or Web.config). By default, this connection string targets the 
        ' 'EntityFrameworkExample.ReceptionDeskContext' database on your LocalDb instance. 
        ' 
        ' If you wish to target a different database and/or database provider, modify the 'ReceptionDeskContext' 
        ' connection string in the application configuration file.
        Public Sub New()
            MyBase.New("name=ReceptionDeskContext")
            Call Database.SetInitializer(New ReceptionDeskDBInitializer())
        End Sub

        ' Add a DbSet for each entity type that you want to include in your model. For more information 
        ' on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        Public Overridable Property MedicalAppointments As DbSet(Of MedicalAppointment)

        Public Overridable Property Doctors As DbSet(Of Doctor)
    End Class

    Public Class Doctor

        Public Sub New()
        End Sub

        Public Sub New(ByVal id As Integer, ByVal name As String)
            Me.Id = Me.Id
            Me.Name = name
        End Sub

        <Key()>
        Public Property Id As Integer

        Public Property Name As String
    End Class

    Public Class MedicalAppointment

        Protected Sub New()
        End Sub

        <Key()>
        Public Property Id As Integer

        Public Property AllDay As Boolean

        <Required>
        Public Property StartTime As Date

        <Required>
        Public Property EndTime As Date

        Public Property PatientName As String

        Public Property Notes As String

        Public Property Subject As String

        Public Property PaymentStateId As Integer

        Public Property IssueId As Integer

        Public Property Type As Integer

        Public Property Location As String

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property DoctorId As Integer?

        Public Property InsuranceNumber As String

        Public Property FirstVisit As Boolean
    End Class
End Namespace
