Module Module1

    Sub Main()
        Dim saludo = "BIENVENIDO A ESTE PROGRAMA"
        Console.WriteLine(saludo)
        Console.WriteLine("")

        Dim nom1 As String = "Manuel Antonio"
        Dim ape1 = " Cruz Garcia "
        Dim sex1 = "Hombre"
        Dim edad1 = 47
        Dim depto1 = "San Salvador"
        depto1 = depto1.Replace("San Salvador", "Tonacatepeque")
        Dim carre1 = "Licenciatura en computacion"


        Console.WriteLine("NOMBRE :" & nom1 + ape1)

        Console.WriteLine("SEXO:" & sex1)
        Console.WriteLine("EDAD: " & edad1)
        Console.WriteLine("DEPARTAMENTO:" & depto1)
        Console.WriteLine("CARRERA :" & carre1)
        Console.WriteLine("")

        Dim nom2 = "Luis Enrique"
        Dim ape2 = "Lopez Alvarado"
        Dim sex2 = "Hombre"
        Dim edad2 = 22
        Dim depto2 = "Sonsonate"

        Dim carre2 = "Licenciatura en Computacion"

        Console.WriteLine("NOMBRE :" & nom2 + ape2)
        Console.WriteLine("SEXO:" & sex2)
        Console.WriteLine("EDAD: " & edad2)
        Console.WriteLine("DEPARTAMENTO :" & depto2)
        Console.WriteLine("CARRERA :" & carre2)
        Console.WriteLine("")


        Dim nom4 = "Alvaro Ernesto"
        Dim ape4 = "Marroquin Morales"
        Dim sex4 = "Hombre "
        Dim edad4 = 19
        Dim depto4 = "San Salvador"
        Dim carre4 = "Licenciatura en computación"

        Console.WriteLine("NOMBRE :" & nom4 + ape4)
        Console.WriteLine("SEXO:" & sex4)
        Console.WriteLine("EDAD: " & edad4)
        Console.WriteLine("DEPARTAMENTO : " & depto4)
        Console.WriteLine("CARRERA :" & carre4)
        Console.WriteLine("")


        Dim nom3 = "Adrian Antonio"
        Dim ape3 = "Ayala Ramirez"
        Dim sex3 = "Hombre"
        Dim edad3 = "23"
        Dim depto3 = "San Salvador"
        Dim carre3 = "Licenciatura en Computacion"


        Console.WriteLine("NOMBRE :" & nom3 + ape3)
        Console.WriteLine("SEXO:" & sex3)
        Console.WriteLine("EDAD: " & edad3)
        Console.WriteLine("DEPARTAMENTO :" & depto3)
        Console.WriteLine("CARRERA :" & carre3)
        Console.WriteLine("")

        Dim promedioEdad = (edad1 + edad2 + edad3 + edad4) / 4
        Console.WriteLine("promedio de edades es:" & promedioEdad)

        Console.WriteLine(nom1 & " terminara su carrera de " & edad1 + 2)
        Console.WriteLine(nom2 & " terminara su carrera de " & edad2 + 3)
        Console.WriteLine(nom3 & " terminara su carrera de " & edad3 + 3)
        Console.WriteLine(nom4 & " terminara su carrera de " & edad4 + 3)




    End Sub

End Module
