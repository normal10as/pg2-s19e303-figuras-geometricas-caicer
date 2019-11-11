Public Class Rectangulo
    Inherits Figura
    Sub New()
        MyBase.New()
        _Base = 0
        _Altura = 0
    End Sub
    Public Property Base As Single
    Public Property Altura As Single
    Public Overrides Function CalcularArea() As Single
        Return Base * Altura
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
