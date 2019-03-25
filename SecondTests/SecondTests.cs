using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace SecondTests
{
    [TestClass]
    public class SecondTests
    {
        [TestMethod]
        [TestCase(2, 2)]
        public void SecondToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.SecondToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2,120)]
        public void MuniteToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MuniteToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 7200)]
        public void HourToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.HourToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 172800)]
        public void DayToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.DayToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 1209600.04)]
        public void WeekToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.WeekToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 5259600)]
        public void MonthToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MonthToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 63115200)]
        public void YearToSecond(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.YearToSecond(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }
    }
}
