using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_2.Models
{
   public class Person
    {
        public Adres Adres { get; set; }
        public string VoorNaam { get; set; }
        public string FamilieNaam { get; set; }
        private string _naam;
        public string Naam
        {
            get 
            {
                _naam = VoorNaam + " " + FamilieNaam;
                return _naam; 
            }
        }
    }
}
