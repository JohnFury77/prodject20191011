using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project20191011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek 10 számot.");
            int[] szam = new int[10];
            for (int i = 0; i < 10; i++)
            {
                szam[i] = int.Parse(Console.ReadLine());
            }
            string fajlnev;
            Console.WriteLine("Kérem a fájlnevet.");
            fajlnev = Console.ReadLine();
            string asd = "";
            for (int j = 0; j < 10; j++)
            {

            }
             File.WriteAllText(fajlnev + ".txt",asd);
        }
    }
}
