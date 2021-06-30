using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethotds_step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Fun with Methods: <=");

            Console.WriteLine("===============================");

            int x = 10, y = 9;
            Console.WriteLine($"Before call: [x = {x}], [y = {y}]");
            Console.WriteLine($"Answer is : [Add = {ExmScopeVariable(x, y)}]");
            Console.WriteLine($"After call: [x = {x}], [y = {y}]");
            SecondExample(90, 90, out int answer);
            SecondExample(90, 90, out answer);
            Console.WriteLine($"Call [90+90 = {answer}]");
            FillTheseValues(out int a, out string b, out bool c);
            Console.WriteLine($"Sea a [FillTheseValues => {a}:{b}:{c}]");

            Console.WriteLine("===============================");

            Console.WriteLine("=> Swap String");
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine($"Before: [str1] = {str1} : [str2] = {str2}");
            SwapString(ref str1,ref str2);
            Console.WriteLine($"After: [str1] = {str1} : [str2] = {str2}");

            Console.WriteLine("===============================");

            #region Ref locals and params
            Console.WriteLine("=> Simple Return");
            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            var output = SimpleReturn(stringArray, pos);
            Console.WriteLine($"After call SimpleReturn: {stringArray[0]}, {stringArray[1]}, {stringArray[2]}");
            #endregion

            Console.WriteLine("===============================");

            #region Ref locals and ref params
            Console.WriteLine("=> Use Ref return");
            Console.WriteLine($"Before call SampleRefReturn: {stringArray[0]}, {stringArray[1]}, {stringArray[2]}");
            ref var refOutput = ref SampleRefReturn(stringArray, pos);
            refOutput = "new";
            Console.WriteLine($"After call SampleRefReturn: {stringArray[0]}, {stringArray[1]}, {stringArray[2]}");
            #endregion

            Console.WriteLine("===============================");

            #region Модификатор Params
            Console.WriteLine("=> Params");

            //Первый способ
            double avarage = CalculateAvarage(22.4, 33.1, 16, 32.7, 88,5);
            Console.WriteLine("Avarage of data is: {0}", avarage);

            Console.WriteLine("++++");

            //Второй способ
            double[] data = { 34.1, 22.7, 16.8 };
            avarage = CalculateAvarage(data);
            Console.WriteLine("Avarage of data is: {0}", avarage);

            Console.WriteLine("++++");

            Console.WriteLine("Avarage of data is: {0}", CalculateAvarage());
            #endregion

            Console.WriteLine("===============================");

            #region Вызов метода с необязательным параметром
            Console.WriteLine("=> не обязательный параметр");
            string anotherExample = "Для необязательного параметра";
            EnterLogData("Oh no! Grid cant find data");
            EnterLogData("Oh no! Grid cant find data","CFO");
            EnterLogData(anotherExample);
            #endregion

            Console.WriteLine("===============================");

            #region Вызов метода с именнованными параметрами
            Console.WriteLine("=> Вызов метода с именованными параметрами");
            DisplayFancyMessage(message: "Very Fancy indeed", textColor: ConsoleColor.Yellow, backgroundColor: ConsoleColor.DarkBlue);
            DisplayFancyMessage(backgroundColor: ConsoleColor.White, message: "Second try! Very Fancy (*v*)", textColor: ConsoleColor.Magenta);
            #endregion
            Console.WriteLine("===============================");

            Console.WriteLine("=> Вызов перегруженного метода");
            int sumAddInt = Add(10, 10);
            long sumAddLong = Add(900_000_000_000, 900_000_000_000);
            double sumAddDouble = Add(4.3, 4.4);
            Console.WriteLine(sumAddInt);
            Console.WriteLine(sumAddLong);
            Console.WriteLine(sumAddDouble);

            Console.WriteLine("===============================");

            Console.WriteLine("=> Вызов метода с методом внутри");
            int sumAddWrapper = AddWrapper(25, 13);
            Console.WriteLine(sumAddWrapper);
            Console.ReadLine();
        }

        static int ExmScopeVariable(int x, int y)
        {            
            int ans = x + y;
            x = 10000;
            y = 88888;
            Console.WriteLine($"[ans in a Add_method = {ans}]");
            return ans;
        }

        static void SecondExample(int x, int y, out int answer)
        {
            answer = x + y;
        }

        static void FillTheseValues(out int a,out string b,out bool c)
        {
            a = 5;
            b = "Hello";
            c = false;
        }

        static void SwapString(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        public static string SimpleReturn(string[] strArray, int position)
        {
            return strArray[position];
        }

        public static ref string SampleRefReturn(string[] strArray,int position)
        {
            return ref strArray[position];
        }

        
        static double CalculateAvarage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);
            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }

        /// <summary>
        /// Метод с необязательными параметром
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner">необязательный параметр</param>
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
            Console.WriteLine(DateTime.Now);
        }
        
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            //Сохраняем старые цвета
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgrounbdColor = Console.BackgroundColor;
            Console.WriteLine(message);
            //Устанавливаем новые цвета
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            //Возвращаем новые цвета
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgrounbdColor;
        }

        //перегрузка методов
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x, long y)
        {
            return x + y;
        }

        //Локальные функции (методы внутри методов)
        static int AddLocalFun(int x, int y)
        {
            return x + y;
        }
        static int AddWrapper(int x, int y)
        {
            return AddLocalFun();
            int AddLocalFun()
            {
                return x + y;
            }            
        }
    }
}
