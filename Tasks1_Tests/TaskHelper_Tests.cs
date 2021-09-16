using NUnit.Framework;
using System;
using Tasks1_Library;

namespace Tasks1_Tests
{
    public class TaskHelper_Tests
    {
        [TestCase(2, 1, -11)]
        [TestCase(5, 6, 61)]
        public void Solve_WhenAAndBAreCorrect_ShouldCalculateEquation(int a, int b, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.Solve(a, b));
        }

        [Test]
        public void Solve_WhenAEqualB_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                TaskHelper.Solve(5, 5);
            });
        }

        [TestCase(2, 1, 1, 2)]
        [TestCase(8, 3, 3, 8)]
        [TestCase(-8, -3, -3, -8)]
        [TestCase(5, 0, 0, 5)]
        [TestCase(8.1, 3.4, 3.4, 8.1)]
        [TestCase(-8.2, -3.2, -3.2, -8.2)]
        [TestCase(5.5, 0, 0, 5.5)]
        public void Swap_WhenAnyAAndB_ShouldSwapAToB(
            double a, double b, double expectedA, double expectedB)
        {
            TaskHelper.Swap(ref a, ref b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        [TestCase(8, 2, 4)]
        [TestCase(-6, 3, -2)]
        [TestCase(0, 2, 0)]
        [TestCase(10, -2, -5)]
        [TestCase(10, 3, 3)]
        [TestCase(17, 2, 8)]
        public void GetDivisionResult_WhenBIsNotZero_ShouldADivideB(
            int a, int b, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.GetDivisionResult(a, b));
        }

        [Test]
        public void GetDivisionResult_WhenBIsZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                TaskHelper.GetDivisionResult(5, 0);
            });
        }

        [TestCase(8, 2, 0)]
        [TestCase(-7, 3, -1)]
        [TestCase(0, 2, 0)]
        [TestCase(13, -2, 1)]
        [TestCase(20, 3, 2)]
        [TestCase(17, 2, 1)]
        public void GetReminderOfTheDivisionResult_WhenBIsNotZero_ShouldADivideB(
            int a, int b, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.GetReminderOfTheDivisionResult(a, b));
        }

        [Test]
        public void GetReminderOfTheDivisionResult_WhenBIsZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                TaskHelper.GetReminderOfTheDivisionResult(3, 0);
            });
        }

        [TestCase(5, 2, 12, 2)]
        [TestCase(4, 4, 20, 4)]
        [TestCase(11, -4, -48, -4)]
        [TestCase(0.5, 1.5, 2.5, 2)]
        public void Solve_WhenAIsNotZero_ShouldSolveEquation(
            double a, double b, double c, double expected)
        {
            Assert.AreEqual(expected, TaskHelper.Solve(a, b, c));
        }

        [Test]
        public void Solve_WhenAIsZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                TaskHelper.Solve(0, 3, 5);
            });
        }

        [TestCase(2, 4, 10, 8, 0.5, 3)]
        [TestCase(2, -3, 4, -6, -1.5, 0)]
        public void Solve_WhenX1IsNotEqualX2_ShouldSolveEquation(
           double x1, double y1, double x2, double y2, double a, double b)
        {
            Assert.AreEqual((a, b), TaskHelper.Solve(x1, y1, x2, y2));
        }

        [Test]
        public void Solve_WhenX1IsEqualX2_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                TaskHelper.Solve(-5, 3, -5, 4);
            });
        }
    }
}