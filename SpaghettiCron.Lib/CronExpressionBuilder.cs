using System;
using System.Collections.Generic;
using System.Text;
using SpaghettiCron.Lib.Class;
using SpaghettiCron.Lib.Exceptions;
using static SpaghettiCron.Lib.Class.Enums;

namespace SpaghettiCron.Lib
{
    public class CronExpressionBuilder
    {
        private CronExpression _cron = new CronExpression();
        public CronExpressionBuilder Every(int val, CronElementType cet)
        {

            var el= new CronElement() { value = val, type = CronType.EVERY };

            switch (cet) {

                case CronElementType.MINUTE:
                    _cron.minute = el;
                    break;

                case CronElementType.HOUR:
                    _cron.hour = el;
                    break;

                case CronElementType.DAY_OF_WEEK:
                    _cron.dayOfWeek = el;
                    break;
                
                case CronElementType.DAY_OF_MONTH:
                    _cron.dayOfMonth = el;
                    break;

                case CronElementType.MONTH:
                    _cron.month = el;
                    break;

                default:
                    break;
                    

            }


           

            return this.Validate();
        }

        public CronExpressionBuilder InRange(int start,int end, CronElementType cet)
        {
            var el = new CronElement() { range=new CronRange(){start=start, end=end } , type = CronType.RANGE };

            switch (cet)
            {

                case CronElementType.MINUTE:
                    _cron.minute = el;
                    break;

                case CronElementType.HOUR:
                    _cron.hour = el;
                    break;

                case CronElementType.DAY_OF_WEEK:
                    _cron.dayOfWeek = el;
                    break;

                case CronElementType.DAY_OF_MONTH:
                    _cron.dayOfMonth = el;
                    break;

                case CronElementType.MONTH:
                    _cron.month = el;
                    break;

                default:
                    break;


            }

            return this.Validate();
        }

        public CronExpressionBuilder At(int val, CronElementType cet)
        {
            var el = new CronElement() { value = val, type = CronType.SPECIFIC };

            switch (cet)
            {

                case CronElementType.MINUTE:
                    _cron.minute = el;
                    break;

                case CronElementType.HOUR:
                    _cron.hour = el;
                    break;

                case CronElementType.DAY_OF_WEEK:
                    _cron.dayOfWeek = el;
                    break;

                case CronElementType.DAY_OF_MONTH:
                    _cron.dayOfMonth = el;
                    break;

                case CronElementType.MONTH:
                    _cron.month = el;
                    break;

                default:
                    break;


            }

            return this.Validate();
        }

        public CronExpressionBuilder Any( CronElementType cet)
        {
            var el = new CronElement() { type = CronType.ANY };

            switch (cet)
            {

                case CronElementType.MINUTE:
                    _cron.minute = el;
                    break;

                case CronElementType.HOUR:
                    _cron.hour = el;
                    break;

                case CronElementType.DAY_OF_WEEK:
                    _cron.dayOfWeek = el;
                    break;

                case CronElementType.DAY_OF_MONTH:
                    _cron.dayOfMonth = el;
                    break;

                case CronElementType.MONTH:
                    _cron.month = el;
                    break;

                default:
                    break;


            }

            return this.Validate();
        }

        public CronExpressionBuilder In(int[] vals, CronElementType cet)
        {
            var el = new CronElement() { list = vals, type = CronType.LIST };

            switch (cet)
            {

                case CronElementType.MINUTE:
                    _cron.minute = el;
                    break;

                case CronElementType.HOUR:
                    _cron.hour = el;
                    break;

                case CronElementType.DAY_OF_WEEK:
                    _cron.dayOfWeek = el;
                    break;

                case CronElementType.DAY_OF_MONTH:
                    _cron.dayOfMonth = el;
                    break;

                case CronElementType.MONTH:
                    _cron.month = el;
                    break;

                default:
                    break;


            }

            return this.Validate();
        }

        public CronExpressionBuilder Validate()
        {
            //Minute Element

            if (_cron.minute.type == CronType.ANY) {
                if (_cron.minute.value != null)
                {
                    throw new ElementAnyNotNullException("ANY element must be null");
                }
            }

            if (_cron.minute.type == CronType.SPECIFIC || _cron.minute.type == CronType.EVERY)
            {
                if (_cron.minute.value<0 || _cron.minute.value > 59) {
                    throw new ElementNotInValidRangeException("Valid range for minutes is 0-59");
                }

            }

            if (_cron.minute.type == CronType.RANGE)
            {
                if (_cron.minute.range.start < 0 || _cron.minute.range.start > 59 || _cron.minute.range.start> _cron.minute.range.end)
                {
                    throw new ElementNotInValidRangeException("Start of range must be 0-59 and less or equal to end");
                }
                if (_cron.minute.range.end < 0 || _cron.minute.range.end > 59 || _cron.minute.range.end < _cron.minute.range.start)
                {
                    throw new ElementNotInValidRangeException("End of range must be 0-59 and less or equal to start");
                }
            }

            if (_cron.minute.type == CronType.LIST)
            {
                foreach (var i in _cron.minute.list) {

                    if (i < 0 || i > 59)
                    {
                        throw new ElementNotInValidRangeException("Valid range for minutes is 0-59");
                    }

                }

            }

            return this;
        }


        public CronExpression Build()
        {

            this.Validate();

            return _cron;
        }

        
    }
}
