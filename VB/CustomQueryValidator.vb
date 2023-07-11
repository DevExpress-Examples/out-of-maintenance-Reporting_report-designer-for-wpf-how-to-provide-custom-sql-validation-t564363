Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.DataAccess.ConnectionParameters

Namespace ValidateCustomSql
    Public Class MyCustomQueryValidator
        Implements ICustomQueryValidator

        Public Function Validate(ByVal connectionParameters As DataConnectionParametersBase, ByVal sql As String, ByRef message As String) As Boolean Implements ICustomQueryValidator.Validate
            ' Add your custom validation logic here. 
            ' The method should return true if the query is valid and false otherwise. 
            Return False
        End Function
    End Class
End Namespace
