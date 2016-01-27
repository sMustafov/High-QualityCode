namespace AdditionalMathOperations
{
    using System;
    using System.Diagnostics;

    class AdditionalOperations
    {
        private const int MAX_NUMBER = 1000000;

        private const float FloatValue = 1.1f;
        private const double DoubleValue = 1.1;
        private const decimal DecimalValue = 1.1m;

        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Square Root");

            stopwatch.Start();
            SquareRootOnFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SquareRootOnDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SquareRootOnDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Natural Logarithm");

            stopwatch.Start();
            LogOnFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            LogOnDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            LogOnDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();
            Console.WriteLine("Sine");

            stopwatch.Start();
            SinOnFloatValues();
            stopwatch.Stop();
            Console.WriteLine("Float: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SinOnDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("Double: " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SinOnDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);
            stopwatch.Reset();
        }

        private static void SquareRootOnFloatValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Sqrt(FloatValue);
            }
        }

        private static void SquareRootOnDoubleValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Sqrt(DoubleValue);
            }
        }

        private static void SquareRootOnDecimalValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Sqrt((double)DecimalValue);
            }
        }

        private static void LogOnFloatValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Log(FloatValue);
            }
        }

        private static void LogOnDoubleValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Log(DoubleValue);
            }
        }

        private static void LogOnDecimalValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Log((double)DecimalValue);
            }
        }

        private static void SinOnFloatValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Sin(FloatValue);
            }
        }

        private static void SinOnDoubleValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Sin(DoubleValue);
            }
        }

        private static void SinOnDecimalValues()
        {
            for (int i = 0; i < MAX_NUMBER; i++)
            {
                Math.Sin((double)DecimalValue);
            }
        }
    }
}
