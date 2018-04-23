Namespace PrintingExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            InitializeComponent()
            MyPrintHelper.mainWindow = Me
        End Sub
    End Class
End Namespace
