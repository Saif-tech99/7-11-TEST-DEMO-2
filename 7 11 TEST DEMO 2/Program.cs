using _7_11_TEST_DEMO_2;
using _7_11_TEST_DEMO_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_TEST_DEMO_P_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Reis[] reis1 = new Reis[2];
            reis1[0] = new Autovakantie(true, new DateTime(11, 10, 2021), new DateTime(11, 10, 2020), 6);
            reis1[1] = new Cruise(true, new DateTime(10, 02, 2022), new DateTime(10, 03, 2022), 3);
            reis1[2] = new Vliegtuigvakantie(true, new DateTime(10, 02, 2022), new DateTime(10, 03, 2022), 3);
            double v0 = reis1[0].BerekenPrijs();
            double v1 = reis1[1].BerekenPrijs();
            double v2 = reis1[2].BerekenPrijs();
            string v00 = $"{reis1[0].AantalDagen} {reis1[0].AantalPersonen} {reis1[0].vertrekdatum} {reis1[0].Terugkeerdatum} {reis1[0].BerekenPrijs()}";
            string v11= $"{reis1[1].AantalDagen} {reis1[1].AantalPersonen} {reis1[1].vertrekdatum} {reis1[1].Terugkeerdatum} {reis1[1].BerekenPrijs()}";
            string v22= $"{reis1[2].AantalDagen} {reis1[2].AantalPersonen} {reis1[2].vertrekdatum} {reis1[2].Terugkeerdatum} {reis1[2].BerekenPrijs()}";
            Console.WriteLine(v0 + " " + v00);
            Console.WriteLine(v1 + " " + v11);
            Console.WriteLine(v2 + " " + v22);
            Person[] people1 = new Person[1];
            people1[0] = new Person
            {
                FamilieNaam = "saif1",
                VoorNaam = "saif",
                Adres = new Adres
                {
                    Gemeente = "sG",
                    StraatNaam = "2s",
                    HuisNr = 77,
                    PostCode = "S7"
                }
            };
            string P1 = $" {people1[0].Adres.Gemeente} {people1[0].Adres.PostCode} {people1[0].Adres.HuisNr} {people1[0].Adres.StraatNaam}";
            string P = people1[0].Naam;
            Console.WriteLine(P + " " + P1);
            Console.WriteLine();
            Reisbureau[] reisbureaus1 = new Reisbureau[1];
            reisbureaus1[0] = new Reisbureau
            {
                Adres = new Adres
                {
                    Gemeente = "r1",
                    StraatNaam = "r2",
                    HuisNr = 3,
                    PostCode = "r4"
                },
                Naam = "reisbb",
            };
            string s = reisbureaus1[0].Naam;
            string s1 = $" {reisbureaus1[0].Adres.Gemeente} {reisbureaus1[0].Adres.PostCode} {reisbureaus1[0].Adres.HuisNr} {reisbureaus1[0].Adres.StraatNaam}";

            Console.WriteLine(s + " " + s1);
            Reisreservatie[] reisreservaties1 = new Reisreservatie[1];
            reisreservaties1[0] = new Reisreservatie(people1[0], reis1[0], reisbureaus1[0]);
        }
    }
}
