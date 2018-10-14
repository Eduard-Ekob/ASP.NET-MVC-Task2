using System;
using BitManipulation;
using static BitManipulation.InsertNumberLib;

using NUnit.Framework;

namespace InsertNumberLibNUnitTests
{
    [TestFixture]
    public class InsertNumberLibTests
    {
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        public int InsertNumberMethod_TakeNumbers_ReturnCombinedNumbers(int numbSource, int numbIn, int indI, int indJ)
            => InsertNumber(numbSource, numbIn, indI, indJ);
        [Test]
        public void InsertNumberMethod_WithArg_I_isLowerThan_J_ThrowsArgumentException()
        {
            Assert.That(()=>InsertNumber(15,15,15,14), Throws.Exception.TypeOf<ArgumentException>());
        }
        [Test]
        public void InsertNumberMethod_WithArg_J_isHigherThan_31_ThrowsArgumentException()
        {
            Assert.That(() => InsertNumber(15, 15, 15, 32), Throws.Exception.TypeOf<ArgumentException>());
        }
        [Test]
        public void InsertNumberMethod_WithArg_IorJ_IsNegative_ThrowsArgumentException()
        {
            Assert.That(() => InsertNumber(15, 15, -2, 3), Throws.Exception.TypeOf<ArgumentException>());
        }



    }
}
