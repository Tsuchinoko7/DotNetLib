namespace CommonLibTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CommonLib;

    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.IsTrue(StringUtils.IsEmpty(null));
            Assert.IsTrue(StringUtils.IsEmpty(""));
            
            Assert.IsFalse(StringUtils.IsEmpty(" "));
            Assert.IsFalse(StringUtils.IsEmpty("a"));
            Assert.IsFalse(StringUtils.IsEmpty(" a "));
        }

        [TestMethod]
        public void TestIsNotEmpty()
        {
            Assert.IsFalse(StringUtils.IsNotEmpty(null));
            Assert.IsFalse(StringUtils.IsNotEmpty(""));

            Assert.IsTrue(StringUtils.IsNotEmpty(" "));
            Assert.IsTrue(StringUtils.IsNotEmpty("a"));
            Assert.IsTrue(StringUtils.IsNotEmpty(" a "));
        }

        [TestMethod]
        public void TestEqual()
        {
            Assert.IsTrue(StringUtils.Equals(null, null));
            Assert.IsTrue(StringUtils.Equals("a", "a"));
            
            Assert.IsFalse(StringUtils.Equals(null, "a"));
            Assert.IsFalse(StringUtils.Equals("a", null));
            Assert.IsFalse(StringUtils.Equals("a", "A"));
        }
    }
}
