Imports System
Imports FigurasGeometricas
Module RectanguloTest
    Sub Rectangulo()
        Dim rectangulo1 As New Rectangulo
        rectangulo1.Nombre = "Rectangulo"
        rectangulo1.Altura = 3
        rectangulo1.Base = 7

        Console.WriteLine("RECTANGULO")
        Console.WriteLine("toString: " & rectangulo1.Nombre)
        Console.WriteLine("Base: " & rectangulo1.Base)
        Console.WriteLine("Altura: " & rectangulo1.Altura)
        Console.WriteLine("Area: " & rectangulo1.CalcularArea)
    End Sub
End Module