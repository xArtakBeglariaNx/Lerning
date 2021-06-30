using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            TextColor();
            Console.WriteLine("=> Fun with Arrays: <=");
            Console.WriteLine("=============================");
            SimpleArrays();
            Console.WriteLine("=============================");
            ArrayInitialization();
            Console.WriteLine("=============================");
            DeclareImplicitArrays();
            Console.WriteLine("=============================");
            ArrayObject();
            Console.WriteLine("=============================");
            RectangularMultidemensionalArray();
            Console.WriteLine("=============================");
            JaggedMultidemensionalArray();
            Console.WriteLine("=============================");
            GetArraysFromMethods();
            Console.WriteLine("=============================");
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simpla Array Creation: <=");
            int[] myInt = new int[3];
            myInt[1] = 25;
            myInt[2] = 100;
            myInt[0] = 40;
            foreach (int i in myInt)
            {
                Console.WriteLine(i);
            }
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization: <=");
            string[] stringArray = new string[] { "zero", "one", "two" };
            Console.WriteLine("[stringArray] has {0} elements", stringArray.Length);
            bool[] boolArray = { false, false, false, true };
            Console.WriteLine($"[boolArray] has {boolArray.Length} elements");
            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"[intArray] has {intArray.Length} elements");
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Inplicit Array Initialization: <=");

            var a = new[] { 1, 2, 3, 5 };
            Console.WriteLine($"[a] has a {a.ToString()}");
            var b = new[] { 1, 1.2, 2, 2.5 };
            Console.WriteLine($"[b] has a {b.ToString()}");
            var c = new[] { "IOY", "HI", null, "Wellcome" };
            Console.WriteLine($"[c] has a {c.ToString()}");
        }

        static void ArrayObject()
        {
            Console.WriteLine("=> Array object: <=");
            object[] objectArray = new object[4];
            objectArray[0] = 2.235;
            objectArray[1] = false;
            objectArray[2] = new DateTime(1968, 3, 14);
            objectArray[3] = "Hoolllaa";

            object[] objectArray2 =
            {
                10,
                false,
                "Holllaaa",
                new DateTime(2012, 2, 28)
            };

            foreach (var obj in objectArray)
            {
                Console.WriteLine($"Type: {obj.GetType()} [] Value: {obj.ToString()}");
            }
            Console.WriteLine("=============================");
            foreach (object obj in objectArray2)
            {
                Console.WriteLine($"Type: {obj.GetType()} [] Value: {obj.ToString()}");
            }
        }

        static void RectangularMultidemensionalArray()
        {
            Console.WriteLine("=> Rectangular multidemensional Array: <=");

            int[,] myMatrix = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=============================");

            int[,] myMatrix1 = new int[3, 4] { { 1, 2, 4, 12 }, { 2, 4, 5, 6 }, { 5, 4, 6, 7 } }; // int[,] myMatrix1 = new int[i, j] - i - кол-во подмассивов, j - кол - во элементов в каждом подмассиве
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void JaggedMultidemensionalArray()
        {
            Console.WriteLine("=> Jagged Multidemensional Array: <=");
            int[][] myJaggedArray = new int[5][];
            for (int i = 0; i < myJaggedArray.Length; i++)
            {
                myJaggedArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    Console.Write(myJaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            #region Пример трехмерного массива
            int[,,] vs = new int[3, 2, 3]
                {
                { {3,1,4 },{5,3,2 } },
                {{2,3,1 },{1,1,1 } },
                {{2,3,1 },{1,1,1 } }
                };
            #endregion
        }

        static void PrintArray(int[] myIntArray)
        {
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine($"Item {i} is {myIntArray}");
            }
        }
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            Console.WriteLine($"Array value form [theStrings] is {theStrings.Length}");
            return theStrings;
        }

        static void GetArraysFromMethods()
        {
            int[] age = { 15, 27, 35, 170 };
            foreach (int i in age)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            PrintArray(age);
            
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> System Array Functionality: <=");
            string[] gothicBands = {"Sister of Mercy", "NightWish", "Xandria" };
            Console.WriteLine("=> Here is the array: ");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("=> The reversed array");
            Array.Reverse(gothicBands);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("=> Cleared out all but....");
            Array.Clear(gothicBands, 1, 2);
            foreach (string s in gothicBands)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();
        }

        static void TextColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
