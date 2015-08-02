namespace CommonLib.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using t7.common;

    [TestClass()]
    public class NumberUtilsTests
    {
        [TestMethod()]
        public void ToIntTest()
        {
            Assert.AreEqual(0, NumberUtils.ToInt("0"));
            Assert.AreEqual(1, NumberUtils.ToInt("1"));
            Assert.AreEqual(0, NumberUtils.ToInt(""));
            Assert.AreEqual(0, NumberUtils.ToInt("a"));
            Assert.AreEqual(-1, NumberUtils.ToInt("-1"));
        }

        [TestMethod()]
        public void IsIntTest()
        {
            Assert.IsTrue(NumberUtils.IsInt("0"));
            Assert.IsTrue(NumberUtils.IsInt("-1"));
            Assert.IsFalse(NumberUtils.IsInt(""));
            Assert.IsFalse(NumberUtils.IsInt("a"));
        }
    }
}