namespace CommonLibTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CommonLib;

    [TestClass]
    public class StringUtilsTest
    {
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
