namespace t7.common.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass()]
    public class DateUtilsTests
    {
        [TestMethod()]
        public void ToDateTest()
        {
            Assert.AreEqual(DateUtils.ToDate("2015/01/01"), new DateTime(2015, 1, 1));
            Assert.AreEqual(DateUtils.ToDate("2015/01/01 23:59:59"), new DateTime(2015, 1, 1, 23, 59, 59));
            Assert.AreEqual(DateUtils.ToDate("2015-01-01"), new DateTime(2015, 1, 1));
            Assert.AreEqual(DateUtils.ToDate("2015-01-01 23:59:59"), new DateTime(2015, 1, 1, 23, 59, 59));
        }

        [TestMethod()]
        public void IsDateTest()
        {
            Assert.IsTrue(DateUtils.IsDate("2015/01/01"));
            Assert.IsTrue(DateUtils.IsDate("2015-01-01"));

            Assert.IsFalse(DateUtils.IsDate("2015/13/01"));
            Assert.IsFalse(DateUtils.IsDate("2015-13-01"));
        }
    }
}