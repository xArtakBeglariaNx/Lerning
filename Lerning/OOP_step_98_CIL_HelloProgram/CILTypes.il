.assembly extern mscorlib
{
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
    .ver 4:0:0:0
}

.assembly CILTypes 
{
    .ver 1:0:0:0
}

.module CILTypes.dll

//.namespace MyNamespace {}

/*.namespace MyCompany
{
    .namespace MyNamespace {}
}
.namespace MyCompany.MyNamespace {}*/

.namespace MyNamespace
{
    //create interface
    .class public interface IMyInterface {}

    //extend interfaces in CIL
    .class public interface IMyOtherInterface
        implements MyNamespace.IMyInterface {}

    //create base class
    .class public MyBaseClass 
    {
        .field private string stringField = "hello"
        .field private int32 intFileld = int32(42)

        //create ctor
        .method public hidebysig specialname rtspecialname
         instance void .ctor(string s, int32 i) cil managed
         {
             // TODO: Add implementation code...
         }
        
        // Property syntax
        .method public hidebysig specialname 
		instance void set_TheString(string 'value') cil managed
		{
			// TODO: Add implementation code...
		}
        
        .property instance string TheString()
        {
            .get instance string
             MyNamespace.MyBaseClass::get_TheString()
            .set instance void
             MyNamespace.MyBaseClass::set_TheString(string)
        }

    }

    //create derived class
    .class public MyDerivedClass
        extends MyNamespace.MyBaseClass
        implements MyNamespace.IMyInterface {}  

    //create struct, when you using atribute "value" struct auto derived from [mscorlib]System.ValueType
    .class public sealed value MyStruct {}

    //create struct, when you using atribute "enum" enumerable auto derived from [mscorlib]System.Enum
    .class public sealed enum MyEnum 
    {
        .field public static literal valuetype
        MyNamespace.MyEnum A = int32(0)
        .field public static literal valuetype
        MyNamespace.MyEnum B = int32(1)
        .field public static literal valuetype
        MyNamespace.MyEnum C = int32(3)
    }

    //Initiate local variables
    //example
    /*
        public static void MyLocalVariables ()
            {
            string myStr = "CIL code is fun!";
            int mylnt = 33;
            object myObj = new object ();
            }
    */
    .method public hidebysig static void 
        MyLocalVariables() cil managed
        {
            .maxstack 8
            //initiate local variables
            .locals init ([0] string myStr, [1] int32 myInt, [3] object myObj)
            //load string in virtual stack
            ldstr "CIL code in fun"
            //extract and save in local variable
            stloc.0
            //load const of type i4(short for int32) with value 33
            ldc.i4 33
            //extract and save in local variable
            stloc.1
            //create object and insert in the stack
            newobj instance void [mscorlib]System.Object::.ctor()
            //extract and save in local variable
            stloc.2
            ret
        }

    /*
    public static int Add (int a, int b)
        {
        return a + b;
        }
    */
    .method public hidebysig static int32 Add(int32 a, int32 b)
    {
        .maxstack 2
        ldarg.0         //load in stack
        ldarg.1         //load in stack
        add             //add two values
        ret
    }

    /*void SomeMethod()
    {
        List<int> myInts = new List(int);
    }*/    
    newobj instance void class [mscorlib]
        System.Collections.Generic.List`1<int32>::.ctor()

    //Dictionary<string, int>
    newobj instance void class [mscorlib]
        System.Collections.Generic.Dictionary`2<string,int32>::.ctor()

    //List<List<int>> myInts = new List<List<int>>();
    newobj instance void class [mscorlib]
        System.Collections.Generic.List`1<class
        [mscorlib]System.Collection.List`1<int32>>::.ctor()
}