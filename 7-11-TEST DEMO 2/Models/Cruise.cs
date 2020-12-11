using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
    public class Cruise : Reis
    {
        public const double CRUISEPRIJSEXTRADAGKOST = 10.00d;
        private bool VIP { get; set; }

        public override double BerekenPrijs()
        {
            if (VIP == true && AantalPersonen <= 5)
            {
                return (base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGKOST * AantalDagen * AantalPersonen * 1.5)) / AantalPersonen;
            }

            return (base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGKOST * AantalDagen * AantalPersonen)) / AantalPersonen;
        }

        public Cruise(bool vip, DateTime ver, DateTime ter, int aanp)
            : base(ver, ter, aanp)
        {
            this.VIP = vip;
        }
    }
}
