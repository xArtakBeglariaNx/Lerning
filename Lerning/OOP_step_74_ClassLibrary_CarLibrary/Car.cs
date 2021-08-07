using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_step_74_ClassLibrary_CarLibrary
{
    public enum EngineState
    { engineAlive, engineDead }

    public enum MusicMedia
    {
        musicCD,
        musicTape,
        musicRadio,
        musicMP3
    }

    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState engState = EngineState.engineAlive;
        public EngineState EngineState => engState;

        public abstract void TurboBoost();
        public void TurnOnRadio(bool musicOn, MusicMedia mm) =>
            MessageBox.Show(musicOn ? "Jamming" : "Quet time");
        public Car() { }
        public Car(string name, int currSpeed, int maxSpeed)
        {
            MessageBox.Show("Car Library Version 2.0!");
            PetName = name;
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }
    }
}
