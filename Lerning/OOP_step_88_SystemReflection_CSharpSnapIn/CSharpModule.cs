using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_step_87_SystemReflection_CommonSnapableTypes;

namespace OOP_step_88_SystemReflection_CSharpSnapIn
{
    [Companyinfo(CompanyName = "FooBar", CompanyUrl = "www.foobar.com")]
    public class CSharpModule : IAppFunctionality
    {
        void IAppFunctionality.DoIt()
        {
            Console.WriteLine("You have just used the C# snap-in");
        }
    }
}
