using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_74_ClassLibrary_CarLibrary
{
    public enum EngineState
    { engineAlive, engineDead }

    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState engState = EngineState.engineAlive;
        public EngineState EngineState => engState;

        public abstract void TurboBoost();
        public Car() { }
        public Car(string name, int currSpeed, int maxSpeed)
        {
            PetName = name;
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }
    }
}
