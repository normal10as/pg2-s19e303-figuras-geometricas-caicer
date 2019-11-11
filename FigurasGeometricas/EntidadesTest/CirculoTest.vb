Imports System
Imports FigurasGeometricas
Module CirculoTest
    Sub Circulo()
        Dim circulo1 As New Circulo
        circulo1.Nombre = "Circulo"
        circulo1.Radio = 3

        Console.WriteLine("CIRCULO")
        Console.WriteLine("toString: " & circulo1.ToString)
        Console.WriteLine("Radio: " & circulo1.Radio)
        Console.WriteLine("Area: " & circulo1.CalcularArea)
    End Sub
End Module
