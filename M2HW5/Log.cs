using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW5
{
    public class Log
    {
        public Log(string message, TypesOfLog typesOfLog)
        {
            Message = message;
            DateLog = DateTime.Now;
            TypeLog = typesOfLog;
        }

        public string Message { get; }
        public DateTime DateLog { get; }
        public TypesOfLog TypeLog { get; }
    }
}
