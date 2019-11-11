Imports Microsoft.VisualBasic

Public MustInherit Class Figura
    Public Sub New()
        Me.Nombre = ""
    End Sub
    Public Property Nombre As String
    Public MustOverride Function CalcularArea() As Single

End Class
