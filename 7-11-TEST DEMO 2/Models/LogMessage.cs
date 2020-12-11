using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
    public class LogMessage
    {
        private string Boodschap { get; set; }
        private int ID { get; set; }

        private int GenererId()
        {
            Random random = new Random();
            ID = random.Next(00000, 99999) + 1;
            return ID;
        }

        public LogMessage(string message)
        {
            this.Boodschap = message;
            this.ID = GenererId();
        }
    }
}
