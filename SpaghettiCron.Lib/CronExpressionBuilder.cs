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
          
            #region Minutes


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

            #endregion

            #region Hours


            if (_cron.hour.type == CronType.ANY)
            {
                if (_cron.hour.value != null)
                {
                    throw new ElementAnyNotNullException("ANY element must be null");
                }
            }

            if (_cron.hour.type == CronType.SPECIFIC || _cron.hour.type == CronType.EVERY)
            {
                if (_cron.hour.value < 0 || _cron.hour.value > 23)
                {
                    throw new ElementNotInValidRangeException("Valid range for hours is 0-23");
                }

            }

            if (_cron.hour.type == CronType.RANGE)
            {
                if (_cron.hour.range.start < 0 || _cron.hour.range.start > 23 || _cron.hour.range.start > _cron.hour.range.end)
                {
                    throw new ElementNotInValidRangeException("Start of range must be 0-23 and less or equal to end");
                }
                if (_cron.hour.range.end < 0 || _cron.hour.range.end > 23 || _cron.hour.range.end < _cron.hour.range.start)
                {
                    throw new ElementNotInValidRangeException("End of range must be 0-23 and less or equal to start");
                }
            }

            if (_cron.hour.type == CronType.LIST)
            {
                foreach (var i in _cron.hour.list)
                {

                    if (i < 0 || i > 23)
                    {
                        throw new ElementNotInValidRangeException("Valid range for hours is 0-23");
                    }

                }

            }

            #endregion

            #region Days Of Month


            if (_cron.dayOfMonth.type == CronType.ANY)
            {
                if (_cron.dayOfMonth.value != null)
                {
                    throw new ElementAnyNotNullException("ANY element must be null");
                }
            }

            if (_cron.dayOfMonth.type == CronType.SPECIFIC || _cron.dayOfMonth.type == CronType.EVERY)
            {
                if (_cron.dayOfMonth.value < 1 || _cron.dayOfMonth.value > 31)
                {
                    throw new ElementNotInValidRangeException("Valid range for day of month is 1-31");
                }

            }

            if (_cron.dayOfMonth.type == CronType.RANGE)
            {
                if (_cron.dayOfMonth.range.start < 1 || _cron.dayOfMonth.range.start > 31 || _cron.dayOfMonth.range.start > _cron.dayOfMonth.range.end)
                {
                    throw new ElementNotInValidRangeException("Start of range must be 1-31 and less or equal to end");
                }
                if (_cron.dayOfMonth.range.end < 1 || _cron.dayOfMonth.range.end > 31 || _cron.dayOfMonth.range.end < _cron.dayOfMonth.range.start)
                {
                    throw new ElementNotInValidRangeException("End of range must be 1-31 and less or equal to start");
                }
            }

            if (_cron.dayOfMonth.type == CronType.LIST)
            {
                foreach (var i in _cron.dayOfMonth.list)
                {

                    if (i < 0 || i > 31)
                    {
                        throw new ElementNotInValidRangeException("Valid range for day og month is 0-31");
                    }

                }

            }

            #endregion

            #region Days Of Week


            if (_cron.dayOfWeek.type == CronType.ANY)
            {
                if (_cron.dayOfWeek.value != null)
                {
                    throw new ElementAnyNotNullException("ANY element must be null");
                }
            }

            if (_cron.dayOfWeek.type == CronType.SPECIFIC || _cron.dayOfWeek.type == CronType.EVERY)
            {
                if (_cron.dayOfWeek.value < 0 || _cron.dayOfMonth.value > 7)
                {
                    throw new ElementNotInValidRangeException("Valid range for day of week is 0-6");
                }

            }

            if (_cron.dayOfWeek.type == CronType.RANGE)
            {
                if (_cron.dayOfWeek.range.start < 0 || _cron.dayOfWeek.range.start > 6 || _cron.dayOfWeek.range.start > _cron.dayOfWeek.range.end)
                {
                    throw new ElementNotInValidRangeException("Start of range must be 0-6 and less or equal to end");
                }
                if (_cron.dayOfWeek.range.end < 0 || _cron.dayOfWeek.range.end > 6 || _cron.dayOfWeek.range.end < _cron.dayOfWeek.range.start)
                {
                    throw new ElementNotInValidRangeException("End of range must be 0-6 and less or equal to start");
                }
            }

            if (_cron.dayOfWeek.type == CronType.LIST)
            {
                foreach (var i in _cron.dayOfWeek.list)
                {

                    if (i < 0 || i > 6)
                    {
                        throw new ElementNotInValidRangeException("Valid range for day of week is 0-6");
                    }

                }

            }

            #endregion

            #region Months


            if (_cron.month.type == CronType.ANY)
            {
                if (_cron.month.value != null)
                {
                    throw new ElementAnyNotNullException("ANY element must be null");
                }
            }

            if (_cron.month.type == CronType.SPECIFIC || _cron.month.type == CronType.EVERY)
            {
                if (_cron.month.value < 1 || _cron.month.value > 12)
                {
                    throw new ElementNotInValidRangeException("Valid range for months is 1-12");
                }

            }

            if (_cron.dayOfWeek.type == CronType.RANGE)
            {
                if (_cron.month.range.start < 1 || _cron.month.range.start > 12 || _cron.month.range.start > _cron.month.range.end)
                {
                    throw new ElementNotInValidRangeException("Start of range must be 1-12 and less or equal to end");
                }
                if (_cron.month.range.end < 1 || _cron.month.range.end > 12 || _cron.month.range.end < _cron.month.range.start)
                {
                    throw new ElementNotInValidRangeException("End of range must be 1-12 and less or equal to start");
                }
            }

            if (_cron.month.type == CronType.LIST)
            {
                foreach (var i in _cron.month.list)
                {

                    if (i < 1 || i > 12)
                    {
                        throw new ElementNotInValidRangeException("Valid range for months is 1-12");
                    }

                }

            }

            #endregion

            return this;
        }


        public CronExpression Build()
        {

            this.Validate();

            return _cron;
        }

        
    }
}
