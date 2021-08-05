Imports OOP_step_74_ClassLibrary_CarLibrary

Module Module1

    Sub Main()
        Console.WriteLine("===== VB CarLibrary Client App =====")
        Dim myMiniVan As New MiniVan()
        myMiniVan.TurboBoost()

        Dim mySportCar As New SportCars()
        mySportCar.TurboBoost()

        Dim myPerformanceCar As New PerformanceCar With {
            .PetName = "hank"
        }
        myPerformanceCar.TurboBoost()

        Console.ReadLine()

    End Sub

    Public Class PerformanceCar
        Inherits SportCars

        Public Overrides Sub TurboBoost()
            Console.WriteLine("Zero to 60 in a cool 4.8 seconds")
        End Sub
    End Class

End Module
