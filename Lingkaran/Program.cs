using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingkaran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================================\nMesin Pencari Luas dan Keliling Lingkaran Otomatis\n=======================================================\nCarilah luas dan keliling lingkaran jika phi = 3,14!\nMasukkan r :");
            double phi = 3.14;
            double r = double.Parse(Console.ReadLine());
            double luas = r * r * phi;
            double keliling = (r + r) * phi;
            Console.WriteLine($"\nHasilnya :\n\nLuas {luas}\nKeliling {keliling}\n\n\nDah betul kok tipe datanya Mr :))");
        }
    }
}
