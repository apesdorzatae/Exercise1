using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablevariety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipeInteger = 10;
            float tipeFloat = 10.5f;
            double tipeDouble = 10.75;
            string tipeString = "Sepuluh";
            bool tipeBool = true;
            char tipeCharacter = 'A';

            Console.WriteLine("Tipe-Tipe Variable\n\nTipe Integer : {0}\nTipe Float : {1}\nTipe Double : {2}\nTipe String : {3}\nTipe Boolean : {4}\nTipe Character : {5}\n\n[All Done]", tipeInteger,tipeFloat,tipeDouble,tipeString,tipeBool,tipeCharacter);
        }
    }
}
