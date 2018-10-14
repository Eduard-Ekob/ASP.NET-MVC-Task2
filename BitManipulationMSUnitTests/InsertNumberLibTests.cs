using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitManipulation;
using static BitManipulation.InsertNumberLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation.Tests
{
    [TestClass]
    public class InsertNumberLibTests
    {
        [TestMethod]
        public void InsertNumberMethod_TakeNumbers_ReturnCombinedNumbers()
        {
            //Assert
            int expected120 = 120;
            int expected9 = 9;
            int expected15 = 15;

            //Act
            int result120 = InsertNumber(8, 15, 3, 8);
            int result9 = InsertNumber(8, 15, 0, 0);
            int result15 = InsertNumber(15, 15, 0, 0);

            //Assert
            Assert.AreEqual(expected120, result120);
            Assert.AreEqual(expected9, result9);
            Assert.AreEqual(expected15, result15);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumberMethod_WithArg_I_isLowerThan_J_ThrowsArgumentException()
            => InsertNumber(15, 15, 15, 14);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumberMethod_WithArg_J_isHigherThan_31_ThrowsArgumentException()
            => InsertNumber(15, 15, 15, 32);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumberMethod_WithArg_IorJ_IsNegative_ThrowsArgumentException()
            => InsertNumber(15, 15, -2, 3);

    }

}