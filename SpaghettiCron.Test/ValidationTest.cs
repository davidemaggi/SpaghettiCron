using SpaghettiCron.Lib;
using SpaghettiCron.Lib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpaghettiCron.Lib.Class.Enums;

namespace SpaghettiCron.Test
{
    public class ValidationTest
    {
        #region Minutes
        [Fact]
        public void MinutesGreaterThanZeroEvery()
        {
            
            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(-1, CronElementType.MINUTE).Build());
        }

        [Fact]
        public void MinutesLessThan60Every()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(60, CronElementType.MINUTE).Build());
        }

        [Fact]
        public void InvalidMinutesInterval()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.InRange(10,5, CronElementType.MINUTE).Build());
        }

        [Fact]
        public void InvalidStartMinutesInterval()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.InRange(-10, 5, CronElementType.MINUTE).Build());
        }
        [Fact]
        public void InvalidEndMinutesInterval()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.InRange(20, -5, CronElementType.MINUTE).Build());
        }
        [Fact]
        public void MinutesGreaterThanZeroSpcific()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.At(-1, CronElementType.MINUTE).Build());
        }
        [Fact]
        public void MinutesLessThan60Specific()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(60, CronElementType.MINUTE).Build());
        }

        [Fact]
        public void MinutesGreaterThanZeroList()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.In([0,1,-1], CronElementType.MINUTE).Build());
        }
        [Fact]
        public void MinutesLessThan60list()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.In([0, 1, 60], CronElementType.MINUTE).Build());

        }
        #endregion


        #region Hours
        [Fact]
        public void HoursGreaterThanZeroEvery()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(-1, CronElementType.HOUR).Build());
        }

        [Fact]
        public void HoursLessThan24Every()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(24, CronElementType.HOUR).Build());
        }

        [Fact]
        public void InvalidHoursInterval()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.InRange(10, 5, CronElementType.HOUR).Build());
        }

        [Fact]
        public void InvalidStartHoursInterval()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.InRange(-10, 5, CronElementType.HOUR).Build());
        }
        [Fact]
        public void InvalidEndHoursInterval()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.InRange(20, -5, CronElementType.HOUR).Build());
        }
        [Fact]
        public void HoursGreaterThanZeroSpcific()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.At(-1, CronElementType.HOUR).Build());
        }
        [Fact]
        public void HoursLessThan24Specific()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(24, CronElementType.HOUR).Build());
        }

        [Fact]
        public void HoursGreaterThanZeroList()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.In([0, 1, -1], CronElementType.HOUR).Build());
        }
        [Fact]
        public void HoursLessThan24list()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.In([0, 1, 24], CronElementType.HOUR).Build());

        }
        #endregion

        #region Daysd of Week

        #endregion

        #region Days of Month

        #endregion

        #region Month

        #endregion
    }
}
