using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_step_74_ClassLibrary_CarLibrary
{
    public class SportCars : Car
    {
        public SportCars() { }
        public SportCars(string name, int currSpeed, int maxSpeed)
            : base(name, currSpeed, maxSpeed) { }
        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed", "Faster is a better");
        }
    }

    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int currSpeed, int maxSpeed)
            : base(name, currSpeed, maxSpeed) { }
        public override void TurboBoost()
        {
            engState = EngineState.engineDead;
            MessageBox.Show("Eak!", "Your engine block explored");
        }
    }
}
