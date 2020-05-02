using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace mitoSoft.Matrices.Tests
{
    [TestClass]
    public class CreationTests
    {
        [TestMethod]
        public void ThreeRows()
        {
            var matrix = Matrix.Parse(new List<string>() { "1.2; 3.4; 5.6", "1.4; 1.6  ;2", "7.2 ;4.5;4.5" });

            Assert.AreEqual(3, matrix.RowCount);
            Assert.AreEqual(3, matrix.ColumnCount);
        }

        [TestMethod]
        public void TwoRows()
        {
            var matrix = Matrix.Parse(new List<string>() { "1.2; 3.4; 5.6", "1.4; 1.6  ;2" });

            Assert.AreEqual(2, matrix.RowCount);
            Assert.AreEqual(3, matrix.ColumnCount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidRowLength()
        {
            var _ = Matrix.Parse(new List<string>() { "1.2; 3.4; 5.6", "1.4; 1.6", "7.2 ;4.5;4.5" });
        }

        [TestMethod]
        public void GermanNumberFormat()
        {
            var matrix = Matrix.Parse(new List<string>() { "1,2; 3.4; 5.6", "1.4; 1.6; 3", "7.2 ;4.5;4.5" });

            Assert.AreEqual(3, matrix.RowCount);
            Assert.AreEqual(3, matrix.ColumnCount);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidNumberFormat()
        {
            var _ = Matrix.Parse(new List<string>() { "Hurz; 3.4; 5.6", "1.4; 1.6; 3", "7.2 ;4.5;4.5" });
        }
    }
}