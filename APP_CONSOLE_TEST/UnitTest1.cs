using NUnit.Framework;
using TP_APP_CONSOLE;

namespace TP_APP_CONSOLE_Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Solve_WhenAIsZero_AndBIsZero_ReturnsNoSolution()
        {
            // Arrange
            double a = 0;
            double b = 0;
            double c = 5;

            // Act
            Solution result = Program.Solve(a, b, c);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void Solve_WhenAIsZero_AndBIsNonZero_ReturnsOneSolution()
        {
            // Arrange
            double a = 0;
            double b = 2;
            double c = -4;

            // Act
            Solution result = Program.Solve(a, b, c);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(2, result.X1);
        }

        [Test]
        public void Solve_WhenDeltaIsPositive_ReturnsTwoSolutions()
        {
            // Arrange
            double a = 1;
            double b = -3;
            double c = 2;

            // Act
            Solution result = Program.Solve(a, b, c);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result.X1);
            Assert.AreEqual(1, result.X2);
        }

        [Test]
        public void Solve_WhenDeltaIsZero_ReturnsOneSolution()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 1;

            // Act
            Solution result = Program.Solve(a, b, c);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(-1, result.X1);
        }

        [Test]
        public void Solve_WhenDeltaIsNegative_ReturnsNoSolution()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 5;

            // Act
            Solution result = Program.Solve(a, b, c);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
