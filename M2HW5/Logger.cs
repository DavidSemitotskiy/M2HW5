using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW5
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public List<Log> Logs { get; } = new List<Log>();
        public static Logger Instance
        {
            get => _instance;
        }

        public void AddLog(string message, TypesOfLog typeLog)
        {
            Logs.Add(new Log(message, typeLog));
        }

        public void PrintLogs()
        {
            foreach (var log in Logs)
            {
                Console.WriteLine($"{log.DateLog} : {log.TypeLog} : {log.Message}");
            }

            FileService.SaveToFile(this);
        }

        public string GetString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{Logs[0].DateLog} : {Logs[0].TypeLog} : {Logs[0].Message}");
            for (int i = 0; i < Logs.Count; i++)
            {
                str.Append($"\n{Logs[i].DateLog} : {Logs[i].TypeLog} : {Logs[i].Message}");
            }

            return Convert.ToString(str);
        }
    }
}
