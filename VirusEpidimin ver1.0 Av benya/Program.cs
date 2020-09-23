using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VirusEpidimin_ver1._0_Av_benya
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personas = new Person();
            personas.Name = "Person1";
            personas.SmittadNär = 0;
            personas.Immun = false;
            personas.Smittad = false;

            string[] personsarray = new string[50];
            Random randNum = new Random();
            for (int i = 0; i < personsarray.Length; i++)
            {
                personsarray[i] = randNum.Next(1, 50).ToString();
            }

            foreach (var personsarrayNames in personsarray)
            {
                Console.WriteLine($"Person { personsarrayNames} " );
            }


        }
    }
}
