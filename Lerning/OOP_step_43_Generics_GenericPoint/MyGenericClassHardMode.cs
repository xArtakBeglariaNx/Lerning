using OOP_step_34_Interfaces_InterfaceHierarchy;

namespace OOP_step_43_Generics_GenericPoint
{
    class MyGenericClassHardMode<T> where T : class, IDrawable, new()
    {
        public T Anything { get; set; }
        public MyGenericClassHardMode() { }
        public override string ToString() => $"Anything = {Anything} his type {typeof(T)}";
    }
}
