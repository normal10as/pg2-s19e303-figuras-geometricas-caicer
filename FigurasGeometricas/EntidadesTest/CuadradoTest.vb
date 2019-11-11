Imports System
Imports FigurasGeometricas
Module CuadradoTest
    Sub Cuadrado()
        Dim cuadrado1 As New Cuadrado
        cuadrado1.Nombre = "Cuadrado"
        cuadrado1.Lado = 3

        Console.WriteLine("CUADRADO")
        Console.WriteLine("toString: " & cuadrado1.ToString)
        Console.WriteLine("Lado: " & cuadrado1.Lado)
        Console.WriteLine("Area: " & cuadrado1.CalcularArea)
    End Sub
End Module
