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
        public void TestIsAnyEmpty()
        {
            Assert.IsTrue(StringUtils.IsAnyEmpty(null));
            Assert.IsTrue(StringUtils.IsAnyEmpty(null, "a"));
            Assert.IsTrue(StringUtils.IsAnyEmpty("", "a"));
            Assert.IsTrue(StringUtils.IsAnyEmpty("a", ""));

            Assert.IsFalse(StringUtils.IsAnyEmpty(" ", "a"));
            Assert.IsFalse(StringUtils.IsAnyEmpty("a", "b"));
        }

        [TestMethod]
        public void TestIsNoneEmpty()
        {
            Assert.IsFalse(StringUtils.IsNoneEmpty(null));
            Assert.IsFalse(StringUtils.IsNoneEmpty(null, "a"));
            Assert.IsFalse(StringUtils.IsNoneEmpty("", "a"));
            Assert.IsFalse(StringUtils.IsNoneEmpty("a", ""));

            Assert.IsTrue(StringUtils.IsNoneEmpty(" ", "a"));
            Assert.IsTrue(StringUtils.IsNoneEmpty("a", "b"));
        }

        [TestMethod]
        public void TestIsBlank()
        {
            Assert.IsTrue(StringUtils.IsBlank(null));
            Assert.IsTrue(StringUtils.IsBlank(""));
            Assert.IsTrue(StringUtils.IsBlank(" "));
            Assert.IsTrue(StringUtils.IsBlank("  "));
            Assert.IsTrue(StringUtils.IsBlank("　"));

            Assert.IsFalse(StringUtils.IsBlank("a"));
            Assert.IsFalse(StringUtils.IsBlank(" a "));
        }

        [TestMethod]
        public void TestIsNotBlank()
        {
            Assert.IsFalse(StringUtils.IsNotBlank(null));
            Assert.IsFalse(StringUtils.IsNotBlank(""));
            Assert.IsFalse(StringUtils.IsNotBlank(" "));
            Assert.IsFalse(StringUtils.IsNotBlank("  "));
            Assert.IsFalse(StringUtils.IsNotBlank("　"));

            Assert.IsTrue(StringUtils.IsNotBlank("a"));
            Assert.IsTrue(StringUtils.IsNotBlank(" a "));
        }

        [TestMethod]
        public void TestIsAnyBlank()
        {
            Assert.IsTrue(StringUtils.IsAnyBlank(null));
            Assert.IsTrue(StringUtils.IsAnyBlank(null, "a"));
            Assert.IsTrue(StringUtils.IsAnyBlank(null, null));
            Assert.IsTrue(StringUtils.IsAnyBlank("", "a"));
            Assert.IsTrue(StringUtils.IsAnyBlank("a", ""));
            Assert.IsTrue(StringUtils.IsAnyBlank(" ", "a"));

            Assert.IsFalse(StringUtils.IsAnyBlank("a", "b"));
        }

        [TestMethod]
        public void TestIsNoneBlank()
        {
            Assert.IsFalse(StringUtils.IsNoneBlank(null));
            Assert.IsFalse(StringUtils.IsNoneBlank(null, "a"));
            Assert.IsFalse(StringUtils.IsNoneBlank(null, null));
            Assert.IsFalse(StringUtils.IsNoneBlank("", "a"));
            Assert.IsFalse(StringUtils.IsNoneBlank("a", ""));
            Assert.IsFalse(StringUtils.IsNoneBlank(" ", "a"));

            Assert.IsTrue(StringUtils.IsNoneBlank("a", "b"));
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
