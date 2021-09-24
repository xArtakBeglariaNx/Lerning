using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Reflection;

namespace OOP_step_99_CIL_MyAsmBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Amazing Dynamic Assembly Builder");
            //Get App domain for currantThread
            AppDomain currAppDomain = Thread.GetDomain();

            //Create dynamic assembly with our method
            CreateAsm(currAppDomain);
            Console.WriteLine("-> Finished creating MyAssembly.dll");

            //load new assembly from file
            Console.WriteLine("-> loading MyAssembly.dll from file");
            Assembly a = Assembly.Load("MyAssembly");

            //get Type HelloWorld
            Type hello = a.GetType("MyAssembly.HelloWorld");

            //Create object HelloWorld and to call a specific constructor
            Console.Write("-> Enter message a pass HelloWorld class:");
            string msg = Console.ReadLine();
            object[] ctorArgs = new object[1];
            ctorArgs[0] = msg;
            object obj = Activator.CreateInstance(hello, ctorArgs);

            //call SayHell() and display return string
            Console.WriteLine("-> Caling SayHello() via late binding");
            MethodInfo mi = hello.GetMethod("SayHello");
            mi.Invoke(obj, null);

            //caling method GetMsg()
            mi = hello.GetMethod("GetMsg");
            Console.WriteLine(mi.Invoke(obj, null));
        }

        static void CreateAsm(AppDomain currAppDomain)
        {
            //Set general characters
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "MyAssembly";
            assemblyName.Version = new Version("1.0.0.0");

            //Create new assembly in currDomain
            AssemblyBuilder assembly = currAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);

            //Module name has been as assembly name because creates one file assembly
            ModuleBuilder module = assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");

            //define public class HelloWorld
            TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", TypeAttributes.Public);

            //define private variable type of string with name theMessage
            FieldBuilder msgField = helloWorldClass.DefineField("MyAssembly", Type.GetType("System.String"), FieldAttributes.Private);

            //create special constructor
            Type[] constructorArgs = new Type[1];
            constructorArgs[0] = typeof(string);
            ConstructorBuilder constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, constructorArgs);
            ILGenerator constructorIL = constructor.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0);
            Type objectClass = typeof(object);
            ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
            constructorIL.Emit(OpCodes.Call, superConstructor);
            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Stfld, msgField);
            constructorIL.Emit(OpCodes.Ret);

            //create standart constructor
            helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);

            //create method GetMsg()
            MethodBuilder getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, typeof(string), null);
            ILGenerator methodIL = getMsgMethod.GetILGenerator();
            methodIL.Emit(OpCodes.Ldarg_0);
            methodIL.Emit(OpCodes.Ldfld, msgField);
            methodIL.Emit(OpCodes.Ret);

            //create method SayHello
            MethodBuilder sayHiMethod = helloWorldClass.DefineMethod("SayHello", MethodAttributes.Public, null, null);
            methodIL = sayHiMethod.GetILGenerator();
            methodIL.EmitWriteLine("Hello from Hello World Class!");
            methodIL.Emit(OpCodes.Ret);

            //release class
            helloWorldClass.CreateType();

            //save in file
            assembly.Save("MyAssembly.dll");
        }
    }
}
