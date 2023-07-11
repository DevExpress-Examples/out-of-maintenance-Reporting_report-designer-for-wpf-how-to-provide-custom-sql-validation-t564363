Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace ValidateCustomSql
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UseServicesRegistry(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call New DXTabbedWindow() With {.Content = New UseServicesRegistry()}.ShowDialog()
        End Sub

        Private Sub UseWizardCustomization(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call New DXTabbedWindow() With {.Content = New UseWizardCustomization()}.ShowDialog()
        End Sub
    End Class
End Namespace
