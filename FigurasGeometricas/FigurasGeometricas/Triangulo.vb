Public Class Triangulo
    Inherits Figura
    Public Sub New(nombre As String, base As Single, altura As Single)
        MyBase.New(nombre)
        Me.Base = base
        Me.Altura = altura
    End Sub
    Public Property Base As Single
    Public Property Altura As Single
    Public Overrides Function CalcularArea() As Single
        Return (Base * Altura) / 2
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
