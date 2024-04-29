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



      

    }
}
