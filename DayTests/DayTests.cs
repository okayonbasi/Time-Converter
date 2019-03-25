using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace DayTests
{
    [TestClass]
    public class DayTests
    {
        [TestMethod]
        [TestCase(1, 1.1574)]
        public void SecondToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.SecondToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.0013888888888888887)]
        public void MuniteToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MuniteToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.083333333333333329)]
        public void HourToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.HourToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void DayToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.DayToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 14)]
        public void WeekToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.WeekToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 60.875)]
        public void MonthToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MonthToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 730.5)]
        public void YearToDay(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.YearToDay(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }
    }
}
