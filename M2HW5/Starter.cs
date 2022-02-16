using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW5
{
    public static class Starter
    {
        public static void Run()
        {
            Logger logger = Logger.Instance;
            BusinessException businessException = null;
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    switch (rand.Next(3))
                    {
                        case 0:
                            Action.Fun1();
                            break;
                        case 1:
                            businessException = Action.Fun2();
                            break;
                        default:
                            Action.Fun3();
                            break;
                    }

                    if (businessException != null)
                    {
                        logger.AddLog($"Action got this custom Exception: {businessException.Message}", TypesOfLog.Warning);
                        businessException = null;
                    }
                }
                catch (Exception exception)
                {
                    logger.AddLog($"Action failed by reason: {exception}", TypesOfLog.Error);
                }
            }

            logger.PrintLogs();
        }
    }
}
