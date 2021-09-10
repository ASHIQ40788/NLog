using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo058
{
    class AddNumber
    {
        private readonly NLog nlog = new NLog();
        public int Sum(int FirstNumber,int secondNumber)
        {
            if (FirstNumber == 0 || secondNumber == 0)
            {
                nlog.LogDebug("Debug Unsuccessfull:Sum()");
                nlog.LogError("Null value");
                nlog.LogWarn("FirstNumber or secondNumber should not equal to 0");
                return 0;
            }
            else
            {
                int result = secondNumber + FirstNumber;
                nlog.LogDebug("Debug successfull:Sum()");
                nlog.LogInfo("sum method passed,Result:" + result);
                return result;
            }

            
        }

    }
}


