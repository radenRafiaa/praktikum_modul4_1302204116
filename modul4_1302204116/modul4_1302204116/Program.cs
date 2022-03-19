using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204116
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SimpleDataBase<int> objData = new SimpleDataBase<int>();
            objData.AddNewData(13);
            objData.AddNewData(02);
            objData.AddNewData(20);
            objData.PrintAllData();
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



