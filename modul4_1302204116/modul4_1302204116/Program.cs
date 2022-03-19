using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
        }

        class Penjumlahan
        {
            public static void JumlahTigaAngka<T>(T data1, T data2, T data3)
            {
                dynamic angka1 = data1;
                dynamic angka2 = data2;
                dynamic angka3 = data3;

                Console.WriteLine(angka1 + angka2 + angka3);
            }
        }
    }
}