using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace TCCMadeireira.Util
{
    class Log
    {
        const string LOG_NAME = "MadeOesteLog";
        const string SOURCE = "TCCMadeireira";
        public Log()
        {
            if(EventLog.SourceExists(SOURCE) == false)
            {
                EventLog.CreateEventSource(SOURCE, LOG_NAME);
            }
        }
        public void WriteEntry(string input, EventLogEntryType entryType)
        {
            //grava o texto na fonte de logs com o nome que      definimos para a constante SOURCE. 
            EventLog.WriteEntry(SOURCE, input, entryType);
        }
        public void WriteEntry(string input)
        {
            //loga um simples evento com a categoria de informação. 
            WriteEntry(input, EventLogEntryType.Information);
        }
        public void WriteEntry(Exception ex)
        {
            //loga a ocorrência de uma excessão com a categoria de erro. 
            WriteEntry(ex.ToString(), EventLogEntryType.Error);
        }
    }
}
