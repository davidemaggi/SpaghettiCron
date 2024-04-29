using System;
using System.Collections.Generic;
using System.Text;
using static SpaghettiCron.Lib.Class.Enums;

namespace SpaghettiCron.Lib.Class
{
    public class CronElement
    {
        public int? value { get; set; }

        public CronRange range { get; set; } = null;
        public int[] list { get; set; } = null;

        public CronType type { get; set; } = CronType.ANY;


        public CronElement() { 
        

        
        }



        public override string ToString()
        {
            switch (this.type) {

                case CronType.ANY:
                    return "*";

                case CronType.SPECIFIC:
                    return $"{this.value}";
                
                case CronType.EVERY:
                    return $"*/{this.value}";
                
                case CronType.LIST:
                    return $"{string.Join(",",this.list)}";

                case CronType.RANGE:
                    return $"{this.range.start}-{this.range.end}";

                default:
                    return $"{this.value}";
            }
                

           
        }









    }


    

        public class CronRange
    {

        public int start { get; set; }
    public int end { get; set; }


}

    

}
