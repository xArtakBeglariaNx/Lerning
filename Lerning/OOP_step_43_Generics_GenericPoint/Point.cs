using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_43_Generics_GenericPoint
{
    struct Point<T>
    {
        private T xPos;
        private T yPos;

        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        public override string ToString()
        {
            return $"{nameof(X)} = {X}\n{nameof(Y)} = {Y}\n\n";
        }        
        public void ResetPoint()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
