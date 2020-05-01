using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace mitoSoft.Matrices.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void AddEqualMatrix()
        {
            var matrix = Matrix.Parse(new List<string>() { "1;2;3", "4;5;6" });

            var result = MatrixCalculation.Add(matrix, matrix);

            Assert.AreEqual(2, result[0, 0]);
            Assert.AreEqual(12, result[1, 2]);
        }

        [TestMethod]
        public void SubtractEqualMatrix()
        {
            var matrix = Matrix.Parse(new List<string>() { "1;2;3", "4;5;6" });

            var result = MatrixCalculation.Subtract(matrix, matrix);

            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[1, 2]);
        }

        [TestMethod]
        public void TransposeMatrix()
        {
            var matrix = Matrix.Parse(new List<string>() { "1;2;3", "4;5;6" });

            var result = MatrixCalculation.Transpose(matrix);

            Assert.AreEqual(3, result.RowCount);
            Assert.AreEqual(2, result.ColumnCount);

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(6, result[2, 1]);
        }
    }
}
