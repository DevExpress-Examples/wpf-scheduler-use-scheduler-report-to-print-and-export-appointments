Imports System.Collections.Generic
Imports System.Data.Entity

Namespace PrintingExample

    Public Class ReceptionDeskDBInitializer
        Inherits CreateDatabaseIfNotExists(Of ReceptionDeskContext)

        Protected Overrides Sub Seed(ByVal context As ReceptionDeskContext)
            MyBase.Seed(context)
            Dim Doctors As List(Of Doctor) = New List(Of Doctor)() From {New Doctor(1, "Stomatologist"), New Doctor(2, "Ophthalmologist"), New Doctor(3, "Surgeon")}
            Doctors.ForEach(Sub(x) context.Doctors.Add(x))
            context.SaveChanges()
        End Sub
    End Class
End Namespace
