using System;

namespace OOP_step_42_Generics_CustomGenericMethods
{
    public static class MyGenericMethods
    {
        #region Generic Swap method for anything types        
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent Swap() method a {typeof(T).Name}");
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region GenericBaseClassType
        public static void DisplayBaseClass<T, E, Q>()
        {
            Console.WriteLine($"Base class of \n{typeof(T)} is: {typeof(T).BaseType}\n{typeof(E)} is: {typeof(E).BaseType}\n{typeof(Q)} is: {typeof(Q)}");
        }
        #endregion
    }
}
