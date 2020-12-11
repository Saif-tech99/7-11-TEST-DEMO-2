using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
    public class Autovakantie : Reis
    {
        public const double EXTRAPRIJSHUURAUTO = 10.00d;
        private bool EigenWagen { get; set; }

        public override double BerekenPrijs()
        {
            if (EigenWagen == true && AantalPersonen <= 5)
            {
                return (base.BerekenPrijs() + (EXTRAPRIJSHUURAUTO * AantalDagen * AantalPersonen)) / AantalPersonen;
            }
            else if (EigenWagen == true && AantalPersonen > 5 && AantalPersonen <= 10)
            {
                return (base.BerekenPrijs() + (EXTRAPRIJSHUURAUTO * 2 * AantalPersonen)) / AantalPersonen;
            }
            return base.BerekenPrijs();
        }

        public Autovakantie(bool eigenWagen, DateTime vv, DateTime tt, int aap)
        : base(vv, tt, aap)
        {
            this.EigenWagen = eigenWagen;
        }
    }
}
