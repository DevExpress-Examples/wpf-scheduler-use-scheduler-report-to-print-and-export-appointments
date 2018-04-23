Imports System.Collections.Generic
Imports System.Data.Entity

Namespace PrintingExample
    Public Class ReceptionDeskDBInitializer
        Inherits CreateDatabaseIfNotExists(Of ReceptionDeskContext)

        Protected Overrides Sub Seed(ByVal context As ReceptionDeskContext)
            MyBase.Seed(context)
            Dim Doctors As New List(Of Doctor)() From { _
                New Doctor(1,"Stomatologist"), _
                New Doctor(2, "Ophthalmologist"), _
                New Doctor(3, "Surgeon") _
            }
            Doctors.ForEach(Sub(x) context.Doctors.Add(x))
            context.SaveChanges()
        End Sub
    End Class
End Namespace