using System;

namespace Tasks1_Library
{
    public class TaskHelper
    {
        public static double Solve(double a, double b)
        {
            if (a != b)
            {
                return (5 * a + b * b) / (b - a);
            }

            throw new DivideByZeroException();
        }

        public static void Swap(ref double a, ref double b)
        {
            double c = b;
            b = a;
            a = c;
        }

        public static int GetDivisionResult(int a, int b)
        {
            return a / b;
        }

        public static int GetReminderOfTheDivisionResult(int a, int b)
        {
            return a % b;
        }

        public static double Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            return (c - b) / a;
        }

        public static (double a, double b) Solve(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException();
            }

            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;

            return (a, b);
        }
    }
}
