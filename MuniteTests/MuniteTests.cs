using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace MuniteTests
{
    [TestClass]
    public class MuniteTests
    {
        [TestMethod]
        [TestCase(2, 0.033333333333333333)]
        public void SecondToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.SecondToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 2)]
        public void MuniteToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MuniteToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 120)]
        public void HourToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.HourToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 2880)]
        public void DayToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.DayToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 20160)]
        public void WeekToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.WeekToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 87660)]
        public void MonthToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.MonthToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }

        [TestMethod]
        [TestCase(2, 1051920)]
        public void YearToMunite(double number, double expected)
        {
            TimeToTime.Form1 frm = new TimeToTime.Form1();
            double realValue = frm.YearToMunite(number);
            NUnit.Framework.Assert.AreEqual(expected, realValue);
        }
    }
}
