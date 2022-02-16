using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW5
{
    public static class Action
    {
        public static bool Fun1()
        {
            Logger logger = Logger.Instance;
            logger.AddLog("Start method: Fun1", TypesOfLog.Info);
            return true;
        }

        public static BusinessException Fun2()
        {
            return new BusinessException("Skipped logic in method");
        }

        public static void Fun3()
        {
            throw new Exception("I broke a logic");
        }
    }
}
