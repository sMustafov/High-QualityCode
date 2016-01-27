namespace BasicMathOperations
{
    using System;
    using System.Diagnostics;

    class BasicOperations
    {
        private const int MAX_NUMBER = 500000;

        private const int FirstIntNum = 1;
        private const int SecondIntNum = 10;

        private const long FirstLongNum = 5000;
        private const long SecondLongNum = 10000;

        private const double FirstDoubleNum = 2.5;
        private const double SecondDoubleNum = 5.6;

        private const float FirstFloatNum = 1.23f;
        private const float SecondFloatNum = 3.14f;

        private const decimal FirstDecimalNum = 1.23456m;
        private const decimal SecondDecimalNum = 3.141529m;

        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Addition");

            stopwatch.Start();
            AddIntValues();
            stopwatch.Stop();
            Console.WriteLine("Int: {0}", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            AddLongValues();
            stopwatch.Stop();
            Console.WriteLine("Long: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            AddFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            AddDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            AddDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);

            stopwatch.Reset();

            Console.WriteLine();

            Console.WriteLine("Subtraction");


            stopwatch.Start();
            SubstractIntValues();
            stopwatch.Stop();
            Console.WriteLine("Int: {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractLongValues();
            stopwatch.Stop();
            Console.WriteLine("Long: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            SubstractDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);

            stopwatch.Reset();

            Console.WriteLine();

            Console.WriteLine("Incrementation");

            stopwatch.Start();
            IncrementIntValues();
            stopwatch.Stop();
            Console.WriteLine("Int: {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementLongValues();
            stopwatch.Stop();
            Console.WriteLine("Long: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            IncrementDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Multiplication");

            stopwatch.Start();
            MultiplyIntValues();
            stopwatch.Stop();
            Console.WriteLine("Int: {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyLongValues();
            stopwatch.Stop();
            Console.WriteLine("Long: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            MultiplyDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);

            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Division");

            stopwatch.Start();
            DivideIntValues();
            stopwatch.Stop();
            Console.WriteLine("Int: {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            DivideLongValues();
            stopwatch.Stop();
            Console.WriteLine("Long: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            DivideFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            DivideDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);

            stopwatch.Reset();

            stopwatch.Start();
            DivideDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);

            stopwatch.Reset();
        }

        private static void AddIntValues()
        {
            int result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstIntNum + SecondIntNum;
            }
        }

        private static void AddLongValues()
        {
            long result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstLongNum + SecondLongNum;
            }
        }

        private static void AddDoubleValues()
        {
            double result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDoubleNum + SecondDoubleNum;
            }
        }

        private static void AddFloatValues()
        {
            float result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstFloatNum + SecondFloatNum;
            }
        }

        private static void AddDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDecimalNum + SecondDecimalNum;
            }
        }

        private static void SubstractIntValues()
        {
            int result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstIntNum + SecondIntNum;
            }
        }

        private static void SubstractLongValues()
        {
            long result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstLongNum + SecondLongNum;
            }
        }

        private static void SubstractDoubleValues()
        {
            double result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDoubleNum + SecondDoubleNum;
            }
        }

        private static void SubstractFloatValues()
        {
            float result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstFloatNum + SecondFloatNum;
            }
        }

        private static void SubstractDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDecimalNum + SecondDecimalNum;
            }
        }

        private static void IncrementIntValues()
        {
            int result = 1;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result++;
            }
        }

        private static void IncrementLongValues()
        {
            long result = 1;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result++;
            }
        }

        private static void IncrementDoubleValues()
        {
            double result = 0.1;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result++;
            }
        }

        private static void IncrementFloatValues()
        {
            float result = 0.001f;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstFloatNum + SecondFloatNum;
            }
        }

        private static void IncrementDecimalValues()
        {
            decimal result = 0.01211m;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result++;
            }
        }

        private static void MultiplyIntValues()
        {
            int result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstIntNum * SecondIntNum;
            }
        }

        private static void MultiplyLongValues()
        {
            long result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstLongNum * SecondLongNum;
            }
        }

        private static void MultiplyDoubleValues()
        {
            double result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDoubleNum * SecondDoubleNum;
            }
        }

        private static void MultiplyFloatValues()
        {
            float result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstFloatNum * SecondFloatNum;
            }
        }

        private static void MultiplyDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDecimalNum * SecondDecimalNum;
            }
        }

        private static void DivideIntValues()
        {
            int result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstIntNum / SecondIntNum;
            }
        }

        private static void DivideLongValues()
        {
            long result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstLongNum / SecondLongNum;
            }
        }

        private static void DivideDoubleValues()
        {
            double result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDoubleNum / SecondDoubleNum;
            }
        }

        private static void DivideFloatValues()
        {
            float result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstFloatNum / SecondFloatNum;
            }
        }

        private static void DivideDecimalValues()
        {
            decimal result;

            for (int i = 0; i < MAX_NUMBER; i++)
            {
                result = FirstDecimalNum / SecondDecimalNum;
            }
        }
    }
}
