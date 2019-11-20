Public Class Cuadrado
    Inherits Figura
    Sub New(nombre As String, lado As Single)
        MyBase.New(nombre)
        Me.Lado = lado
    End Sub
    Public Property Lado As Single
    Public Overrides Function CalcularArea() As Single
        Return Lado ^ 2
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
