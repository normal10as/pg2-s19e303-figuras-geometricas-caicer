Public MustInherit Class Figura
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Property Nombre As String
    Public MustOverride Function CalcularArea() As Single
End Class