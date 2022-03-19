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
            SimpleDataBase<int> objData = new SimpleDataBase<int>();
            objData.AddNewData(13);
            objData.AddNewData(02);
            objData.AddNewData(20);
            objData.PrintAllData();
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
        public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase()
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }

            public void AddNewData(T newdata)
            {
                storedData.Add(newdata);
                inputDates.Add(DateTime.Now);
            }
            public void PrintAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + " yang disimpan pada waktu UTC : " + inputDates[i] + " AM");
                }
            }
        }
    }
}