using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace MonthTests
{
    [TestClass]
    public class MonthTest
    {
        [TestMethod]
        [TestCase(2, 6.9444444444444437E-07)]
        public void SecondToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.SecondToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 4.1666666666666665E-05)]
        public void MuniteToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MuniteToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.0025000000000000001)]
        public void HourToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.HourToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.06)]
        public void DayToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.DayToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 0.46)]
        public void WeekToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.WeekToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void MonthToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MonthToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 24)]
        public void YearToMonth(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.YearToMonth(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }
    }
}
