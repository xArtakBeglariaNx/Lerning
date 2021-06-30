namespace OOP_step_25_PolymorphInterfaces_Shapes
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle (string name) : base (name) { }

        public override void Draw()
        {
            System.Console.WriteLine("Circle drawing - {0}\n=============================", PetName);
        }
    }
}
