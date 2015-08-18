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

        [TestMethod()]
        public void DiffDaysTest()
        {
            Assert.AreEqual(0, DateUtils.DiffDays(new DateTime(2015, 1, 1), new DateTime(2015, 1, 1)));
            Assert.AreEqual(1, DateUtils.DiffDays(new DateTime(2015, 1, 2), new DateTime(2015, 1, 1)));
            Assert.AreEqual(1, DateUtils.DiffDays(new DateTime(2015, 1, 1), new DateTime(2015, 1, 2)));
        }

        [TestMethod()]
        public void DiffHoursTest()
        {
            Assert.AreEqual(0, DateUtils.DiffHours(new DateTime(2015, 1, 1, 1, 0, 0), new DateTime(2015, 1, 1, 1, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffHours(new DateTime(2015, 1, 1, 1, 0, 0), new DateTime(2015, 1, 1, 2, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffHours(new DateTime(2015, 1, 1, 2, 0, 0), new DateTime(2015, 1, 1, 1, 0, 0)));
        }

        [TestMethod()]
        public void DiffMinutesTest()
        {
            Assert.AreEqual(0, DateUtils.DiffMinutes(new DateTime(2015, 1, 1, 1, 0, 0), new DateTime(2015, 1, 1, 1, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffMinutes(new DateTime(2015, 1, 1, 1, 1, 0), new DateTime(2015, 1, 1, 1, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffMinutes(new DateTime(2015, 1, 1, 1, 0, 0), new DateTime(2015, 1, 1, 1, 1, 0)));
        }

        [TestMethod()]
        public void DiffSecondsTest()
        {
            Assert.AreEqual(0, DateUtils.DiffSeconds(new DateTime(2015, 1, 1, 1, 0, 0), new DateTime(2015, 1, 1, 1, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffSeconds(new DateTime(2015, 1, 1, 1, 0, 1), new DateTime(2015, 1, 1, 1, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffSeconds(new DateTime(2015, 1, 1, 1, 0, 0), new DateTime(2015, 1, 1, 1, 0, 1)));
        }

        [TestMethod()]
        public void DiffMillisecondsTest()
        {
            Assert.AreEqual(0, DateUtils.DiffMilliseconds(new DateTime(2015, 1, 1, 1, 0, 0, 0), new DateTime(2015, 1, 1, 1, 0, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffMilliseconds(new DateTime(2015, 1, 1, 1, 0, 0, 1), new DateTime(2015, 1, 1, 1, 0, 0, 0)));
            Assert.AreEqual(1, DateUtils.DiffMilliseconds(new DateTime(2015, 1, 1, 1, 0, 0, 0), new DateTime(2015, 1, 1, 1, 0, 0, 1)));
        }
    }
}