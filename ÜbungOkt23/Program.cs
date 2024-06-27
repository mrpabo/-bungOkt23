internal class Program
{
    static void Main()
    {
        #region Comments
        //Uebung1();
        //Uebung2PrintLinesInConsole();
        //ReadUserInput();
        //StoreUserInput();
        //Comments();
        #endregion

        #region Arithmetic
        //SumsSquared();
        //MultiplicationOfThreeFactors();
        //DivisionAndDivisionModule();
        //DivisionByZero();
        //OrderOfPriority();
        //Average();
        //CalculateValuesOfAFunction();
        #endregion

        #region Data types A
        //CalculateDimensionsOfSphere();
        //BasicCalculator();
        //ReverseChar();
        //CelsiusToKelvinAndFahrenheit();
        //DoubleValue();
        //FloatValue();
        //MultiplicationTable();
        //GenerateRandomNumber();
        #endregion

        #region Geometry A
        //DrawSquare();
        //DrawRectangle();
        //DrawTriangle();
        //DrawTriangleNortheast();
        //DrawRightAlignedTriangle();
        //DisplayTheGraphicOfFunction();
        #endregion

        #region Flow controls A
        //BasicCalculatorUsingif();
        //BasicCalculatoUsingswitch();
        //PositiveAndNegative();
        //GreatestOfThreeNumbers();,
        //UsingTheInstructionwhile();
        //UsingTheInstructiondowhile();
        //RangeOfNumbers();
        //SumOfInfiniteNumbers();
        //MathematicalStatistics();
        #endregion

        #region Flow controls B
        //NumberRepeated();
        //MultiplesNumbers();
        //AccessControl();
        //InfiniteDivisions();
        //InfiniteMuliplicationTable();
        //SwitchBreakAndDefault();
        //RepetitiveStructures();
        //DigitsInANumber();
        #endregion

        #region Flow controls C
        CharAlphabet();

        #endregion

    }

    #region Methoden

    #region Methoden Comments
    static void Uebung1()
    {
        Console.WriteLine("Hello World.");
    }
    static void Uebung2PrintLinesInConsole()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Jonny");
    }
    static void ReadUserInput()
    {
        Console.WriteLine("What is your favorite color?");
        string x = Console.ReadLine();
        if (string.IsNullOrEmpty(x)) { Console.WriteLine("So you dont want to talk... shade."); }
        Console.WriteLine("Wow! " + x + " Mine to!!!");
    }
    static void StoreUserInput()
    {
        string x = "Hansi";
        Console.WriteLine("What is your Name?? " + x);
        Console.WriteLine("Nice to meet you, " + x);
    }
    /*
    Patric Boso
    Date: 23/10/23
    */
    static void Comments()
    {
        //TODO
    }
    #endregion

    #region Methoden Arithmetic
    static void SumsSquared()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}*{0}= {1}", x, x * x);
    }
    static void MultiplicationOfThreeFactors()
    {
        int x1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}*{0}*{0}={0}", x1 * x2 * x3);
    }
    static void DivisionAndDivisionModule()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(x / y);
        Console.WriteLine("Rest " + x % y);
    }
    static void DivisionByZero()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine("{0}/{1}= {2}", x, y, x / y);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by 0");
        }
    }
    static void OrderOfPriority()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Nr x = " + x);
        int ergebnis1 = -6 + x * 5;
        int ergebnis2 = (13 - 2) * x;
        int ergebnis3 = (x + -2) * (20 / 10);
        int ergebnis4 = (12 + x) / (5 - 4);
        Console.WriteLine("-6 + x * 5 = " + ergebnis1);
        Console.WriteLine("(13 - 2) * x = " + ergebnis2);
        Console.WriteLine("(x + -2) * (20 / 10) = " + ergebnis3);
        Console.WriteLine("(12 + x) / (5 - 4) = " + ergebnis4);


        //int x = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(-6 + x * 5);
        //Console.WriteLine((13 - 2) * x);
        //Console.WriteLine((x + -2) * (20 / 10));
        //Console.WriteLine((12 + x) / (5 - 4));
    }
    static void Average()
    {
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int sum = a + b + c + d;
            //Console.WriteLine();
            //Console.WriteLine(sum / 4);

            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());

            int result = (x1 + x2 + x3 + x4) / 4;
            Console.WriteLine(result);
        }
    }
    static void EquivalentOperations()
    {
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());
        //int result1 = (a + b) * c;
        //int result2 = a * c + b * c;
        //Console.WriteLine(result1);
        //Console.WriteLine(result2);

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((a + b) * c);
        Console.WriteLine(a * c + b * c);
    }
    static void CalculateValuesOfAFunction()
    {
        int x1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y;

        for (int x = x1; x <= x2; x++)
        {
            y = x * x - 2 * x + 1;
            Console.Write("{0} ", y);
        }
    }
    #endregion

    #region Methoden Data types A
    static void CalculateDimensionsOfSphere()
    {
        //double pi = 3.1415;
        //double radius = Convert.ToInt32(Console.ReadLine());
        //double surface = 4 * pi * radius;
        //Console.WriteLine("Surface: " + surface);
        //double volume = 4/3 * pi * radius;
        //Console.WriteLine("Volume: " + volume);

        float radius = Convert.ToSingle(Console.ReadLine());
        float pi = 3.1415926535f;

        float surface = 4 * pi * (radius * radius);
        float volume = 4 / 3 * pi * (radius * radius * radius);

        Console.WriteLine("Surface:" + surface);
        Console.WriteLine("Volume: " + volume);
    }
    static void BasicCalculator()
    {
        var Nr1 = Convert.ToInt32(Console.ReadLine());
        var Nr2 = Convert.ToInt32(Console.ReadLine());

        int Adding = Nr1 + Nr2;
        int Subtracting = Nr1 - Nr2;
        int Division = Nr1 / Nr2;
        int Multiply = Nr1 * Nr2;
        float Modulo = Nr1 % Nr2;
        Console.WriteLine("{0}*{1}={2}", Nr1, Nr2, Multiply);
        Console.WriteLine("{0}+{1}={2}", Nr1, Nr2, Adding);
        Console.WriteLine("{0}-{1}={2}", Nr1, Nr2, Subtracting);
        Console.WriteLine("{0}/{1}={2}", Nr1, Nr2, Division);
        Console.WriteLine("{0} mod {1}={2}", Nr1, Nr2, Modulo);


    }
    static void ReverseChar()
    {
        Console.WriteLine("Give me 3 Chars");
        string Char1 = Console.ReadLine();
        string Char2 = Console.ReadLine();
        string Char3 = Console.ReadLine();
        string sum = Char1 + Char2 + Char3;
        char[] stringArray = sum.ToCharArray();

        sum.Replace(".", " ");
        Array.Reverse(stringArray);

        Console.WriteLine(stringArray);
    }
    static void CelsiusToKelvinAndFahrenheit()
    {
        Console.WriteLine("Temperatur in Celsius angeben:");
        int celsius = Convert.ToInt32(Console.ReadLine());

        int kelvin = celsius + 273;
        Console.WriteLine();
        Console.WriteLine("Kelvin: " + kelvin);
        Console.WriteLine();
        int fahrenheit = celsius * 18 / 10 + 32;
        Console.WriteLine("Fahrenheit: " + fahrenheit);
    }
    static void DoubleValue()
    {
        Console.WriteLine("Tell mi a width (x)");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tell mi a height (y)");
        double y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        double Perimeter = (x + y) * 2;
        Console.WriteLine("Perimeterr: " + Perimeter);

        double Area = x * y;
        Console.WriteLine("Area: " + Area);

        double Diagonal = Math.Sqrt(x * x + y * y);
        Console.WriteLine("Diagonal: " + Diagonal);
    }
    static void FloatValue()
    {
        float distance = Convert.ToSingle(Console.ReadLine());
        float hour = Convert.ToSingle(Console.ReadLine());
        float min = Convert.ToSingle(Console.ReadLine());
        float sec = Convert.ToSingle(Console.ReadLine());

        float timeBySeconds = (hour * 3600) + (min * 60) + sec;
        float mps = distance / timeBySeconds;
        float kph = (distance / 1000.0f) / (timeBySeconds / 3600.0f);
        float mph = kph / 1.609f;

        Console.WriteLine("Speed in meters/sec is {0}", mps);
        Console.WriteLine("Speed in km/h is {0}", kph);
        Console.WriteLine("Speed in miles/h is {0}", mph);
    }
    static void MultiplicationTable()
    {
        Console.WriteLine("Number to multiply");
        int x = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine("{0}x{1}= {2}", x, i, x * i);
        //}
        //if (x == 0)
        //{
        //    Console.WriteLine("Connot multiply 0");
        //}

        if (x == 0)
        {
            Console.WriteLine("Cannot multiply 0");
        }
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}= {2}", x, i, x * i);
            }
        }

        //if (x == 0) Console.WriteLine("XXXXX");
        //else Console.WriteLine("Not 0");

        //if (x == 0)
        //{
        //    Console.WriteLine("");
        //}
        //else if (x < 10)
        //{
        //    Console.WriteLine("< 10");
        //}
        //else if (x < 20)
        //{

        //}
        //else { 
        //}



    }
    static void GenerateRandomNumber()
    {
        Console.WriteLine("Number1 Eingabe:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number2 Eingabe:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int number = rand.Next(number1, number2);
        Console.WriteLine("Random  number is :  " + number);
    }
    #endregion

    #region Methoden Geometry A
    static void DrawSquare()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < width; row++)
        {
            for (int column = 0; column < width; column++)
                Console.Write(x);

            Console.WriteLine();
        }
    }
    static void DrawRectangle()
    {
        int x = Convert.ToInt32(Console.ReadLine());

        //for (int row = 0; row < 5; row++)
        //{
        //    for (int column = 0; column < 3; column++)
        //        Console.Write(x);

        //    Console.WriteLine();
        //}

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}{0}{0}", x);
        }

    }
    static void DrawTriangle()
    {
        int symbol = Convert.ToInt32(Console.ReadLine());
        int maxHight = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= maxHight; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }

    }
    static void DrawTriangleNortheast()
    {
        var symbol = "*";
        int width = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j < i) Console.Write(" ");
                else Console.Write(symbol);
            }

            Console.WriteLine();
        }


        //var symbol = "*";                                     ////Bspl mit Matrix
        //Console.WriteLine("Enter the number of columns");
        //int width = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the number of rows");
        //int height = Convert.ToInt32(Console.ReadLine());

        //int[,] matrix = new int[height, width];

        //for (int i = 0; i < height; i++)
        //{
        //    for (int j = 0; j < width; j++)
        //    {
        //        matrix[i, j] = i * j;
        //        Console.Write(" {0} ", matrix[i, j].ToString());
        //    }
        //    Console.WriteLine();
        //}

    }
    static void DrawRightAlignedTriangle()
    {
        //var symbol = Convert.ToString(Console.ReadLine());
        //int width = 0;

        //for (int i = 0; i < width; i++)
        //{
        //    for (int j = 0; j > width; j++)
        //    {
        //        if (j > i) Console.Write(" ");
        //        else Console.Write(symbol);
        //    }

        //    Console.WriteLine();
        //}

        Console.WriteLine("Give me a string");
        Console.WriteLine("Give me a string");
        string text = Console.ReadLine();

        int j = 1;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(text.Substring(i, j));
            j++;
        }
    }
    static void DisplayTheGraphicOfFunction()
    {
        int x1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y;


        for (int x = x1; x <= x2; x++)
        {
            y = (x - 4) * (x - 4);
            for (int j = 0; j < y; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Methoden Flow controls A
    static void BasicCalculatorUsingif()
    {
        Console.WriteLine("Give me a number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give me a operator + - / * ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Give me a number2");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (operation == '+')
        {
            Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
        }
        else if (operation == '-')
        {
            Console.WriteLine("{0}-{1}={2}", number1, number2, number2 - number1);
        }
        else if (operation == '*')
        {
            Console.WriteLine("{0}*{1}={2}", number1, number2, number1 * number2);
        }
        else if (operation == '/')
        {
            Console.WriteLine("{0}/{1}={2}", number1, number2, number1 / number2);
        }
        else
        {
            Console.WriteLine("No operator");
        }

    }
    static void BasicCalculatoUsingswitch()
    {
        Console.WriteLine("Give me a number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give me a operator + - / * ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Give me a number2");
        int number2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
                break;
            case '-':
                Console.WriteLine("{0}-{1}={2}", number1, number2, number1 - number2);
                break;
            case '*':
                Console.WriteLine("{0}*{1}={2}", number1, number2, number1 * number2);
                break;
            case '/':
                Console.WriteLine("{0}/{1}={2}", number1, number2, number1 / number2);
                break;
            default:
                Console.WriteLine("false operator");
                break;
        }






    }
    static void PositiveAndNegative()
    {
        Console.WriteLine("Give me a number and check it if Postitive or negative");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x < 0)
        {
            Console.WriteLine("Negative");
        }
        if (x > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (x == 0)
        {
            Console.WriteLine("nothing from both");
        }
    }
    static void GreatestOfThreeNumbers()
    {
        Console.WriteLine("Check the highest number");
        Console.WriteLine("Number1");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number2");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number3");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if ((number1 > number2) && (number2 > number3))
        {
            Console.WriteLine("Highest number is: " + number1);
        }
        if ((number1 < number2) && (number2 < number3))
        {
            Console.WriteLine("Highest number is: " + number2);
        }
        if ((number1 > number2) && (number2 < number3))
        {
            Console.WriteLine("Highest number is: " + number3);
        }
    }
    static void UsingTheInstructionwhile()
    {
        Console.WriteLine("Give me a number");
        int x = Convert.ToInt32(Console.ReadLine());

        while (x != 0)
        {
            Console.WriteLine(x * 10);
            Console.WriteLine("Step out with 0");
            x = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void UsingTheInstructiondowhile()
    {
        Console.WriteLine("Give me a number");
        int x = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine(x * 10);
            Console.WriteLine("Step out with 0");
            x = Convert.ToInt32(Console.ReadLine());
        } while (x != 0);

    }
    static void RangeOfNumbers()
    {
        Console.WriteLine("Beginn of range");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("End of range");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Your range:");

        for (int i = number1; i <= number2; i++)
        {
            Console.WriteLine("{0}", i);
        }
        Console.WriteLine("End of your range");
    }
    static void SumOfInfiniteNumbers()
    {
        int x;
        int sum = 0;

        do
        {
            x = Convert.ToInt32(Console.ReadLine());
            sum = x + sum;

            if (x != 0)
                Console.WriteLine(sum);
        }
        while (x != 0);
        Console.WriteLine("Finished");
    }
    static void MathematicalStatistics()
    {

        int total = 5;
        int[] numbers = new int[total];

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("Give me numbers: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0,
        average = 0,
        min = int.MaxValue,
        max = int.MinValue;


        for (int i = 0; i < total; i++)
        {
            int num = numbers[i];

            sum += num;

            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }

        }
        average = sum / total;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);

        #endregion



        #region Methoden Flow controls B
        static void NumberRepeated()
        {
            Console.WriteLine("Give me a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times?");
            int repeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeat; i++)
            {
                Console.Write(x);
            }

        }
        static void MultiplesNumbers()
        {
            for (int i = 0; i < 500; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        static void AccessControl()
        {
            int user;
            int password;
            int attempts = 0;

            do
            {
                Console.WriteLine("Username:");
                user = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Password:");
                password = Convert.ToInt32(Console.ReadLine());

                if ((user != 12) || (password != 1234))
                {
                    Console.WriteLine("Login failed");
                    attempts++;
                }
            }
            while (((user != 12) || (password != 1234)) && (attempts != 3));

            if ((user == 12) || (password == 1234))
                Console.WriteLine("Login successful");
        }
        static void InfiniteDivisions()
        {

            int number1;

            int number2;

            do
            {
                Console.WriteLine("number1:");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("number2:");
                number2 = Convert.ToInt32(Console.ReadLine());


                if (number1 != 0)
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("Division is {0}", number1 / number2);
                        Console.WriteLine("Remainder is {0}", number1 % number2);
                        Console.WriteLine();
                    }

                }
            }
            while (number1 != 0);
            Console.WriteLine("Ciao Ciao");
        }
        static void InfiniteMuliplicationTable()
        {
            Console.WriteLine("Range 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Range 2");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}= {2}", x, i, x * i);
            }
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}= {2}", y, i, y * i);
            }
        }
        static void SwitchBreakAndDefault()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 6:
                    Console.WriteLine("C");
                    break;
                case 5:
                    Console.WriteLine("E");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
        static void RepetitiveStructures()
        {
            Console.WriteLine("HEEE!! gima numbers");
            Console.WriteLine("Erte:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zeite:");
            int y = Convert.ToInt32(Console.ReadLine());
            int i;
            Console.WriteLine();



            Console.WriteLine("for-schleife:");
            for (i = x; i <= y; i++)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();



            Console.WriteLine("while-schleife");
            i = x;
            while (i <= y)
            {

                Console.Write("{0}", i);
                i++;
            }
            Console.WriteLine();



            Console.WriteLine("do-while-schleife");
            i = x;
            do
            {
                Console.Write("{0}", i);
                i++;
            }
            while (i <= y);
            Console.WriteLine();
        }
        static void DigitsInANumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int digits = 0;

            if (number < 0)
            {
                Console.WriteLine("(Warning: it is a negative number)");
                number = -number;
            }
            while (number > 0)
            {
                number /= 10;
                number = number / 10;      ////Der /=-Operator dividiert zunächst den Wert der Variablen oder Eigenschaft (auf der linken Seite des Operators) durch den Wert des Ausdrucks (auf der rechten Seite des Operators). Der Operator weist dann das Gleitkommaergebnis dieses Vorgangs der Variablen oder Eigenschaft zu.
                digits++;
            }
            if (digits == 0)
            {
                digits = 1;
            }

            Console.WriteLine("{0} digitis", digits);
        }
        #endregion


    }

  

    #region Methoden Flow control C
    static void CharAlphabet()
    {

        for (int i = 65; i <= 90; i++)
        {
            Console.Write(Convert.ToChar(i).ToString() + " ");
        }
    }
    #endregion

}
#endregion