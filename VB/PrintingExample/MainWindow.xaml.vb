Namespace PrintingExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            MyPrintHelper.mainWindow = Me
        End Sub
    End Class
End Namespace
