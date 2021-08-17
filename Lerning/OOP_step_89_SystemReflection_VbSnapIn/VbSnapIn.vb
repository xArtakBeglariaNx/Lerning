Imports OOP_step_87_SystemReflection_CommonSnapableTypes

<Companyinfo(CompanyName:="FooBar", CompanyUrl:="www.foobar.com")>
Public Class VbSnapIn
    Implements IAppFunctionality

    Public Sub DoIt() Implements OOP_step_87_SystemReflection_CommonSnapableTypes.IAppFunctionality.DoIt
        Console.WriteLine("You have just used the VB snap-in")
    End Sub
End Class
