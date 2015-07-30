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
            Assert.IsTrue(StringUtils.IsAnyBlank(null, "foo"));
            Assert.IsTrue(StringUtils.IsAnyBlank(null, null));
            Assert.IsTrue(StringUtils.IsAnyBlank("", "bar"));
            Assert.IsTrue(StringUtils.IsAnyBlank("bob", ""));
            Assert.IsTrue(StringUtils.IsAnyBlank("  bob  ", null));
            Assert.IsTrue(StringUtils.IsAnyBlank(" ", "bar"));

            Assert.IsFalse(StringUtils.IsAnyBlank("foo", "bar"));
        }

        [TestMethod]
        public void IsNoneBlankTest()
        {
            Assert.IsFalse(StringUtils.IsNoneBlank(null));
            Assert.IsFalse(StringUtils.IsNoneBlank(null, "foo"));
            Assert.IsFalse(StringUtils.IsNoneBlank(null, null));
            Assert.IsFalse(StringUtils.IsNoneBlank("", "bar"));
            Assert.IsFalse(StringUtils.IsNoneBlank("bob", ""));
            Assert.IsFalse(StringUtils.IsNoneBlank("  bob  ", null));
            Assert.IsFalse(StringUtils.IsNoneBlank(" ", "bar"));

            Assert.IsTrue(StringUtils.IsNoneBlank("foo", "bar"));
        }

        [TestMethod]
        public void TrimTest()
        {
            Assert.AreEqual(null, StringUtils.Trim(null));
            Assert.AreEqual("", StringUtils.Trim(""));
            Assert.AreEqual("", StringUtils.Trim("     "));
            Assert.AreEqual("abc", StringUtils.Trim("abc"));
            Assert.AreEqual("abc", StringUtils.Trim("    abc    "));
        }

        [TestMethod]
        public void TrimToNullTest()
        {
            Assert.AreEqual(null, StringUtils.TrimToNull(null));
            Assert.AreEqual(null, StringUtils.TrimToNull(""));
            Assert.AreEqual(null, StringUtils.TrimToNull("     "));
            Assert.AreEqual("abc", StringUtils.TrimToNull("abc"));
            Assert.AreEqual("abc", StringUtils.TrimToNull("    abc    "));
        }

        [TestMethod]
        public void TrimToEmptyTest()
        {
            Assert.AreEqual("", StringUtils.TrimToEmpty(null));
            Assert.AreEqual("", StringUtils.TrimToEmpty(""));
            Assert.AreEqual("", StringUtils.TrimToEmpty("     "));
            Assert.AreEqual("abc", StringUtils.TrimToEmpty("abc"));
            Assert.AreEqual("abc", StringUtils.TrimToEmpty("    abc    "));
        }

        [TestMethod]
        public void StripTest()
        {
            Assert.AreEqual(null, StringUtils.Strip(null));
            Assert.AreEqual("", StringUtils.Strip(""));
            Assert.AreEqual("", StringUtils.Strip("   "));
            Assert.AreEqual("abc", StringUtils.Strip("abc"));
            Assert.AreEqual("abc", StringUtils.Strip("  abc"));
            Assert.AreEqual("abc", StringUtils.Strip("abc  "));
            Assert.AreEqual("abc", StringUtils.Strip(" abc "));
            Assert.AreEqual("ab c", StringUtils.Strip(" ab c "));
        }

        [TestMethod]
        public void StripToNullTest()
        {
            Assert.AreEqual(null, StringUtils.StripToNull(null));
            Assert.AreEqual(null, StringUtils.StripToNull(""));
            Assert.AreEqual(null, StringUtils.StripToNull("   "));
            Assert.AreEqual("abc", StringUtils.StripToNull("abc"));
            Assert.AreEqual("abc", StringUtils.StripToNull("  abc"));
            Assert.AreEqual("abc", StringUtils.StripToNull("abc  "));
            Assert.AreEqual("abc", StringUtils.StripToNull(" abc "));
            Assert.AreEqual("ab c", StringUtils.StripToNull(" ab c "));
        }

        [TestMethod]
        public void StripToEmptyTest()
        {
            Assert.AreEqual("", StringUtils.StripToEmpty(null));
            Assert.AreEqual("", StringUtils.StripToEmpty(""));
            Assert.AreEqual("", StringUtils.StripToEmpty("   "));
            Assert.AreEqual("abc", StringUtils.StripToEmpty("abc"));
            Assert.AreEqual("abc", StringUtils.StripToEmpty("  abc"));
            Assert.AreEqual("abc", StringUtils.StripToEmpty("abc  "));
            Assert.AreEqual("abc", StringUtils.StripToEmpty(" abc "));
            Assert.AreEqual("ab c", StringUtils.StripToEmpty(" ab c "));
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
