Imports System
Imports FigurasGeometricas
Module TrianguloTest
    Sub Triangulo()
        Dim triangulo1 As New Triangulo("Triangulo", 5, 3)
        triangulo1.Nombre = "Triangulo"
        triangulo1.Base = 5
        triangulo1.Altura = 3

        Console.WriteLine("TRIANGULO")
        Console.WriteLine("ToString: " & triangulo1.ToString)
        Console.WriteLine("Base: " & triangulo1.Base)
        Console.WriteLine("Altura: " & triangulo1.Altura)
        Console.WriteLine("Area: " & triangulo1.CalcularArea)
    End Sub
End Module
