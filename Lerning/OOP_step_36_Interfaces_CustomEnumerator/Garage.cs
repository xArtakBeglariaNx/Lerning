using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_36_Interfaces_CustomEnumerator
{
    class Garage : IEnumerable
    {
        private Car[] myCarArray = new Car[4];

        public Garage()
        {
            myCarArray[0] = new Car ("Rusty", 200);
            myCarArray[1] = new Car("Clunker", 90);
            myCarArray[2] = new Car("Zippy", 30);
            myCarArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            return myCarArray.GetEnumerator();
        }

        public IEnumerator StartEnumeratorWithYield()
        {
            foreach (Car c in myCarArray)
            {                
                yield return c;
            }
        }

        public IEnumerator GetEnumeratorWithLocalFunction()
        {
            Exception ex = new  Exception("This will get called"); // исключение сгенерируется немедленно без без условностей как только сработает Move.Next()
            try
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            return actualImplementaion();

            IEnumerator actualImplementaion()
            {
                foreach (Car c in myCarArray)
                {
                    yield return c;
                }
            }
        }

        public IEnumerable GetTheCars(bool returnReversed)
        {
            Exception ex = new Exception("This will get called"); // исключение сгенерируется немедленно без без условностей
            try
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            return actualImplementaion();

            IEnumerable actualImplementaion()
            {
                if (returnReversed)
                {
                    for (int i = myCarArray.Length; i != 0; i-- )
                    {
                        yield return myCarArray[i -1];
                    }
                }
                else
                {
                    foreach (Car c in myCarArray)
                    {
                        yield return c;
                    }
                }                
            }
        }
    }
}
