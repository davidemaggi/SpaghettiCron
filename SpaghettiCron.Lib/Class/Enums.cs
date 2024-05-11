using System;
using System.Collections.Generic;
using System.Text;

namespace SpaghettiCron.Lib.Class
{
    public class Enums
    {
        public enum CronType
        {
            ANY,
            SPECIFIC,
            EVERY,
            LIST,
            RANGE
        }

        public enum CronElementType
        {
            MINUTE,
            HOUR,
            DAY_OF_MONTH,
            MONTH,
            DAY_OF_WEEK
        }

        public enum CronElementMonths
        {
            JANUARY =1,
            FEBRUARY =2,
            MARCH =3,
            APRIL =4,
                
            MAY =5,
            JUNE =6,
                JULY =7,

                AUGUST =8,
                SEPTEMBER =9,
                OCTOBER =10,
                NOVEMBER =11,
                DECEMBER =12

            
        }

        public enum CronElementDaysOfWeek
        {
            SUNDAY = 0,
            MONDAY = 1,
            TUESDAY = 2,
            WEDNESDAY = 3,
            THURSDAY = 4,
            FRIDAY = 5,
            SATURDAY = 6
        }
      


    }
}
