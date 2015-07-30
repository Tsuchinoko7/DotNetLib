namespace CommonLib.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using t7.common;

    [TestClass()]
    public class StringUtilsTest
    {
        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(StringUtils.IsEmpty(null));
            Assert.IsTrue(StringUtils.IsEmpty(""));

            Assert.IsFalse(StringUtils.IsEmpty(" "));
            Assert.IsFalse(StringUtils.IsEmpty("bob"));
            Assert.IsFalse(StringUtils.IsEmpty("  bob  "));
        }

        [TestMethod]
        public void IsNotEmptyTest()
        {
            Assert.IsFalse(StringUtils.IsNotEmpty(null));
            Assert.IsFalse(StringUtils.IsNotEmpty(""));

            Assert.IsTrue(StringUtils.IsNotEmpty(" "));
            Assert.IsTrue(StringUtils.IsNotEmpty("bob"));
            Assert.IsTrue(StringUtils.IsNotEmpty("  bob  "));
        }

        [TestMethod]
        public void IsAnyEmptyTest()
        {
            Assert.IsTrue(StringUtils.IsAnyEmpty(null));
            Assert.IsTrue(StringUtils.IsAnyEmpty(null, "foo"));
            Assert.IsTrue(StringUtils.IsAnyEmpty("", "bar"));
            Assert.IsTrue(StringUtils.IsAnyEmpty("bob", ""));
            Assert.IsTrue(StringUtils.IsAnyEmpty("  bob  ", null));

            Assert.IsFalse(StringUtils.IsAnyEmpty(" ", "bar"));
            Assert.IsFalse(StringUtils.IsAnyEmpty("foo", "bar"));
        }

        [TestMethod]
        public void IsNoneEmptyTest()
        {
            Assert.IsFalse(StringUtils.IsNoneEmpty(null));
            Assert.IsFalse(StringUtils.IsNoneEmpty(null, "foo"));
            Assert.IsFalse(StringUtils.IsNoneEmpty("", "bar"));
            Assert.IsFalse(StringUtils.IsNoneEmpty("bob", ""));
            Assert.IsFalse(StringUtils.IsNoneEmpty("  bob  ", null));

            Assert.IsTrue(StringUtils.IsNoneEmpty(" ", "bar"));
            Assert.IsTrue(StringUtils.IsNoneEmpty("foo", "bar"));
        }

        [TestMethod]
        public void IsBlankTest()
        {
            Assert.IsTrue(StringUtils.IsBlank(null));
            Assert.IsTrue(StringUtils.IsBlank(""));
            Assert.IsTrue(StringUtils.IsBlank(" "));
            Assert.IsTrue(StringUtils.IsBlank("  "));
            Assert.IsTrue(StringUtils.IsBlank("　"));

            Assert.IsFalse(StringUtils.IsBlank("bob"));
            Assert.IsFalse(StringUtils.IsBlank("  bob  "));
        }

        [TestMethod]
        public void IsNotBlankTest()
        {
            Assert.IsFalse(StringUtils.IsNotBlank(null));
            Assert.IsFalse(StringUtils.IsNotBlank(""));
            Assert.IsFalse(StringUtils.IsNotBlank(" "));
            Assert.IsFalse(StringUtils.IsNotBlank("  "));
            Assert.IsFalse(StringUtils.IsNotBlank("　"));

            Assert.IsTrue(StringUtils.IsNotBlank("bob"));
            Assert.IsTrue(StringUtils.IsNotBlank("  bob  "));
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
