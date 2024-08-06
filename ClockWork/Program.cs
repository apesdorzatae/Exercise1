using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================\nKonversi Detik\n=========================================================\n\nMengubah Detik Menjadi Menit Dan Jam\n\nMasukkan Detik :");
        double sec = double.Parse(Console.ReadLine());
        double min = sec / 60;
        double h = sec / 3600;
            Console.WriteLine("\n{0} menit\n{1} jam", min,h);
        }
    }
}
