using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string IPK { get; set; }

        public void Reg()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("Nim: {0}", Nim);
            Console.WriteLine("IPK: {0}", IPK);
            Console.WriteLine("\nTelah melakukan Reg: {0}");
        }

        public void isikrs()
        {
            Console.WriteLine("{0}Sedang Melakukan proses KRS ", Nama);
        }

    }
}
