using _7_11_TEST_DEMO_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
   public class Reisreservatie : Iloggable
    {
        public LogMessage logMessage { get; set; }

        public Person Person { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }

        public Reisreservatie( Person person, Reis reis, Reisbureau reisbureau)
        {
            this.Reisbureau = reisbureau;
            this.Reis = reis;
            this.Person = person;
            LoggerService.AddLogMessage(logMessage);
        }

      
    }
}
