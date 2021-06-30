using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_44_Delegate_SImpleDelegate
{
    /// <summary>
    /// Объявили делегат который указвает на любой метов который принимает 2 целочисленных цисла
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public delegate int BinaryOp(int x, int y);

    /// <summary>
    /// Класс в котором будут методы на которые будет сслылатmся делегат
    /// </summary>
    public class SimpleMath
    {
        public int Add(int x, int y) => x + y;
        public int Substract(int x, int y) => x - y;
        public static int SquerNumber(int x) => x * x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with simple delegate =====\n");
            //создаем экземпляр класса SimpleMath
            SimpleMath simpleMath = new SimpleMath();
            //Создали объект делегата который "указывает" на метод Add
            BinaryOp add = new BinaryOp(simpleMath.Add);
            //Создали объект делегата который "указывает" на метод Substract
            BinaryOp substract = new BinaryOp(simpleMath.Substract);
            //BinaryOp squerNumber = new BinaryOp(SimpleMath.SquerNumber); - данные объект приводит к ошибке на этапе компиляции т.к. делегат должен принимать 2 числа а не 1
            Console.WriteLine($"10 + 10 = {add(10, 10)}");
            Console.WriteLine($"10 - 5 = {substract(10, 5)}\n\n");
            DisplayDelegateInfo(add);
            DisplayDelegateInfo(substract);
            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method name: {d.Method}");
                Console.WriteLine($"Type name: {d.Target}");
            }
        }
    }
}
