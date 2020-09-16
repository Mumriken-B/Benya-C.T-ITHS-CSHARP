using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KladdTraining
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] siffror = new int[3];
            siffror[0] = 11;
            siffror[1] = 785;
            siffror[2] = 4;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(siffror[i]);
            }

        }
    }
}