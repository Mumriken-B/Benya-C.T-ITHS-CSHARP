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
            AnimalProperties animalv = new AnimalProperties();
            animalv.Name = "Varg";
            animalv.nocturnal = true;
            animalv.nightmessage = "Vargen smyger omkring och letar sitt byte";
            animalv.daymessage = "Vargen sover";

            AnimalProperties animalf = new AnimalProperties();
            animalf.Name = "Fladdermus";
            animalf.nocturnal = true;
            animalf.nightmessage = "Fladdermusen flyger runt bland träden I jakt på mat";
            animalf.daymessage = "fladdermusen sover";

            AnimalProperties animald = new AnimalProperties();
            animald.Name = "Defin";
            animald.nocturnal = false;
            animald.nightmessage = "Delfinen sover";
            animald.daymessage = "Delfinen har tappat bort sig och hamnat i en sjö under en varm dag";


            AnimalProperties animalö = new AnimalProperties();
            animalö.Name = "Örnen";
            animalö.nocturnal = false;
            animalö.nightmessage = "Örnen sover";
            animalö.daymessage = "Örnen flyger och letar efter sitt byte under dagen";

            Console.WriteLine("Se natt eller dag? (D/N)");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.KeyChar == 'd')
            {
                Console.WriteLine("Det är dag! Så här beter djuren sig:");
                Console.WriteLine(animalö.daymessage);
                Console.WriteLine(animald.daymessage);
                Console.WriteLine(animalv.daymessage);
                Console.WriteLine(animalf.daymessage);
            }
            else if (key.KeyChar == 'n')
            {
                Console.WriteLine("Det är natt! Så här beter djuren sig:");
                Console.WriteLine(animalö.nightmessage);
                Console.WriteLine(animald.nightmessage);
                Console.WriteLine(animalv.nightmessage);
                Console.WriteLine(animalf.nightmessage);
            }
            else
            {
                Console.WriteLine("Använd korrekt bokstav");
            }
            Console.ReadKey();

        }
    }
}
