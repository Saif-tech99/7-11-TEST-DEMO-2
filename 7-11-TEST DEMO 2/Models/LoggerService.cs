using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
    public static class LoggerService
    {
        public static LogMessage[] log = new LogMessage[0];
        private static LogMessage[] Log { get; set; }

        public static void AddLogMessage(LogMessage message)
        {
            Array.Resize(ref log, Log.Length + 1);
            Log[Log.Length - 1] = message;
        }
    }
}
