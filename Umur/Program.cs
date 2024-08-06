using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================\nAplikasi Cek Umur\n=================================================\n\nMasukkan nama anda :");
        string nama = Console.ReadLine();   
            Console.WriteLine("Masukkan tahun lahir anda :");
            int tahun = int.Parse(Console.ReadLine());
            int umur = DateTime.Now.Year - tahun;
            if (umur < 0 || umur > DateTime.Now.Year)
            {
                Console.WriteLine("\n=================================================");
                Console.WriteLine("Nama Anda :" + nama + "\nUmur Anda : [Error] Umur Tidak Benar");
            }
            else
            {
                Console.WriteLine("\n=================================================");
                Console.WriteLine("Nama Anda :" + nama + "\nUmur Anda :" + umur);
            }
        }
    }
}
