using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicDataTypes_step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor textColor = ConsoleColor.Yellow, bgColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = bgColor;
            Console.WriteLine();
            LocalVarDeclarations();
            DefaultDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFuntionality();
            ParseFromString();
            ParseFromStringWithTryParse();
            UseDatesAndTimes();
            UseBigInteger();
            DigitSeparators();
            BinnaryLiterals();
            BasicStringFunctionality();
            StringConcatination();
            EscapeChars();
            StringEquality();
            StringEqalitySpecifynngCompareRules();
            StringAreImutable();
            FunWithStringBuilder();
            StringInterpolation();
            Console.ReadLine();
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations: <=");

            int myInt = 0;
            string myString;
            myString = "This is my character data";

            //объявление нескольких переменных одного типа в одной строке
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;
            Console.WriteLine("Your data: myInt = {0}, myString = {1}, b1 = {2}, b2 = {3}, b3 = {4}, b4 = {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations: <=");
            int myInt = default;
            Console.WriteLine("Default data: myInt = {0}", myInt);
            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using NEW to create variables: <=");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("b = {0}, i = {1}, d = {2}, dt = {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality: <=");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality: <=");
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            Console.WriteLine("int.MinValue = {0}", int.MinValue);
            Console.WriteLine("double.MaxValue = {0}", double.MaxValue);
            Console.WriteLine("double.MinValue = {0}", double.MinValue);
            Console.WriteLine("double.Epsilon = {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity = {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity = {0}", double.NegativeInfinity);
            Console.WriteLine("bool.TrueString => {0}", bool.TrueString);
            Console.WriteLine("bool.FalseString => {0}", bool.FalseString);
            Console.WriteLine();
        }

        static void CharFuntionality()
        {
            Console.WriteLine("=> CharFuntionality: <=");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a') => {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a') => {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5) => {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6 => {0})", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?') => {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing: <=");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b(bool) => {0}", b);
            double d = double.Parse("99,256");
            int i = int.Parse("8");
            char c = char.Parse("w");
            Console.WriteLine("Value of d(double) => {0}", d);
            Console.WriteLine("Value of i(int) => {0}", i);
            Console.WriteLine("Value of c(char) => {0}", c);
            Console.WriteLine();
        }

        static void ParseFromStringWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse: <=");
            if (bool.TryParse("Hi", out bool b))
            {
                Console.WriteLine("Value of b(bool) => {0}", b);
            }
            else
            {
                Console.WriteLine("Convert is faled, b(bool) => ({0})|| boob b = 'Hi' is't boolean type", b);
            }

            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d(double) => {0}", d);
            }
            else
            {
                Console.WriteLine("Faled to convert the input ({0}) to a double", value);
            }
            Console.WriteLine();
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times <=");
            DateTime dateTime = new DateTime(2015, 10, 26);
            Console.WriteLine("The day of {0} is {1}", dateTime.Day, dateTime.DayOfWeek);
            dateTime = dateTime.AddMonths(2);
            Console.WriteLine("Daylightsavins: {0}", dateTime.IsDaylightSavingTime());
            TimeSpan timeSpan = new TimeSpan(4, 30, 0);
            Console.WriteLine("timeSpan => " + timeSpan);
            Console.WriteLine("timeSpan => " + timeSpan.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger: <=");
            BigInteger biggy = BigInteger.Parse("999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("is biggy an even value? : {0} ", biggy.IsEven);
            Console.WriteLine("is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("88888888888888888888888888"));
            Console.WriteLine("Value of [reallyBig] is : => {0}", reallyBig);
            BigInteger reallyBig2 = biggy * reallyBig;
            Console.WriteLine("Value of [reallyBig2] is : => " + reallyBig2);
            Console.WriteLine();
        }

        static void DigitSeparators()
        {
            Console.WriteLine("=> Use digit separators: <= ");
            Console.WriteLine("Integer:");
            Console.WriteLine(123_223);
            Console.WriteLine("Long:");
            Console.WriteLine(123_213_231L);
            Console.WriteLine("Float:");
            Console.WriteLine(223_231_213.3214F);
            Console.WriteLine("Double");
            Console.WriteLine(213_321.21);
            Console.WriteLine("Decimal");
            Console.WriteLine(231_231.21M);
            Console.WriteLine();
        }

        private static void BinnaryLiterals()
        {
            Console.WriteLine("=> Use Binary Literals: <= ");
            Console.WriteLine("Sixteen: {0} => 0b001_0000", 0b001_0000);
            Console.WriteLine("Thirty two: {0}=> 0b010_0000", 0b010_0000);
            Console.WriteLine("Sixty Four: {0}=> 0b100_0000", 0b100_0000);
            Console.WriteLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality: <=");
            string firstName = "Freddy";
            Console.WriteLine("Value of string[firstName] => {0}", firstName);
            Console.WriteLine("string[firstName] has characters: => {0}", firstName.Length);
            Console.WriteLine("string[firstName] in uppercase => {0}", firstName.ToUpper());
            Console.WriteLine("string[firstName] in lowercase => {0}", firstName.ToLower());
            Console.WriteLine("string[firstName] contains the letter 'y' => " + firstName.Contains("y"));
            Console.WriteLine("string[firstName] after Replace => {0}", firstName.Replace("dy", ""));
            Console.WriteLine("insert in string[firstName] '_Crew' =>" + firstName.Insert(6, "_Crew"));
            Console.WriteLine();
        }
        static void StringConcatination()
        {
            Console.WriteLine("=> String Concatinations: <=");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string afterConcatination = s1 + s2;
            Console.WriteLine(afterConcatination);
            Console.WriteLine();
        }
        static void EscapeChars()
        {
            // Управляющая последовательность
            // \' - Вставляет в строковый литерал символ одинарной кавычки
            // \" - Вставляет в строковый литерал символ двойной кавычки
            // \\ - Вставляет в строковый литерал символ обратной косой черты. Это особенно полезно при определении путей к файлам или сетевым ресурсам
            // \а - Заставляет систему выдать звуковой сигнал, который в консольных при­ложениях может служить аудио - подсказкой пользователю
            // \п - Вставляет символ новой строки(на платформах Windows)
            // \г - Вставляет символ возврата каретки
            // \t - Вставляет в строковый литерал символ горизонтальной табуляции

            Console.WriteLine("=> Escape characters: <=");
            string strWithTabs = "Model \tColor \tSpeed \tPet Name";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyoneloves \"Hello world\"");
            Console.WriteLine("C:\\MyApp\\Bin\\Debug");
            Console.WriteLine("All finished \n\n\n\a");
            Console.WriteLine("Определение дословных строк с помощью символа @");
            Console.WriteLine(@"C\MyApp\Bin\Debug");
            string myLongString = @"This very
        very
            very
                long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cermerus said: ""Grrrr! Pret-ty sun-set """);
            Console.WriteLine();
        }

        static void StringEquality()
        {
            Console.WriteLine("=> StringEquality: <=");
            string string1 = "Hello";
            string string2 = "Yo";
            Console.WriteLine("string1 = {0}", string1);
            Console.WriteLine("string2 = {0}", string2);
            Console.WriteLine();
            Console.WriteLine("string1 == string2: {0}", string1 == string2);
            Console.WriteLine("string1 == Hello : {0}", string1 == "Hello");
            Console.WriteLine("string1 == HELLO : {0}", string1 == "HELLO");
            Console.WriteLine("string1 == hello : {0}", string1 == "hello");
            Console.WriteLine("string1.Equals(string2) => {0}", string1.Equals(string2));
            Console.WriteLine("YO.Eqals(string2) => " + "YO".Equals(string2));
            Console.WriteLine();
        }
        static void StringEqalitySpecifynngCompareRules()
        {
            Console.WriteLine("=> String Eqality (Case Ensensitive): <=");
            string string1 = "Hello";
            string string2 = "HELLO";
            Console.WriteLine("string1 & string2 =>" + string1 + " & " + string2);
            Console.WriteLine();
            Console.WriteLine("Default rules to comparing: string1 = {0}, string2 = {1}: string1.Equals(string2) => {2} ", string1, string2, string1.Equals(string2));
            Console.WriteLine("Ignore case: string1.Equals(string2, StringComparison.OrdinalIgnoreCase) => {0}", string1.Equals(string2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: string1.Equals(string2, StringComparison.InvariantCultureIgnoreCase) => {0}", string1.Equals(string2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Default rules: string1 = {0}, string2 = {1}, \nstring1.IndexOf(\"E\") => {2}, string2.IndexOf(\"E\") => {3}", string1, string2, string1.IndexOf("E"), string2.IndexOf("E"));
            Console.WriteLine("Ignore Case: string1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase) => {0}", string1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore Case, InvariantCulture: string1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase) => {0}", string1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }

        static void StringAreImutable()
        {
            Console.WriteLine("=> String are Imutable: <=");
            string s1 = "This is my life";
            Console.WriteLine("string s1 = " + s1);
            string upperCase = s1.ToUpper();
            Console.WriteLine("string upperCase = " + upperCase);
            Console.WriteLine("string s1 = {0}", s1);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("=> String are Imutable2: <=");
            string s2 = "My others life";
            s2 = "New my life can be realised";
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using with StringBuilder: <=");
            StringBuilder stringBuilder = new StringBuilder ("+++++ Fantastic Games +++++");
            stringBuilder.Append("\n");
            stringBuilder.AppendLine("Half life");
            stringBuilder.AppendLine("Morrowind");
            stringBuilder.AppendLine("Deus Ex " + "2");
            stringBuilder.AppendLine("System shock");
            stringBuilder.AppendLine("Warframe");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Replace("2", "Invisible War");
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine("stringBuilder has {0} chars : ", stringBuilder.Length);            
            Console.WriteLine();
        }

        static void StringInterpolation()
        {
            Console.WriteLine("=> String Interpolation: <=");
            int age = 4;
            string  name = "Soren";

            string greeting = string.Format("Hello {0} you are {1} years old", name, age);
            string greeting2 = string.Format($"Hello {name} you are {age} years old");
            Console.WriteLine(greeting2);

            string greetingToUpper = string.Format("Hello {0} you are {1} years old", name.ToUpper(), age);
            string greetingToUpper2 = string.Format($"Hello {name.ToUpper()} you are {age} years old");
            Console.WriteLine(greetingToUpper2);
            Console.WriteLine();
        }
    }
}
