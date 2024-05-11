using System;

namespace SpaghettiCron.Lib.Class
{
    public class CronExpression
    {

        public CronElement minute { get; set; }
        public CronElement hour { get; set; }
        public CronElement dayOfMonth { get; set; }
        public CronElement month { get; set; }
        public CronElement dayOfWeek { get; set; }


        public CronExpression() { 
        
            minute = new CronElement();
            hour = new CronElement();
            dayOfMonth = new CronElement();
            month = new CronElement();
            dayOfWeek = new CronElement();



        }

        public override string ToString()
        {
            return $"{minute.ToString()} {hour.ToString()} {dayOfMonth.ToString()} {month.ToString()} {dayOfWeek.ToString()}";
        }

        public TimeSpan ToTimeSpan()
        {
            return new TimeSpan(); //TODO
        }

        public  string ToReadableString()
        {
            return $"";  //TODO
        }

    }



}
