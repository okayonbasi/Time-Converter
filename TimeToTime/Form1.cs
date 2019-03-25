using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToTime
{
    public partial class Form1 : Form
    {
        /**
        *
        * @author Okay
        */

        
        public Form1()
        {
            InitializeComponent();
        }

        /****** Second Processes ******/

        
        /// <summary>
        /// This is converting from second to second
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToSecond(double x) 
        {
            return x;   
        }

        /// <summary>
        /// This is converting from munite to secoond
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToSecond(double x) 
        {
            return x * 60;
        }
        
        /// <summary>
        /// This is converting from hour to second
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToSecond(double x)
        {
            return HourToMunite(x) * 60;
        }

        /// <summary>
        /// This is converting from day to second
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToSecond(double x)
        {
            return SecondToSecond(HourToMunite(DayToHour(x))) * 60;
        }
        
        /// <summary>
        /// This is converting from week to second
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToSecond(double x) 
        {
            return x * 604800.02;
        }

        /// <summary>
        /// This is converting from month to second
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToSecond(double x)
        {
            return 2629800 * x;
        }

        /// <summary>
        /// This is converting from year to second
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToSecond(double x) 
        {
            return MonthToSecond(x) * 12;
        }


        /****** Munite Processes ******/

       
        /// <summary>
        /// This is converting from second to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToMunite(double x) 
        {
            return x / 60;
        }

        /// <summary>
        /// This is converting from munite to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToMunite(double x)
        {
            return x;
        }

        /// <summary>
        /// This is converting from hour to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToMunite(double x)
        {
            return x * 60;
        }

        /// <summary>
        /// This is converting from day to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToMunite(double x)
        {
            return HourToMunite(x) * 24;
        }

        /// <summary>
        /// This is converting from week to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToMunite(double x)
        {
            return DayToMunite(x) * 7;
        }

        /// <summary>
        /// This is converting from month to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToMunite(double x)
        {
            return 730.5 * 60 * x;
        }

        /// <summary>
        /// This is converting from year to munite
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToMunite(double x)
        {
            return MonthToMunite(x) * 12 ;
        }


        /****** Hour Processes ******/

        /// <summary>
        /// This is converting from second to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToHour(double x)
        {
            return x / 60 / 60;
        }

        /// <summary>
        /// This is converting from munite to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToHour(double x)
        {
            return x / 60;
        }

        /// <summary>
        /// This is converting from hour to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToHour(double x)
        {
            return x;
        }

        /// <summary>
        /// This is converting from day to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToHour(double x)
        {
            return x * 24;
        }

        /// <summary>
        /// This is converting from week to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToHour(double x)
        {
            return DayToHour(x) * 7;
        }

        /// <summary>
        /// This is converting from month to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToHour(double x)
        {
            return 30.4375 * x * 24;
        }

        /// <summary>
        /// This is converting from year to hour
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToHour(double x)
        {
            return x * 365 * 24 + 6 * x;
        }


        /****** Day Processes ******/

        /// <summary>
        /// This is converting from second to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToDay(double x)
        {
            return x * 1.15740;
        }

        /// <summary>
        /// This is converting from munite to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToDay(double x)
        {
            return HourToDay(x) / 60;
        }

        /// <summary>
        /// This is converting from hour to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToDay(double x)
        {
            return x / 24;
        }

        /// <summary>
        /// This is converting from day to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToDay(double x)
        {
            return x;
        }

        /// <summary>
        /// This is converting from week to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToDay(double x)
        {
            return x * 7;
        }

        /// <summary>
        /// This is converting from month to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToDay(double x)
        {
            return 30.4375 * x;
        }

        /// <summary>
        /// This is converting from year to day
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToDay(double x) 
        {
            return MonthToDay(x) * 12;
        }


        /****** Week Processes ******/


        /// <summary>
        /// This is converting from second to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToWeek(double x)
        {
            return MuniteToWeek(x) / 60;
        }

        /// <summary>
        /// This is converting from munite to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToWeek(double x)
        {
            return HourToWeek(x) / 60;
        }

        /// <summary>
        /// This is converting from hour to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToWeek(double x)
        {
            return DayToWeek(x) / 24;
        }

        /// <summary>
        /// This is converting from day to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToWeek(double x) 
        {
            return x * 0.14;
        }

        /// <summary>
        /// This is converting from week to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToWeek(double x)
        {
            return x;
        }

        /// <summary>
        /// This is converting from month to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToWeek(double x)
        {
            double y = 4.35;
            return Math.Floor(x * y);
        }

        /// <summary>
        /// This is converting from year to week
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToWeek(double x)
        {

            return 52.18 * x;
        }


        /****** Month Processes ******/


        /// <summary>
        /// This is converting from second to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToMonth(double x)
        {
            return MuniteToMonth(x) / 60;
        }

        /// <summary>
        /// This is converting from munite to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToMonth(double x)
        {
            return HourToMonth(x) / 60;
        }

        /// <summary>
        /// This is converting from hour to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToMonth(double x)
        {
            return DayToMonth(x) / 24;
        }

        /// <summary>
        /// This is converting from day to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToMonth(double x)
        {
            return x * 0.03;
        }

        /// <summary>
        /// This is converting from week to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToMonth(double x)
        {
            return x * 0.23;
        }

        /// <summary>
        /// This is converting from month to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToMonth(double x)
        {
            return x;
        }

        /// <summary>
        /// This is converting from year to month
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToMonth(double x)
        {

            return x * 12;
        }


        /****** Year Processes ******/

        /// <summary>
        /// This is converting from year to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SecondToYear(double x)
        {
            return MuniteToYear(x) / 60;
        }

        /// <summary>
        /// This is converting from munite to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MuniteToYear(double x)
        {
            return HourToYear(x) / 60;
        }

        /// <summary>
        /// This is converting from hour to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double HourToYear(double x)
        {
            return DayToYear(x) / 24;
        }

        /// <summary>
        /// This is converting from day to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double DayToYear(double x)
        {
            return x * 0.00274;
        }

        /// <summary>
        /// This is converting from week to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double WeekToYear(double x)
        {
            return x * 0.02;
        }

        /// <summary>
        /// This is converting from month to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double MonthToYear(double x)
        {
            return x * 0.0833333333;
        }

        /// <summary>
        /// This is converting from year to year
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double YearToYear(double x)
        {

            return x;
        }



        /// <summary>
        /// This is send to value that will be convert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (textBox1.Text == "" || Convert.ToDouble(textBox1.Text) < 0)
            {
                MessageBox.Show("Required number that bigger than 0");
            }
            else
            {
                try
                {
                    double x = Convert.ToDouble(textBox1.Text);

                    if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
                    {
                        result = SecondToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                    {
                        result = SecondToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
                    {
                        result = SecondToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
                    {
                        result = SecondToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
                    {
                        result = SecondToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)
                    {
                        result = SecondToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6)
                    {
                        result = SecondToYear(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
                    {
                        result = MuniteToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
                    {
                        result = MuniteToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
                    {
                        result = MuniteToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
                    {
                        result = MuniteToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
                    {
                        result = MuniteToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)
                    {
                        result = MuniteToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6)
                    {
                        result = MuniteToYear(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
                    {
                        result = HourToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
                    {
                        result = HourToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
                    {
                        result = HourToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
                    {
                        result = HourToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 4)
                    {
                        result = HourToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 5)
                    {
                        result = HourToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 6)
                    {
                        result = HourToYear(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
                    {
                        result = DayToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
                    {
                        result = DayToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
                    {
                        result = DayToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 3)
                    {
                        result = DayToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 4)
                    {
                        result = DayToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 5)
                    {
                        result = DayToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 6)
                    {
                        result = DayToYear(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
                    {
                        result = WeekToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)
                    {
                        result = WeekToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)
                    {
                        result = WeekToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 3)
                    {
                        result = WeekToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 4)
                    {
                        result = WeekToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 5)
                    {
                        result = WeekToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
                    {
                        result = WeekToYear(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
                    {
                        result = MonthToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 1)
                    {
                        result = MonthToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 2)
                    {
                        result = MonthToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 3)
                    {
                        result = MonthToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 4)
                    {
                        result = MonthToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 5)
                    {
                        result = MonthToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 6)
                    {
                        result = MonthToYear(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
                    {
                        result = YearToSecond(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 1)
                    {
                        result = YearToMunite(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 2)
                    {
                        result = YearToHour(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 3)
                    {
                        result = YearToDay(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 4)
                    {
                        result = YearToWeek(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 5)
                    {
                        result = YearToMonth(x);
                    }
                    else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 6)
                    {
                        result = YearToYear(x);
                    }
                    else
                    {
                        MessageBox.Show("choose time unit");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Value can not be text");
                }

            }
            if (result != 0)
            {
                decimal d = Convert.ToDecimal(result);
                if (d < 1)
                    MessageBox.Show("0" + d.ToString("#.##"));
                else
                    MessageBox.Show(d.ToString("#.##"));
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
