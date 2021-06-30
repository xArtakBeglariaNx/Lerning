using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions_step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Fun with type conversions");
            #region Пример расiирения переменной типа short до int            
            //short numb1 = 9, numb2 = 10;
            //Console.WriteLine($"{numb1} + {numb2} = {Add(numb1, numb2)}");
            #endregion

            #region Пример сужения переменной типа int до short (приводит к ошибке)
            //short numb1 = 30000, numb2 = 30000;
            //short answer = Add(numb1, numb2);
            //Console.WriteLine($"{numb1} + {numb2} = {answer}");
            #endregion

            #region Пример явного приведения типов (есть вероятность потери данных)
            short numb1 = 30000, numb2 = 30000;
            short answer = unchecked((short)Add(numb1, numb2)); // не обtрнуто в Try | Cath (=> вызывает ошибку т.к. в свойствах проекта вкл сво-во cheked в арифметических операциях) 
            Console.WriteLine($"{numb1} + {numb2} = {answer}");
            #endregion

            NarrowAttempt();
            ProccessByte();
            Console.ReadLine(); 
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowAttempt()
        {
            #region Сужение типов приводит к ошибке
            //byte myByte = 0;
            //int myInt = 200;
            //myByte = myInt; 
            #endregion

            #region Пример явного приведения типов (есть вероятность потери данных)
            byte myByte = 0;
            int myInt = 200;
            myByte = (byte)myInt;            
            #endregion
            Console.WriteLine($"Value of myByte: {myByte}");
        }

        static void ProccessByte()
        {
            #region Данный метод явного приведения типов приводит к неверному значению
            //byte b1 = 100;
            //byte b2 = 250;
            //byte sum = (byte)Add(b1, b2);
            //Console.WriteLine($"sum = {sum}");
            #endregion

            #region Использование ключевого слова cheked для ловли переполнения значений либо их потери
            //byte b1 = 100;
            //byte b2 = 250;
            //try
            //{
            //    byte sum = checked((byte)Add(b1, b2));
            //    Console.WriteLine($"sum = {sum}");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine($"Result by sum operation: {ex.Message}");
            //}
            #endregion

            #region При условии что необходимо опустить проверку на переполнение либо потерю значений по время арифметических операций можно использовать ключенивео слово uncheked
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                byte sum = unchecked((byte)Add(b1, b2));
                Console.WriteLine($"sum = {sum}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Result by sum operation: {ex.Message}");
            } 
            #endregion
        }
    }
}
