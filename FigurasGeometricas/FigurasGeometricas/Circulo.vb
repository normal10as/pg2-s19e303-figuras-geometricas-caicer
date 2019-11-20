Public Class Circulo
    Inherits Figura
    Sub New(nombre As String, radio As Single)
        MyBase.New(nombre)
        Me.Radio = radio
    End Sub
    Public Property Radio As Single
    Public Overrides Function CalcularArea() As Single
        Return Math.PI * (Radio ^ 2)
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
