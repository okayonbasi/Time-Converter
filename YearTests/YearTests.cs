using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace YearTests
{
    [TestClass]
    public class YearTests
    {
        [TestMethod]
        [TestCase(88899888, 2.8192788555555555)]
        public void SecondToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.SecondToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 3.8055555555555552E-06)]
        public void MuniteToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MuniteToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.00022833333333333332)]
        public void HourToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.HourToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.0054799999999999996)]
        public void DayToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.DayToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.04)]
        public void WeekToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.WeekToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.16666666660000001)]
        public void MonthToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MonthToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void YearToYear(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.YearToYear(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }
    }
}
