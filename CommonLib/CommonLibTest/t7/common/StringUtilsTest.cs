using t7.common;

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
        public void StripCharsTest()
        {
            Assert.AreEqual(null, StringUtils.Strip(null, null));
            Assert.AreEqual("", StringUtils.Strip("", null));
            Assert.AreEqual("abc", StringUtils.Strip("abc", null));
            Assert.AreEqual("abc", StringUtils.Strip("  abc", null));
            Assert.AreEqual("abc", StringUtils.Strip("abc  ", null));
            Assert.AreEqual("abc", StringUtils.Strip(" abc ", null));
            Assert.AreEqual("  abc", StringUtils.Strip("  abcyx", "xyz"));
        }

        [TestMethod]
        public void StripStartTest()
        {
            Assert.AreEqual(null, StringUtils.StripStart(null, null));
            Assert.AreEqual("", StringUtils.StripStart("", null));
            Assert.AreEqual("abc", StringUtils.StripStart("abc", ""));
            Assert.AreEqual("abc", StringUtils.StripStart("abc", null));
            Assert.AreEqual("abc", StringUtils.StripStart("  abc", null));
            Assert.AreEqual("abc  ", StringUtils.StripStart("abc  ", null));
            Assert.AreEqual("abc ", StringUtils.StripStart(" abc ", null));
            Assert.AreEqual("abc  ", StringUtils.StripStart("yxabc  ", "xyz"));
        }

        [TestMethod]
        public void StripEndTest()
        {
            Assert.AreEqual(null, StringUtils.StripEnd(null, null));
            Assert.AreEqual("", StringUtils.StripEnd("", null));
            Assert.AreEqual("abc", StringUtils.StripEnd("abc", ""));
            Assert.AreEqual("abc", StringUtils.StripEnd("abc", null));
            Assert.AreEqual("  abc", StringUtils.StripEnd("  abc", null));
            Assert.AreEqual("abc", StringUtils.StripEnd("abc  ", null));
            Assert.AreEqual(" abc", StringUtils.StripEnd(" abc ", null));
            Assert.AreEqual("  abc", StringUtils.StripEnd("  abcyx", "xyz"));
            Assert.AreEqual("12", StringUtils.StripEnd("120.00", ".0"));
        }

        [TestMethod]
        public void StripAllTest()
        {
            Assert.AreEqual(null, StringUtils.StripAll(null));
            CollectionAssert.AreEqual(new string[0], StringUtils.StripAll(new string[0]));
            CollectionAssert.AreEqual(new string[] { "abc", "abc" }, StringUtils.StripAll(new string[] { "abc", "  abc" }));
            CollectionAssert.AreEqual(new string[] { "abc", null }, StringUtils.StripAll(new string[] { "abc  ", null }));
        }

        [TestMethod]
        public void StripAllStripCharsTest()
        {
            Assert.AreEqual(null, StringUtils.StripAll(null, null));
            CollectionAssert.AreEqual(new string[0], StringUtils.StripAll(new string[0], null));
            CollectionAssert.AreEqual(new string[] { "abc", "abc" }, StringUtils.StripAll(new string[] { "abc", "  abc" }, null));
            CollectionAssert.AreEqual(new string[] { "abc", null }, StringUtils.StripAll(new string[] { "abc  ", null }, null));
            CollectionAssert.AreEqual(new string[] { "abc  ", null }, StringUtils.StripAll(new string[] { "abc  ", null }, "yz"));
            CollectionAssert.AreEqual(new string[] { "abc", null }, StringUtils.StripAll(new string[] { "yabcz", null }, "yz"));
        }

        [TestMethod]
        public void EqualTest()
        {
            Assert.IsTrue(StringUtils.Equals(null, null));
            Assert.IsTrue(StringUtils.Equals("abc", "abc"));

            Assert.IsFalse(StringUtils.Equals(null, "abc"));
            Assert.IsFalse(StringUtils.Equals("abc", null));
            Assert.IsFalse(StringUtils.Equals("abc", "ABC"));
        }

        [TestMethod]
        public void EqualsIgnoreCaseTest()
        {
            Assert.IsTrue(StringUtils.EqualsIgnoreCase(null, null));
            Assert.IsTrue(StringUtils.EqualsIgnoreCase("abc", "abc"));
            Assert.IsTrue(StringUtils.EqualsIgnoreCase("abc", "ABC"));

            Assert.IsFalse(StringUtils.EqualsIgnoreCase(null, "abc"));
            Assert.IsFalse(StringUtils.EqualsIgnoreCase("abc", null));
        }

        [TestMethod]
        public void IndexOfTest()
        {
            Assert.AreEqual(-1, StringUtils.IndexOf(null, ' '));
            Assert.AreEqual(-1, StringUtils.IndexOf("", ' '));
            Assert.AreEqual(0, StringUtils.IndexOf("aabaabaa", 'a'));
            Assert.AreEqual(2, StringUtils.IndexOf("aabaabaa", 'b'));
        }

        [TestMethod]
        public void IndexOfStartPosTest()
        {
            Assert.AreEqual(-1, StringUtils.IndexOf(null, ' ', 1));
            Assert.AreEqual(-1, StringUtils.IndexOf("", ' ', 1));
            Assert.AreEqual(2, StringUtils.IndexOf("aabaabaa", 'b', 0));
            Assert.AreEqual(5, StringUtils.IndexOf("aabaabaa", 'b', 3));
            Assert.AreEqual(-1, StringUtils.IndexOf("aabaabaa", 'b', 9));
            Assert.AreEqual(2, StringUtils.IndexOf("aabaabaa", 'b', -1));
        }

        [TestMethod]
        public void IndexOfStringTest()
        {
            Assert.AreEqual(-1, StringUtils.IndexOf(null, "", 1));
            Assert.AreEqual(-1, StringUtils.IndexOf("", null, 1));
            Assert.AreEqual(0, StringUtils.IndexOf("", "", 0));
            Assert.AreEqual(-1, StringUtils.IndexOf("", "a", 0));
            Assert.AreEqual(0, StringUtils.IndexOf("aabaabaa", "a", 0));
            Assert.AreEqual(2, StringUtils.IndexOf("aabaabaa", "b", 0));
            Assert.AreEqual(1, StringUtils.IndexOf("aabaabaa", "ab", 0));
            Assert.AreEqual(5, StringUtils.IndexOf("aabaabaa", "b", 3));
            Assert.AreEqual(-1, StringUtils.IndexOf("aabaabaa", "b", 9));
            Assert.AreEqual(2, StringUtils.IndexOf("aabaabaa", "b", -1));
            Assert.AreEqual(2, StringUtils.IndexOf("aabaabaa", "", 2));
            Assert.AreEqual(3, StringUtils.IndexOf("abc", "", 9));
        }
    }
}
