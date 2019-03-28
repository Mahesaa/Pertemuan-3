using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Program 
    {
        static void Main(string[] args)
        {
            mahasiswa Saya = new mahasiswa();
            mahasiswa Anda = new mahasiswa();

            Saya.Nim = "52465";
            Saya.Nama = "Mahesa";
            Saya.IPK = 1.86;

            Anda.Nim = "15263";
            Anda.Nama = "Af";
            Anda.IPK = 2919;

            Saya.Reg();
            Saya.isikrs();

            Anda.Reg();
            Anda.isikrs();

            Console.ReadKey();
        }
    }
}
