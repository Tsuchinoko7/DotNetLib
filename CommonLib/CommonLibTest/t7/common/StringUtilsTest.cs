using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonLib;

namespace CommonLib.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CommonLib;

    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(StringUtils.IsEmpty(null));
            Assert.IsTrue(StringUtils.IsEmpty(""));

            Assert.IsFalse(StringUtils.IsEmpty(" "));
            Assert.IsFalse(StringUtils.IsEmpty("a"));
            Assert.IsFalse(StringUtils.IsEmpty(" a "));
        }

        [TestMethod]
        public void IsNotEmptyTest()
        {
            Assert.IsFalse(StringUtils.IsNotEmpty(null));
            Assert.IsFalse(StringUtils.IsNotEmpty(""));

            Assert.IsTrue(StringUtils.IsNotEmpty(" "));
            Assert.IsTrue(StringUtils.IsNotEmpty("a"));
            Assert.IsTrue(StringUtils.IsNotEmpty(" a "));
        }

        [TestMethod]
        public void IsAnyEmptyTest()
        {
            Assert.IsTrue(StringUtils.IsAnyEmpty(null));
            Assert.IsTrue(StringUtils.IsAnyEmpty(null, "a"));
            Assert.IsTrue(StringUtils.IsAnyEmpty("", "a"));
            Assert.IsTrue(StringUtils.IsAnyEmpty("a", ""));

            Assert.IsFalse(StringUtils.IsAnyEmpty(" ", "a"));
            Assert.IsFalse(StringUtils.IsAnyEmpty("a", "b"));
        }

        [TestMethod]
        public void IsNoneEmptyTest()
        {
            Assert.IsFalse(StringUtils.IsNoneEmpty(null));
            Assert.IsFalse(StringUtils.IsNoneEmpty(null, "a"));
            Assert.IsFalse(StringUtils.IsNoneEmpty("", "a"));
            Assert.IsFalse(StringUtils.IsNoneEmpty("a", ""));

            Assert.IsTrue(StringUtils.IsNoneEmpty(" ", "a"));
            Assert.IsTrue(StringUtils.IsNoneEmpty("a", "b"));
        }

        [TestMethod]
        public void IsBlankTest()
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
        public void IsNotBlankTest()
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
        public void IsAnyBlankTest()
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
        public void IsNoneBlankTest()
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
        public void TrimTest()
        {
            Assert.AreEqual(null, StringUtils.Trim(null));
            Assert.AreEqual("", StringUtils.Trim(""));
            Assert.AreEqual("", StringUtils.Trim(" "));
            Assert.AreEqual("a", StringUtils.Trim("a"));
            Assert.AreEqual("a", StringUtils.Trim(" a "));
        }

        [TestMethod]
        public void TrimToNullest()
        {
            Assert.AreEqual(null, StringUtils.TrimToNull(null));
            Assert.AreEqual(null, StringUtils.TrimToNull(""));
            Assert.AreEqual(null, StringUtils.TrimToNull(" "));
            Assert.AreEqual("a", StringUtils.TrimToNull("a"));
            Assert.AreEqual("a", StringUtils.TrimToNull(" a "));
        }

        [TestMethod]
        public void EqualTest()
        {
            Assert.IsTrue(StringUtils.Equals(null, null));
            Assert.IsTrue(StringUtils.Equals("a", "a"));

            Assert.IsFalse(StringUtils.Equals(null, "a"));
            Assert.IsFalse(StringUtils.Equals("a", null));
            Assert.IsFalse(StringUtils.Equals("a", "A"));
        }
    }
}
