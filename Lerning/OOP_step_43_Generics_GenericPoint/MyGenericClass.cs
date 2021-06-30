using System;

namespace OOP_step_43_Generics_GenericPoint
{
    class MyGenericClass<T> where T : new()
    {
        public T Name { get; set; }
        public MyGenericClass() { }
        public override string ToString() => $"Name = {Name} his type {typeof(T)}";
    }
}
