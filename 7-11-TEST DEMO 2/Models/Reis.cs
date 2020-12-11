using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2
{
    public abstract class Reis
    {
        private const double BASISDAGPRIJS = 40.00d;
        public DateTime Terugkeerdatum { get; set; }
        public DateTime vertrekdatum { get; set; }
        public int AantalPersonen { get; set; }
        public int AantalDagen { get 
            {
                TimeSpan aant = Terugkeerdatum - vertrekdatum;
                return aant.Days;
            }
        }

        public virtual double BerekenPrijs()
        {
            return AantalDagen * BASISDAGPRIJS;
        }

        public Reis(DateTime ver, DateTime ter, int aanp)
        {
            this.AantalPersonen = aanp;
            this.vertrekdatum = ver;
            this.Terugkeerdatum = ter;
        }
    }
}
