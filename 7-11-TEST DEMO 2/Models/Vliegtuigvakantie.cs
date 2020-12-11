using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
    public class Vliegtuigvakantie : Reis
    {
        public const double VLIEGTIGTICKETPRIJS = 10.00d;
        private bool VliegtuigTicketPrijs { get; set; }

        public override double BerekenPrijs()
        {
            if (VliegtuigTicketPrijs == true)
            {
                return (base.BerekenPrijs() + (VLIEGTIGTICKETPRIJS * AantalDagen * AantalPersonen)) / AantalPersonen;
            }
            return base.BerekenPrijs();
        }
        public Vliegtuigvakantie(bool vliegtuigTicketPrijs, DateTime vv, DateTime tt, int aap)
        : base(vv, tt, aap)
        {
            this.VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }
    }
}
