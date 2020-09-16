using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Övning 6
1 Skogen
◦
Skapa ett objekt som har följande egenskaper
◦
string Name Namn ska vara Varg, Fladdermus , Delfin, Örn , Häst och några till om du vill.
◦
bool Nocturnal Nattdjur , sant eller falskt
Skapa minst en instans av varje djur , gärna fler, och stoppa i listan forrest
◦
Välj två knappar , som ska vara dag och natt
◦
Trycker du på nattknappen ska det stå följande om vargen och fladdermusen (och andra nattdjur
◦
“Vargen smyger omkring och letar sitt byte” och “ Fladdermusen flyger runt bland träden I jakt på mat”.
◦
De djur som inte är nocturnal beskrivs med: Hästen sover, Delfinen sover osv
◦
Trycker du på dagknappen så ska det omvända ske, Vargen och Fladdermusen
*/
namespace Övning_6_1_Skogen_Av_Benya
{
    class Program
    {
        static void Main(string[] args)
        {

            bool day;

            //föra in i klass / metod?
            var dayAnimals = new List<string>();
            dayAnimals.Add("Örn");
            dayAnimals.Add("Hare");
            dayAnimals.Add("Björn");
            dayAnimals.Add("Kråka");
            dayAnimals.Add("Myra");
            foreach (var day1 in dayAnimals)
            {
                Console.WriteLine("");
                Console.WriteLine($"Dagsdjur: {day1}");
            }
            //föra in i klass / metod?
            var nightAnimals = new List<string>();
            nightAnimals.Add("Varg");
            nightAnimals.Add("Fladdermus");
            nightAnimals.Add("Uggla");
            nightAnimals.Add("Spindel");
            foreach (var night1 in nightAnimals)
            {
                Console.WriteLine("");
                Console.WriteLine($"Nattdjur: {night1}");
            }
            Console.Clear();

            Console.WriteLine("Se natt eller dag? (D/N)");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'd')
            {
                day = true;
                foreach (var dayAnimalsToShow in dayAnimals)
                {
                    Console.WriteLine($"dagdjur: {dayAnimalsToShow}");
                }
                Console.WriteLine();
            }
            else if (key.KeyChar == 'n')
            {
                day = false;
                foreach (var nightanimalsToShow in nightAnimals)
                {
                    Console.WriteLine($"Nattdjur: {nightanimalsToShow}");
                }
            }
            else
            {
                Console.WriteLine("Använd korrekt bokstav");
            }

            Console.ReadKey();

        }
    }
    class Program2
    {
        public static void AnimalProperties()
        // Classes and Properties
        {
            Animal eagle = new Animal();
            eagle.NameAndProperty = "Örn";
            eagle.NightLife = "Örnen sover";
            eagle.DayLife = "Örnen flyger och letar efter byten";

            Animal wolf = new Animal();
            wolf.NameAndProperty = "Varg";
            wolf.NightLife = "Vargen är vaken och är på jakt";
            wolf.DayLife = "Vargen sover";

        }


    }
    class Animal
    {
        public string NameAndProperty { get; set; }
        public string NightLife { get; set; }
        public string DayLife { get; set; }
        public bool NightOrDay { get; set; }
        public static bool CheckNightOrDay(bool NightLife)
        {
            if (NightLife)
            {
                Console.WriteLine("Det är natt");
            }
            else
            {
                Console.WriteLine("Det är dag");
            }
            return NightLife;
        }
    }
}
