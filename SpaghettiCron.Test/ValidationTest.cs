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

        [Fact]
        public void MinutesGreaterThanZeroEvery()
        {
            
            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(-25, CronElementType.MINUTE).Build());
        }

        [Fact]
        public void MinutesLessThan60Every()
        {

            var _builder = new CronExpressionBuilder();

            Assert.Throws<ElementNotInValidRangeException>(() => _builder.Every(-25, CronElementType.MINUTE).Build());
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
    }
}
