using SpaghettiCron.Lib;
using static SpaghettiCron.Lib.Class.Enums;

namespace SpaghettiCron.Test
{
    public class EveryTest
    {
        [Fact]
        public void Every10Minutes()
        {
            var expected = "*/10 * * * *";
            var _builder = new CronExpressionBuilder();
            string result = _builder.Every(10,CronElementType.MINUTE).Build().ToString();

            Assert.Equivalent(result,expected);
        }

        [Fact]
        public void Default()
        {
            var expected = "* * * * *";
            var _builder = new CronExpressionBuilder();
            string result = _builder.Build().ToString();

            Assert.Equivalent(result, expected);
        }

       
    }
}